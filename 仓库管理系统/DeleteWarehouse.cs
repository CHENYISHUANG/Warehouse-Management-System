using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseBLL;
using WarehouseMOD;

namespace 仓库管理系统
{

    public partial class DeleteWarehouse : Form
    {
        int warehouseid = -1;
        WarehouseNumberBLL wnb = new WarehouseNumberBLL();            //仓库逻辑层 
        InventoryBLL ib = new InventoryBLL();
        List<WarehouseNumberMOD> list = new List<WarehouseNumberMOD>();//实体类集合
        public DeleteWarehouse(int warehouseid)
        {
            this.warehouseid = warehouseid;
            InitializeComponent();
        }
        /// <summary>
        /// 关闭按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteWarehouse_Load(object sender, EventArgs e)
        {
            com_warehouse_id.DisplayMember = "Warehouse_name";             //绑定仓库到下拉列表
            com_warehouse_id.ValueMember = "Id";
            list = wnb.FindAll();
            com_warehouse_id.DataSource = list;
            com_warehouse_id.SelectedItem = null;                          //清除默认选中
        }
        /// <summary>
        /// 确认按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (com_warehouse_id.Text == "")
            {
                MessageBox.Show("请选择要转移的仓库");
            }
            else
            {
                if (MessageBox.Show("您确定执行此操作？（此操作不能撤销），确定执行?", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ib.Transfer(warehouseid, Int32.Parse(com_warehouse_id.SelectedValue.ToString()));   //更改数据
                    wnb.Delete(warehouseid);                                                            //删除数据库
                    this.DialogResult = DialogResult.OK;                                                //设定返回值
                    this.Close();
                }
            }

        }
        /// <summary>
        /// 不转移按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("此操作会将该仓库的数据清空，确定执行?","警告",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                ib.Delete(warehouseid);                                                                //删除和该仓库相关的数据
                wnb.Delete(warehouseid);                                                               //删除数据库
                this.DialogResult = DialogResult.OK;                                                   //设定返回值
                this.Close();
            }
        }
    }
}
