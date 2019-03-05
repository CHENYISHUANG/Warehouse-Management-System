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
    public partial class NewOutInventory : Form
    {
        string goods_id = "";                                         //储存用户选择的物品ID
        GoodsTypeBLL gtb = new GoodsTypeBLL();                        //物品类型逻辑层
        List<GoodsTypeMOD> listgtm = new List<GoodsTypeMOD>();        //物品类型集合    
        GoodsTypeMOD gtm = new GoodsTypeMOD();                        //物品类型实体类
        GoodsBLL gb = new GoodsBLL();                                 //物品逻辑层
        GoodsMOD gm = new GoodsMOD();                                 //物品实体类      
        List<GoodsMOD> listgm = new List<GoodsMOD>();                 //物品集合
        OperationTypeBLL ob = new OperationTypeBLL();                 //操作类型逻辑层   
        List<OperationTypeMOD> listo = new List<OperationTypeMOD>();  //操作类型实体集合  
        OperationTypeMOD om = new OperationTypeMOD();                 //操作类型实体类  
        InventoryBLL ib = new InventoryBLL();                         //库存逻辑层   
        InventoryMOD im = new InventoryMOD();                         //库存实体类  
        List<InventoryMOD> listi = new List<InventoryMOD>();          //清单集合 
        BillBLL bb = new BillBLL();                                   //清单逻辑层  
        BillMOD bm = new BillMOD();                                   //清单实体模型
        WarehouseNumberBLL wnb = new WarehouseNumberBLL();            //仓库逻辑层
        WarehouseNumberMOD wnm = new WarehouseNumberMOD();            //仓库实体模型
        List<WarehouseNumberMOD> listw = new List<WarehouseNumberMOD>();//仓库实体集合
        ClientBLL cb = new ClientBLL();                               //客户逻辑层
        ClientMOD cm = new ClientMOD();                               //客户实体类
        List<ClientMOD> listc = new List<ClientMOD>();                //客户实体集合
        public NewOutInventory()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewOutInventory_Load(object sender, EventArgs e)
        {
            com_warehouse_id.DisplayMember = "Warehouse_name";      //绑定仓库数据
            com_warehouse_id.ValueMember = "Id";
            com_warehouse_id.DataSource = wnb.FindAll();
            com_type_id.DisplayMember = "Operation_type";           //绑定出库方式数据
            com_type_id.ValueMember = "Id";
            com_type_id.DataSource = ob.FindOutAll();
            com_client_id.DisplayMember = "Client_name";
            com_client_id.ValueMember = "Id";
            com_client_id.DataSource = cb.FindAll();
        }
        /// <summary>
        /// 仓库的更改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void com_warehouse_id_TextChanged(object sender, EventArgs e)
        {
            labe_goods.Text = "";
        }
         /// <summary>
         /// 物品LABel的单击事件
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void labe_goods_Click(object sender, EventArgs e)
        {
            Data_show_timer.Start();                //显示并绑定数据到data_storage
            data_storage.DataSource = ib.GetAllById(Int32.Parse(com_warehouse_id.SelectedValue.ToString())).Tables[0]; 
            data_storage.ClearSelection();          //清除默认选中
        }
        /// <summary>
        /// 窗体的大小改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewOutInventory_Resize(object sender, EventArgs e)
        {
            data_storage.Width = this.Width;        //更改data_storage的大小
            data_storage.Top = labe_goods.Top + 20;
            if(data_storage.Height >10)
            {
                data_storage.Height = Convert.ToInt32(this.Height * 0.6);
            }
            data_storage.ClearSelection();
        }
        /// <summary>
        /// 物品选择显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Data_show_timer_Tick(object sender, EventArgs e)
        {
            if (data_storage.Height < Convert.ToInt32(this.Height * 0.6))
            {
                data_storage.Height += 50;
            }
            else 
            {
                data_storage.Height = Convert.ToInt32(this.Height * 0.6);
                Data_show_timer.Stop();
            }
        }
        /// <summary>
        /// 物品选择隐藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Date_hide_timer_Tick(object sender, EventArgs e)
        {
            if (data_storage.Height > 0)
            {
                data_storage.Height -= 50;
            }
            else
            {
                data_storage.Height = 0;
                Data_hide_timer.Stop();
            }
        }
        /// <summary>
        /// 背景的单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewOutInventory_Click(object sender, EventArgs e)
        {
            Data_hide_timer.Start();                           //隐藏选择物品
        }
        /// <summary>
        /// datagridview的行双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void data_storage_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            goods_id = data_storage.Rows[e.RowIndex].Cells["编号"].Value.ToString();         //用户选择的物品ID
            labe_goods.Text = data_storage.Rows[e.RowIndex].Cells["物品名"].Value.ToString();//物品选择的物品名
            Data_hide_timer.Start();                                                        //开始隐藏
        }
        /// <summary>
        /// 出库按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_storage_Click(object sender, EventArgs e)
        {
            bool isnull = true;
            foreach(Control c in this.Controls)
            {
                if(c is TextBox&&c.Text=="")
                {
                    isnull = false;  
                }
                if (c is ComboBox && c.Text == "") 
                {
                    isnull = false;
                }
            }
            if (labe_goods.Text == "双击选择物品"||labe_goods.Text=="")
            {
                isnull = false;
            }
            if(!isnull)
            {
                MessageBox.Show("请填写完整！","警告！");
                return;
            }
            //插入出库记录
            bm.Warehouse_id =Int32.Parse(com_warehouse_id.SelectedValue.ToString());
            bm.Goods_id =Int32.Parse(goods_id);
            bm.Operation_type_id = Int32.Parse(com_type_id.SelectedValue.ToString());
            bm.Goods_amount = Int32.Parse(text_goods_amount.Text);
            bm.Goods_price = Int32.Parse(text_goods_price.Text);
            bm.Client_id = Int32.Parse(com_client_id.SelectedValue.ToString());
            bm.Bill_note = text_bill_note.Text;
            bm.Lot_number = text_lot_number.Text;
            bm.Operation_time = DateTime.Now.ToString();
            bm.Manufacture_date = "";
            bm.Expiration_date = "";
            bm.Manager_id = LoginInfo.manager_info.Id;
            bb.Insert(bm);
            double goods_total = ib.GetPrice(Int32.Parse(goods_id))*bm.Goods_amount;
            //修改库存信息
            ib.Update(Int32.Parse(goods_id), bm.Goods_amount, goods_total);
            OutInventory oi = new OutInventory();
            oi.TopLevel = false;
            oi.MdiParent = this.MdiParent;
            oi.Parent = this.Parent;
            oi.Dock = DockStyle.Fill;
            oi.Show();
            this.Close();
        }

    }
}
