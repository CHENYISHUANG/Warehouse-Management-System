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
    public partial class ClientInfo : Form
    {
        ClientBLL cb = new ClientBLL();                               //客户逻辑层
        ClientMOD cm = new ClientMOD();                               //客户实体类
        List<ClientMOD> listc = new List<ClientMOD>();                //客户实体集合
        bool isnull = true;                                           //标识是否有空值
        public ClientInfo()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClientInfo_Load(object sender, EventArgs e)
        {
            com_client_id.DisplayMember = "Client_name";
            com_client_id.ValueMember = "Id";
            com_client_id.DataSource = cb.FindAll();
            com_client_id.SelectedItem = null;
        }
        /// <summary>
        /// 客户管理按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_manager_Click(object sender, EventArgs e)
        {
            Title.Text = "客户信息";
            cb = new ClientBLL();
            com_client_id.DisplayMember = "Client_name";       //绑定下拉列表
            com_client_id.ValueMember = "Id";
            com_client_id.DataSource = cb.FindAll();
            com_client_id.SelectedItem = null;
            panel_manage.Visible = true;                       //显示客户管理
            panel_new.Visible = false;                         
            ReSet();
        }
        /// <summary>
        /// 添加客户按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_add_Click(object sender, EventArgs e)
        {
            Title.Text = "添加客户";
            panel_manage.Visible = false;             //显示添加客户
            panel_new.Visible = true;
        }

        /// <summary>
        /// 下拉列表选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void com_client_id_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cb = new ClientBLL();
            cm = cb.FindId((int)com_client_id.SelectedValue)[0];
            text_client_name.Text = cm.Client_name;
            text_client_position.Text = cm.Client_address;
            text_client_contacts.Text = cm.Client_contacts;
            text_client_phone.Text = cm.Client_phone;
            text_client_note.Text = cm.Client_note;
        }
        /// <summary>
        /// 更改按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_reset_Click(object sender, EventArgs e)
        {
             foreach(Control c in panel_manage.Controls)        //循环判断输入框是否为空
             {
                 if(c is TextBox&&c.Text=="")
                 {
                     isnull = false; 
                     MessageBox.Show("请填写完整！", "提示");
                     return;
                 }
             }
             isnull = true;
            if(!isnull||com_client_id.Text=="")
            {
                MessageBox.Show("请填写完整！","提示");
                return;
            }
            cm.Client_name = text_client_name.Text;                     //将输入框的值赋给实体类
            cm.Client_address = text_client_position.Text;
            cm.Client_contacts = text_client_contacts.Text;
            cm.Client_phone = text_client_phone.Text;
            cm.Client_note = text_client_note.Text;
            cb.Update(cm);                                              //调用更改方法
            MessageBox.Show("修改成功!","提示");
            ReSet();
        }
        /// <summary>
        /// 重置
        /// </summary>
        private void ReSet() 
        {
            text_client_name.Text = "";
            text_client_position.Text = "";
            text_client_contacts.Text = "";
            text_client_phone.Text = "";
            text_client_note.Text = "";
            com_client_id.SelectedItem = null;
            
        }
        /// <summary>
        /// 添加按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ok_Click(object sender, EventArgs e)
        {
            foreach (Control c in panel_new.Controls)        //循环判断输入框是否为空
            {
                if (c is TextBox && c.Text == "")
                {
                    isnull = false; 
                    MessageBox.Show("请填写完整！", "提示");
                    return;
                }
            } 
            isnull = true;
            if (!isnull)
            {
                MessageBox.Show("请填写完整！", "提示");
                return;
            }
            cm.Client_name = text_new_client_name.Text;                     //将输入框的值赋给实体类
            cm.Client_address = text_new_client_position.Text;
            cm.Client_contacts = text_new_client_contacts.Text;
            cm.Client_phone = text_new_client_phone.Text;
            cm.Client_note = text_new_client_note.Text;
            cb.Insert(cm);
            MessageBox.Show("添加成功!", "提示");
            btn_manager_Click(sender, e);
        }

       
    }
}
