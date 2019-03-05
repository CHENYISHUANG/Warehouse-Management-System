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
    public partial class ManagerInfo : Form
    {
        ManagerBLL mb = new ManagerBLL();       //管理员逻辑层
        ManagerMOD mm = new ManagerMOD();       //管理员实体类
        List<ManagerMOD> list = new List<ManagerMOD>(); //管理员集合
        public ManagerInfo()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManagerInfo_Load(object sender, EventArgs e)
        {
            com_manager_id.DisplayMember = "Manager_name";
            com_manager_id.ValueMember = "Id";
            com_manager_id.DataSource = mb.FindAll();
            com_manager_id.SelectedItem = null;
        }
         /// <summary>
         /// 下拉列表选择事件
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void com_manager_id_SelectionChangeCommitted(object sender, EventArgs e)
        {
            mb = new ManagerBLL();
            list = mb.FindId((int)com_manager_id.SelectedValue);
            if (list.Count > 0)
            {
                mm = list[0];
                text_manager_name.Text = mm.Manager_name;
                text_manager_passowrd.Text = mm.Manager_password;
                text_manager_username.Text = mm.Manager_username;
            }
            
        }
        /// <summary>
        /// 更改按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_reset_Click(object sender, EventArgs e)
        {
            if (text_manager_name.Text != "" && text_manager_passowrd.Text != "" && text_manager_username.Text != "" && lab_prompt.Text != "该用户名已被使用")
            {
                mm.Manager_name = text_manager_name.Text;
                mm.Manager_password = text_manager_passowrd.Text;
                mm.Manager_username = text_manager_username.Text;
                mm.Id = (int)com_manager_id.SelectedValue;
                int count = mb.Update(mm);
                if (count != 0)
                {
                    MessageBox.Show("修改成功!");
                    ReSet();
                }
                else
                {
                    MessageBox.Show("修改失败!");
                }
            }
            else {
                MessageBox.Show("不能有空值!","提示");
            }
            
        }
        /// <summary>
        /// 重置
        /// </summary>
        private void ReSet()
        {
            com_manager_id.SelectedItem = null;
            text_manager_name.Text = "";
            text_manager_passowrd.Text = "";
            text_manager_username.Text = "";
        }
        /// <summary>
        /// 删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("您确定要删除此管理员?","提示",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                mb.Delete((int)com_manager_id.SelectedValue);
                ReSet();
                if ((int)com_manager_id.SelectedValue==LoginInfo.manager_info.Id)     //如果删除的管理员ID和登陆的管理员ID一致，则退出登陆
                {
                    Application.Restart();
                }
            }
        }
        /// <summary>
        /// 用户名输入框的焦点失去事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void text_manager_username_Leave(object sender, EventArgs e)
        {
            if (text_manager_username.Text != "")
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
