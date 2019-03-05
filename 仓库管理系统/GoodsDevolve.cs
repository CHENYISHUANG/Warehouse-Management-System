using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseMOD;
using WarehouseBLL;

namespace 仓库管理系统
{
    public partial class GoodsDevolve : Form
    {
        WarehouseNumberBLL wnb = new WarehouseNumberBLL();            
        List<WarehouseNumberMOD> listw = new List<WarehouseNumberMOD>();//仓库集合 
        InventoryBLL ib = new InventoryBLL();                          
        InventoryMOD im = new InventoryMOD();                         //库存实体类  
        List<string> check_list = new List<string>();                 //存放用户勾选的物品
        bool checkbox_exist = false;                                  //标识datagridview中是否已创建checkbox
        public GoodsDevolve()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoodsDevolve_Load(object sender, EventArgs e)
        {
            listw = wnb.FindAll();
            com_warehouse_id.DataSource = listw;                     //绑定数据到选择仓库
            com_warehouse_id.DisplayMember = "Warehouse_name";
            com_warehouse_id.ValueMember = "Id";
            com_warehouse_id.SelectedItem = null;
            List<WarehouseNumberMOD> listw2 = new List<WarehouseNumberMOD>(listw);
            com_put_warehouse.DataSource = listw2;                    //绑定数据到转入仓库
            com_put_warehouse.DisplayMember = "Warehouse_name";
            com_put_warehouse.ValueMember = "Id";
            com_put_warehouse.SelectedItem = null;
        }
        /// <summary>
        /// 窗体大小改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoodsDevolve_Resize(object sender, EventArgs e)
        {
            panel_center.Width = this.Width;
            panel_center.Height = Convert.ToInt32(this.Height * 0.5);
            panel_center.Top = com_warehouse_id.Top + 21;
            panel_center.Left = 0;
            panel_dowm.Width = this.Width;
            panel_dowm.Height = 50;
            panel_dowm.Top = panel_center.Top + panel_center.Height + 5;
            data_storage.Height = Convert.ToInt32(this.Height * 0.5);
            data_storage.Top = 0;
            btn_put.Top = Convert.ToInt32(this.Height * 0.85);
            data_storage.ClearSelection();
        }
        /// <summary>
        /// 转库按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_put_Click(object sender, EventArgs e)
        {
            check_list.Clear();                                      //清空list
            if (com_put_warehouse.Text == "" || com_warehouse_id.Text == "" || text_goods_amount.Text == "")
            {
                MessageBox.Show("请输入完整，不能有空项！", "提示");
                return;
            }
            foreach (DataGridViewRow rows in data_storage.Rows)      //遍历datagirdview，将选中的行ID加入list
            {
                if ((bool)rows.Cells[0].EditedFormattedValue == true)
                {
                    check_list.Add(rows.Cells[1].Value.ToString());
                }
            }
            if (check_list.Count == 0)
            {
                MessageBox.Show("您并没有选中任何物品！", "提示");
                return;
            }
            //调用转仓方法
            if (ib.Transfer(Int32.Parse(com_warehouse_id.SelectedValue.ToString()), Int32.Parse(com_put_warehouse.SelectedValue.ToString()), check_list, Int32.Parse(text_goods_amount.Text)))
            {
                MessageBox.Show("操作成功！");
                ReSet();
            }
            else 
            {
                MessageBox.Show("操作失败，输入数量超出总数量！","警告");
            }
        }
        /// <summary>
        /// 选择仓库的下拉列表选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void com_warehouse_id_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();    //添加一列复选框
            data_storage.DataSource = ib.GetAllById(Int32.Parse(com_warehouse_id.SelectedValue.ToString())).Tables[0];
            if (!checkbox_exist)
            {
                checkBoxColumn.Name = "select";
                checkBoxColumn.HeaderText = "选择";
                this.data_storage.Columns.Insert(0, checkBoxColumn);
                checkbox_exist = true;
            }
            foreach (DataGridViewRow rows in data_storage.Rows)              //循环把其他列设置为不可更改
            {
                rows.Cells[1].ReadOnly = true;
                rows.Cells[2].ReadOnly = true;
                rows.Cells[3].ReadOnly = true;
                rows.Cells[4].ReadOnly = true;
                rows.Cells[5].ReadOnly = true;
            }
        }
        /// <summary>
        /// 重置所有用户输入
        /// </summary>
        private void ReSet()     
        {
            data_storage.AutoGenerateColumns = false;          //重置datagridview并且不清空标题
            data_storage.DataSource = null;
            com_put_warehouse.SelectedItem = null;
            com_warehouse_id.SelectedItem = null;
            text_goods_amount.Text = "";
        }
        /// <summary>
        /// 重置按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_reset_Click(object sender, EventArgs e)
        {
            ReSet();
        }

    }
}
