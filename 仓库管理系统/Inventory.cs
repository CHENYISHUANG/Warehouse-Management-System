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
    public partial class Inventory : Form
    {

        string find_type;                                             //查询方式  
        GoodsBLL gb = new GoodsBLL();                                 //物品逻辑层     
        InventoryBLL ib = new InventoryBLL();                         //库存逻辑层   
        WarehouseNumberBLL wnb = new WarehouseNumberBLL();            //仓库逻辑层
        ClientBLL cb = new ClientBLL();                               //客户逻辑层
        DataSet ds = new DataSet();
        public Inventory()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体大小改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Inventory_Resize(object sender, EventArgs e)
        {                                                                     //更改datagridview大小
            data_storage.Width = this.Width;
            data_storage.Height = Convert.ToInt32(this.Height * 0.7);
            panel_top.Height = Convert.ToInt32(this.Height * 0.3);
            data_storage.Top = Convert.ToInt32(this.Height * 0.3);
            data_storage.ClearSelection();
        }
        /// <summary>
        /// 重置按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_reset_Click(object sender, EventArgs e)
        {
            com_find_type.SelectedItem = null;
            com_find_type2.SelectedItem = null;
            com_find_type2.DataSource = null;
        }
        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Inventory_Load(object sender, EventArgs e)
        {
            com_find_type.Items.Add("根据仓库号查找");             //添加选项到下拉列表
            com_find_type.Items.Add("根据客户名查找");
            com_find_type.Items.Add("根据物品名查找");
            ds = ib.FindAll();
            data_storage.DataSource = ds.Tables[0];
        }
        /// <summary>
        /// 下拉列表选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void com_find_type_SelectionChangeCommitted(object sender, EventArgs e)
        {
            com_find_type2.DataSource = null;
             switch(com_find_type.Text)                //根据用户的选择变更第二个下拉框的内容
             {
                 case "根据仓库号查找":
                     lab_find_type2.Text = "请选择仓库";
                     com_find_type2.DisplayMember = "Warehouse_name";
                     com_find_type2.ValueMember = "Id";
                     find_type = " w.id=";
                     com_find_type2.DataSource = wnb.FindAll();
                     break;
                 case "根据客户名查找":
                     lab_find_type2.Text = "请选择客户";
                     com_find_type2.DisplayMember = "Client_name";
                     com_find_type2.ValueMember = "Id";
                     find_type = " c.id=";
                     com_find_type2.DataSource = cb.FindAll();
                     break;
                 case "根据物品名查找":
                     lab_find_type2.Text = "请选择物品";
                     com_find_type2.DisplayMember = "Goods_name";
                     com_find_type2.ValueMember = "Id";
                     find_type = " g.id=";
                     com_find_type2.DataSource = gb.FindAll();
                     break;
             }
        }
         /// <summary>
         /// 查询按钮
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void btn_query_Click(object sender, EventArgs e)
        {
            data_storage.AutoGenerateColumns = false;
            data_storage.DataSource = null;
            data_storage.Rows.Clear();                         //清空datagridview
            string find_name="";
              if(com_find_type.Text==""&&com_find_type2.Text=="")
              {
                  data_storage.DataSource  = ds.Tables[0];           //重新绑定数据源
              }
              if(com_find_type.Text!="")
              {
                  find_name= com_find_type2.SelectedValue.ToString();
                  data_storage.DataSource = ib.ByCondition(find_type,find_name).Tables[0];
              }
              data_storage.ClearSelection();
        }
    }
}
