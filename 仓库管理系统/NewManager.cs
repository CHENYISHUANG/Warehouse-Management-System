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
    public partial class NewManager : Form
    {
        ManagerBLL mb = new ManagerBLL();       //管理员逻辑层
        ManagerMOD mm = new ManagerMOD();       //管理员实体类
        List<ManagerMOD> list = new List<ManagerMOD>(); //管理员集合 
        public NewManager()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_new_ok_Click(object sender, EventArgs e)
        {
            if (text_manager_name.Text != "" && text_manager_passowrd.Text != "" && text_manager_passowrd2.Text != "" && text_manager_username.Text != "" && lab_prompt.Text != "")
            {
                if(text_manager_passowrd.Text!=text_manager_passowrd2.Text)
                {
                    MessageBox.Show("第一次和第二次输入的密码不一致");
                    return;
                }
                if (lab_prompt.Text != "该用户名已被使用")
                {
                    mm.Manager_name = text_manager_name.Text;
                    mm.Manager_password = text_manager_passowrd.Text;
                    mm.Manager_username = text_manager_username.Text;
                    mb.Insert(mm);
                    MessageBox.Show("添加成功!");
                    ManagerInfo mi = new ManagerInfo();
                    mi.TopLevel = false;
                    mi.MdiParent = this.MdiParent;
                    mi.Parent = this.Parent;
                    mi.Show();
                    this.Close();
                }
                else 
                {
                    MessageBox.Show("该用户名已被使用");
                }
               
            }
            else 
            {
                MessageBox.Show("不能有空值！","提示");
            }
        }
        /// <summary>
        /// 用户名输入框的焦点失去事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void text_manager_username_Leave(object sender, EventArgs e)
        {
            if(text_manager_username.Text!="")
            {
                if (mb.FindUserName(text_manager_username.Text).Count == 0)
                {
                    lab_prompt.Text = "该用户名可以使用";
                    lab_prompt.ForeColor = Color.Green;
                }
                else
                {
                    lab_prompt.Text = "该用户名已被使用";
                    lab_prompt.ForeColor = Color.Red;
                }
            }
            
        }
    }
}
