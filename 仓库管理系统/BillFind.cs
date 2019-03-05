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
    public partial class BillFind : Form
    {
        BillBLL bb = new BillBLL();                               //清单表逻辑层
        BillMOD bm = new BillMOD();                               //清单表实体类
        List<BillMOD> listb = new List<BillMOD>();                //清单表集合
        OperationTypeBLL ob = new OperationTypeBLL();             //操作类型逻辑层
        public BillFind()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BillManage_Load(object sender, EventArgs e)
        {
            data_storage.DataSource = bb.GetDataset("").Tables[0];
            com_find_type.Items.Add("根据物品名查询");
            com_find_type.Items.Add("根据客户名查询");
            com_find_type.Items.Add("根据仓库名查询");
            date_start_time.CustomFormat = " ";
            date_stop_time.CustomFormat = " ";
            com_type_id.DisplayMember = "Operation_type";
            com_type_id.ValueMember = "Id";
            com_type_id.DataSource = ob.FindAll();
            com_type_id.SelectedItem = null;
        }
        /// <summary>
        /// 窗体大小改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BillManage_Resize(object sender, EventArgs e)
        {
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
            com_find_type.Text = "";
            com_find_type.SelectedItem = null;
            com_type_id.SelectedItem = null;
            text_find_name.ForeColor = Color.Black;
            text_find_name.Text = "";
            date_start_time.CustomFormat = " ";
            date_stop_time.CustomFormat = " ";
            date_stop_time.MinDate = DateTime.Parse("1753/1/1");

        }
        /// <summary>
        /// 查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_query_Click(object sender, EventArgs e)
        {
            data_storage.AutoGenerateColumns = false;          //清空datagridview
            data_storage.DataSource = null;
            data_storage.Rows.Clear();
            string find_type = "";                                //存储查询方式的值
            string find_text = "";                              //存储查询关键字
            string find_sql = "";                              //根据时间查询的sql条件（根据用户的选择而更改）
            if (com_find_type.Text != "")                           //如果选择查询方式
            {
                if (text_find_name.Text == "")
                {
                    MessageBox.Show("请输入查询关键字");           //判断是否输入查询关键字
                    return;
                }
            }
            find_type = com_find_type.Text;
            find_text = text_find_name.Text;
            if (date_start_time.Text != " " && date_stop_time.Text == " ")     //如果截止时间为空
            {
                find_sql = " and convert(DATETIME,b.operation_time,120)>convert(DATETIME,'" + date_start_time.Text + " 00:00:00',120)";
            }
            if (date_start_time.Text == " " && date_stop_time.Text != " ")     //如果起始时间为空
            {
                find_sql = " and convert(DATETIME,b.operation_time,120)<convert(DATETIME,'" + date_stop_time.Text + " 23:59:59',120)";
            }
            if (date_start_time.Text != " " && date_stop_time.Text != " ")     //如果起始时间和截止时间都不为空
            {
                find_sql = " and convert(DATETIME,b.operation_time,120) BETWEEN convert(DATETIME,'" + date_start_time.Text + " 00:00:00',120) AND convert(DATETIME,'" + date_stop_time.Text + " 23:59:59',120)";
            }
            if (com_find_type.Text == "" && date_start_time.Text == " " && date_stop_time.Text == " ")     //如果都为空 则查询全部
            {
                if(com_type_id.Text!="")  //如果操作类型不是空
                {
                    data_storage.DataSource = bb.GetDataset(" where o.id=" + com_type_id.SelectedValue.ToString()).Tables[0];
                    data_storage.ClearSelection();
                    return;
                }
                data_storage.DataSource = bb.GetDataset("").Tables[0];
            }
            else
            {
                if (com_type_id.Text != "")  //如果操作类型不是空
                {
                    data_storage.DataSource = bb.ByCondition(find_type, find_text, find_sql, " where o.id=" + com_type_id.SelectedValue.ToString()).Tables[0];
                    data_storage.ClearSelection();
                    return;
                }
                data_storage.DataSource = bb.ByCondition(find_type, find_text, find_sql," where 1=1").Tables[0];
            }
            data_storage.ClearSelection();
        }
        /// <summary>
        /// 关键字输入框焦点获得事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void text_find_name_Enter(object sender, EventArgs e)
        {
            if (text_find_name.Text == "请输入查询关键字")             //输入框提示文字
            {
                text_find_name.Text = "";
                text_find_name.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// 设置日期格式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void date_start_time_CloseUp(object sender, EventArgs e)
        {
            date_start_time.CustomFormat = "yyyy-MM-dd";
        }
        private void date_stop_time_CloseUp(object sender, EventArgs e)
        {
            date_stop_time.CustomFormat = "yyyy-MM-dd";
        }
        /// <summary>
        /// 第二个DateTimePicker的最小时间不能小于第一个DateTimePicker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void date_stop_time_Enter(object sender, EventArgs e)
        {

            if (date_start_time.Text != " ")
            {
                date_stop_time.MinDate = DateTime.Parse(date_start_time.Text);     //设定第二个DateTimePicker的最小日期
            }
        }
    }
}
