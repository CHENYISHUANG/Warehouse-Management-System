using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WarehouseMOD;
using WarehouseBLL;

namespace 仓库管理系统
{
    public partial class PutInventoryprint : Form
    {
        int id;
        BillMOD bm = new BillMOD();
        BillBLL bb = new BillBLL();
        GoodsMOD gm = new GoodsMOD();
        GoodsBLL gb = new GoodsBLL();
        WarehouseNumberBLL wnb = new WarehouseNumberBLL();
        WarehouseNumberMOD wnm = new WarehouseNumberMOD();
        ClientBLL cb = new ClientBLL();
        ClientMOD cm = new ClientMOD();
        GoodsTypeMOD gtm = new GoodsTypeMOD();
        GoodsTypeBLL gtb = new GoodsTypeBLL();
        ManagerMOD mm = new ManagerMOD();
        ManagerBLL mb = new ManagerBLL();
        OperationTypeBLL otb = new OperationTypeBLL();
        OperationTypeMOD otm = new OperationTypeMOD();
        public PutInventoryprint()
        {
            InitializeComponent();
        }
        public PutInventoryprint(int id)
        {
            this.id = id;
            InitializeComponent();
        }
        private void PutInventoryprint_Load(object sender, EventArgs e)
        {
            bm = bb.FindById(id)[0];             //清单
            gm = gb.ById(bm.Goods_id)[0];        //物品
            wnm = wnb.FindById(bm.Client_id)[0]; //仓库
            cm = cb.FindId(bm.Client_id)[0];     //客户
            gtm = gtb.FindID(gm.Goods_type_id);  //物品类型
            mm=mb.FindId(bm.Manager_id)[0];      //管理员
            otm = otb.FindById(bm.Operation_type_id)[0];
            goods_name_text.Text = gm.Goods_name;
            goods_amount_text.Text = bm.Goods_amount.ToString();
            goods_code_text.Text = gm.Goods_code;
            goods_note_text.Text = gm.Goods_note;
            goods_price_text.Text = bm.Goods_price.ToString();
            goods_type_text.Text = gtm.Goods_type;
            goods_volume_text.Text = gm.Goods_volume;
            goods_wight_text.Text = gm.Goods_wight;
            warehouse_text.Text = wnm.Warehouse_name;
            client_text.Text = cm.Client_name;
            specifications_text.Text = gm.Specifications;
            type_id_text.Text = otm.Operation_type;
            expiration_date_text.Text = bm.Expiration_date;
            manufacture_date_text.Text = bm.Manufacture_date;
            lot_number_text.Text = bm.Lot_number;
            bill_note_text.Text = bm.Bill_note;
            operation_name_text.Text = mm.Manager_name;
        }

        private void btn_storage_Click(object sender, EventArgs e)
        {
            try
            {
                FastReport.Report report1 = new FastReport.Report();
                report1.Load("2.frx");
                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                dt.Columns.Add("物品名");
                dt.Columns.Add("物品数量");
                dt.Columns.Add("物品代码");
                dt.Columns.Add("物品备注");
                dt.Columns.Add("物品价格");
                dt.Columns.Add("物品类型");
                dt.Columns.Add("物品体积");
                dt.Columns.Add("物品重量");
                dt.Columns.Add("仓库名称");
                dt.Columns.Add("客户名称");
                dt.Columns.Add("物品规格");
                dt.Columns.Add("入库方式");
                dt.Columns.Add("生产日期");
                dt.Columns.Add("到期日期");
                dt.Columns.Add("批号");
                dt.Columns.Add("清单备注");
                dt.Columns.Add("操作人员");
                dt.Rows.Add();
                dt.Rows[0][0] = gm.Goods_name;
                dt.Rows[0][1] = bm.Goods_amount;
                dt.Rows[0][2] = gm.Goods_code;
                dt.Rows[0][3] = gm.Goods_note;
                dt.Rows[0][4] = bm.Goods_price;
                dt.Rows[0][5] = gtm.Goods_type;
                dt.Rows[0][6] = gm.Goods_volume;
                dt.Rows[0][7] = gm.Goods_wight;
                dt.Rows[0][8] = wnm.Warehouse_name;
                dt.Rows[0][9] = cm.Client_name;
                dt.Rows[0][10] = gm.Specifications;
                dt.Rows[0][11] = otm.Operation_type;
                dt.Rows[0][12] = bm.Expiration_date;
                dt.Rows[0][13] = bm.Manufacture_date;
                dt.Rows[0][14] = bm.Lot_number;
                dt.Rows[0][15] = bm.Bill_note;
                dt.Rows[0][16] = mm.Manager_name;
                ds.Tables.Add(dt);
                dt.TableName = "putreport";
                report1.RegisterData(ds);
                report1.GetDataSource("putreport").Enabled = true;
                report1.Show();
                //report1.Design();
                //report1.Prepare();
                //report1.ShowPrepared();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
