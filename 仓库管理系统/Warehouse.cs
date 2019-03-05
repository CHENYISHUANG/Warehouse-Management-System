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
using System.Text.RegularExpressions;

namespace 仓库管理系统
{
    public partial class Warehouse : Form
    {
        int warehouseid=-1;
        int page = 0;                                                  //判断在哪个页面，添加还是管理
        WarehouseNumberBLL wnb = new WarehouseNumberBLL();             //仓库逻辑层
        WarehouseNumberMOD wm = new WarehouseNumberMOD();              //仓库实体类
        List<WarehouseNumberMOD> list = new List<WarehouseNumberMOD>();//实体类集合
        public Warehouse()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Warehouse_Load(object sender, EventArgs e)
        {
            Setcombobox();
        }
        /// <summary>
        /// 添加仓库按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_add_Click(object sender, EventArgs e)
        {
            page = 1;
            Title.Text = "添加仓库";
            panel_manage.Visible = false;                        //隐藏仓库管理页面
            panel_new.Visible = true;                            //显示添加仓库页面
        }
        /// <summary>
        /// 仓库管理按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_manager_Click(object sender, EventArgs e)
        {
            page = 0;
            Title.Text = "仓库管理";
            panel_manage.Visible = true;                        //显示仓库管理页面
            panel_new.Visible = false;                          //隐藏添加仓库页面
            Setcombobox();
        }
        /// <summary>
        /// 下拉列表的选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void com_warehouse_id_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int id = Int32.Parse(com_warehouse_id.SelectedValue.ToString());          //获取选中的ID
            foreach (WarehouseNumberMOD item in list)                                 //遍历list集合
            {
                if (item.Id == id)                                                   // 如果ID和list里ID想同
                {
                    text_warehouse_name.Text = item.Warehouse_name;                   //给文本框赋值
                    text_warehouse_position.Text = item.Warehouse_position;
                    text_warehouse_note.Text = item.Warehouse_note;
                    warehouseid = item.Id;
                    return;
                }
            }
        }
         /// <summary>
         /// 更改按钮
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void btn_reset_Click(object sender, EventArgs e)
        {

            if (text_warehouse_name.Text != "" && text_warehouse_note.Text != "" && text_warehouse_position.Text != "")
            {
                wm.Id = warehouseid;                                   //把值赋给实体类
                wm.Warehouse_name = text_warehouse_name.Text;
                wm.Warehouse_position = text_warehouse_position.Text;
                wm.Warehouse_note = text_warehouse_note.Text;
                if (wnb.Update(wm) == 1) 
                {
                    MessageBox.Show("更改成功！");
                    Setcombobox();
                }
            }
            else 
            {
                MessageBox.Show("不能有空值!", "警告!");
            }
        }
        /// <summary>
        /// 初始化下拉列表和输入框状态
        /// </summary>
        private void Setcombobox() 
        {
            com_warehouse_id.DataSource = null;
            com_warehouse_id.DisplayMember = "Warehouse_name";             //绑定仓库到下拉列表
            com_warehouse_id.ValueMember = "Id";
            list = wnb.FindAll();
            com_warehouse_id.DataSource = list;                             //初始化所有输入框
            com_warehouse_id.SelectedItem = null;                       
            text_warehouse_name.Text = "";
            text_warehouse_note.Text = "";
            text_warehouse_position.Text = "";
            warehouseid = -1;
            text__new_warehouse_name.Text = "";
            text_new_warehouse_note.Text = "";
            text_new_warehouse_position.Text = "";
        }
        private void SetNewPanel() 
        {
            text__new_warehouse_name.Text = "";
            text_new_warehouse_note.Text = "";
            text_new_warehouse_position.Text = "";
            lab_prompt.Text = "";
        }
        /// <summary>
        /// 删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (warehouseid == -1)
            {
                MessageBox.Show("请选择仓库!", "警告!");
            }
            else
            {
                DeleteWarehouse dw = new DeleteWarehouse(warehouseid);
                DialogResult isok= dw.ShowDialog();
                if (isok == DialogResult.No)               //如果没有成功执行
                {
                    MessageBox.Show("删除失败！", "提示!");
                }
                else if (isok == DialogResult.OK)          //如果成功执行
                {
                    MessageBox.Show("删除成功！", "提示!");
                    Setcombobox();
                }
            }
        }
        /// <summary>
        /// 仓库名输入框的焦点失去事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void text__new_warehouse_name_Leave(object sender, EventArgs e)
        {
            if(page==1)                                                     
            {
                list = wnb.FindName(text__new_warehouse_name.Text);         //根据用户输入的仓库名查询
                if (list.Count > 0)
                {
                    lab_prompt.Text = "该仓库名已存在！";
                    lab_prompt.ForeColor = Color.Red;
                }
                else
                {
                    lab_prompt.Text = "该仓库名可以使用！";
                    lab_prompt.ForeColor = Color.Green;
                }
            }
            
        }

        /// <summary>
        /// 验证输入字符
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void text__new_warehouse_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex rg = new Regex("^[\u4e00-\u9fa5]$");      //正则表达式
            //如果输入的是字母A-Z,a-z，_，0-9则接收，否则不接收
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar >= 65 && e.KeyChar <= 90 || e.KeyChar >= 97 && e.KeyChar <= 122 || e.KeyChar == 95||e.KeyChar ==8)
            {
                e.Handled = false;
            }
            else 
            {
                e.Handled = true;
            }
            if (rg.IsMatch(e.KeyChar.ToString()))         //如果输入的是汉字，则接收
            {
                e.Handled = false;
            }
        }
        /// <summary>
        /// 添加仓库的确定按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_new_ok_Click(object sender, EventArgs e)
        {
            if(text__new_warehouse_name.Text==""||text_new_warehouse_note.Text==""||text_new_warehouse_position.Text=="")
            {
                MessageBox.Show("请填写完整!","提示");
                return;
            }
            if (lab_prompt.Text == "该仓库名已存在！")
            {
                MessageBox.Show("请更换仓库名!", "提示");
                return;
            }
            wm.Warehouse_name = text__new_warehouse_name.Text;
            wm.Warehouse_note = text_new_warehouse_note.Text;
            wm.Warehouse_position = text_new_warehouse_position.Text;
            wnb.Insert(wm);
            MessageBox.Show("添加成功");
            btn_manager_Click(sender, e);
        }
        
    }
}
