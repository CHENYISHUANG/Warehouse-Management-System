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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        /// <summary>
        /// 关闭按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Closebtn_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        /// <summary>
        /// 最小化按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Minibtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// 登录按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Loginbtn_Click(object sender, EventArgs e)
        {
            ManagerBLL mb = new ManagerBLL();
            List<ManagerMOD> list = mb.FindName(Nametext.Text);                       //根据用户名查询密码
            if(list.Count==0||list[0].Manager_password!=Passwordtext.Text)          //如果返回的密码和输入的密码不一致
            {
                MessageBox.Show("您的用户名或密码有误，请重新输入:");
                Passwordtext.Text = "";
                return;
            }
            LoginInfo.manager_info = list[0];
            this.Close();
        }

        private Point mpoint = new Point();     //鼠标坐标

        /// <summary>
        /// 窗体Panel鼠标按下事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mpoint.X = e.X;
            mpoint.Y = e.Y;
            MoveTime.Start();                                       //启动计时器
        }

        /// <summary>
        /// 窗体Panel鼠标弹起事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            MoveTime.Stop();                                       //停止计时器
        }

        /// <summary>
        /// 移动窗口的计时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoveTime_Tick(object sender, EventArgs e)
        {
            this.Left = MousePosition.X - mpoint.X-1;              //窗体的Left等于鼠标在屏幕的X减去鼠标在窗体中的X-边框1px
            this.Top = MousePosition.Y - mpoint.Y-1;
        }
        /// <summary>
        /// 窗体的关闭
        /// </summary>
        /// <param name="i"></param>
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
