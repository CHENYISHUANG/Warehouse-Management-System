using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseBLL;
using WarehouseMOD;

namespace 仓库管理系统
{
    public partial class Index : Form
    {
        private FlowLayoutPanel flp;                               //被单击的菜单
        private FlowLayoutPanel hideflp;                           //被单击的菜单
        private bool menu_is_show=true;                            //显示隐藏的标识
        public Index()
        {
            InitializeComponent();
            Login l = new Login();
            this.IsMdiContainer = true;            
            l.ShowDialog();
            Log_namelabel.Text = "欢迎登陆: "+LoginInfo.manager_info.Manager_name;                
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();    //欢迎登陆旁边的图片形状设置为圆形
            path.AddEllipse(this.name_img.ClientRectangle);
            name_img.Region = new Region(path);
            
        }
        private void Index_Load(object sender, EventArgs e)
        {

        }
        private Point mpoint = new Point();                                //鼠标坐标

        /// <summary>
        /// 窗体Panel鼠标按下事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void index_top_MouseDown(object sender, MouseEventArgs e)
        {
            mpoint.X = e.X;                                                //获取鼠标在窗体中的位置
            mpoint.Y = e.Y;
            Index_movetimer.Start();                                       //启动计时器
        }

        /// <summary>
        /// 窗体Panel鼠标弹起事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void index_top_MouseUp(object sender, MouseEventArgs e)
        {
            Index_movetimer.Stop();                                       //停止计时器
        }

        /// <summary>
        /// 移动窗口的计时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Index_movetimer_Tick(object sender, EventArgs e)
        {
            this.Left = MousePosition.X - mpoint.X;                      //控制窗体的坐标
            this.Top = MousePosition.Y - mpoint.Y;
        }

        /// <summary>
        /// 关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       
        
        /// <summary>
        /// 用户名的鼠标移上事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Log_cancel_MouseEnter(object sender, EventArgs e)
        {
            Log_cancel.Font = new Font("微软雅黑", 9, FontStyle.Underline);          //鼠标移上来后改变字体颜色
            this.Cursor = Cursors.Hand;                                             //鼠标形状改为手形
            Log_cancel.ForeColor = Color.Red;
        }

        /// <summary>
        /// 用户名的鼠标移出事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Log_cancel_MouseLeave(object sender, EventArgs e)
        {
            Log_cancel.Font = new Font("微软雅黑", 9, FontStyle.Regular);
            this.Cursor = Cursors.Arrow;                                            //鼠标形状改回箭头
            Log_cancel.ForeColor = Color.Black;                                     //颜色改回黑色
        }

        /// <summary>
        /// 关闭按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();                                                   
        }

        /// <summary>
        /// 最大化窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_max_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;                               //窗体常规化
                Btn_max.Text = "□";
            }
            else 
            {
                WindowState = FormWindowState.Maximized;                            //窗体最大化
                Btn_max.Text = "▬";
            }
        }

        /// <summary>
        /// 最小化窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_mini_Click(object sender, EventArgs e)                     //最小化窗体
        {
            WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// 注销按钮单击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Log_cancel_Click(object sender, EventArgs e)                   //注销用户，跳转到登陆窗体
        {
            Application.Restart();  
        }
         /// <summary>
         /// 窗体大小改变事件
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
                                     ///
        private void Index_Resize(object sender, EventArgs e)                    
        {
            index_top.Height = this.Height / 9;                               //修改菜单的各控件大小
            Left_menu.Top = index_top.Height;
            Left_menu.Height = index_top.Height * 9;
            left_btn_put.Height = Left_menu.Height / 12;
            left_btn_out.Height = Left_menu.Height / 12;
            left_btn_stock.Height = Left_menu.Height / 12;
            left_btn_manager.Height = Left_menu.Height / 12;
            left_btn_backstage.Height = Left_menu.Height / 12;
            left_btn_put_1.Height = Left_menu.Height / 20;
            left_btn_put_2.Height = Left_menu.Height / 20;
            left_btn_out_1.Height = Left_menu.Height / 20;
            left_btn_out_2.Height = Left_menu.Height / 20;
            left_btn_stock_1.Height = Left_menu.Height / 20;
            left_btn_stock_2.Height = Left_menu.Height / 20;
            left_btn_stock_3.Height = Left_menu.Height / 20;
            left_btn_stock_4.Height = Left_menu.Height / 20;
            left_btn_manager_1.Height = Left_menu.Height / 20;
            left_btn_manager_2.Height = Left_menu.Height / 20;
            left_btn_backstage_1.Height = Left_menu.Height / 20;
            left_btn_backstage_2.Height = Left_menu.Height / 20;
            body.Width = this.Width - Left_menu.Width;
            body.Height = this.Height - index_top.Height;
            body.Left = Left_menu.Width;
            body.Top = index_top.Height;    
            if(flp!=null)
            {
                flp.Height = left_btn_put_1.Height * flp.Controls.Count;        //如果菜单被打开，则重新计算内部按钮的大小
            }
        }

        /// <summary>
        /// 左边菜单的入库按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void left_menu_btn1_Click(object sender, EventArgs e)
        {
            InitializationMenu();
            flp = Left_menu_put;                                     //把要操作的panel赋值给flp
            if (menu_is_show)
            {
                Left_menu_showtimer.Start();                         //启动显示菜单的计时器
            }
            else
            {
                Left_menu_hidetimer.Start();                         //启动隐藏菜单的计时器    
            }
                                                                                    
           
        }
        /// <summary>
        /// 左边菜单出库按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void left_btn_out_Click(object sender, EventArgs e)
        {
            InitializationMenu();
            flp = left_menu_out;                                     //把要操作的panel赋值给flp
            if (menu_is_show)
            {
                Left_menu_showtimer.Start();                         //启动显示菜单的计时器
            }
            else
            {
                Left_menu_hidetimer.Start();                         //启动隐藏菜单的计时器    
            }
        }
        /// <summary>
        /// 左边库存菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void left_btn_stock_Click(object sender, EventArgs e)
        {
            InitializationMenu();
            flp = left_menu_stock;                                   //把要操作的panel赋值给flp
            if (menu_is_show)
            {
                Left_menu_showtimer.Start();                         //启动显示菜单的计时器
            }
            else
            {
                Left_menu_hidetimer.Start();                         //启动隐藏菜单的计时器    
            }
        }
         /// <summary>
         /// 左边管理员菜单
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void left_btn_manager_Click(object sender, EventArgs e)
        {
            InitializationMenu();
            flp = left_menu_manager;                                 //把要操作的panel赋值给flp
            if (menu_is_show)
            {
                Left_menu_showtimer.Start();                         //启动显示菜单的计时器
            }
            else
            {
                Left_menu_hidetimer.Start();                         //启动隐藏菜单的计时器    
            }
        }
        /// <summary>
        /// 左边后台菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void left_btn_backstage_Click(object sender, EventArgs e)
        {
            InitializationMenu();
            flp = left_menu_backstage;                               //把要操作的panel赋值给flp
            if (menu_is_show)
            {
                Left_menu_showtimer.Start();                         //启动显示菜单的计时器
            }
            else
            {
                Left_menu_hidetimer.Start();                         //启动隐藏菜单的计时器    
            }
        }
        /// <summary>
        /// 初始化菜单大小
        /// </summary>
        public void InitializationMenu()                          
        {
             foreach(Control c in Left_menu.Controls)
             {
                 if (c is FlowLayoutPanel && c.Height >10)            //找到被打开的菜单，缩小
                 {
                     hideflp = c as FlowLayoutPanel;
                     initialization_timer.Start();
                     Left_menu_showtimer.Start();
                     break;
                 }
             }
        }
        /// <summary>
        /// 显示菜单计时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Left_menu_showtimer_Tick(object sender, EventArgs e)
        {
                flp.Height += 20;                                            //对菜单高度进行更改
                if (flp.Height >= left_btn_put_1.Height * flp.Controls.Count)//如果菜单高度高于子控件数量乘以子控件高度 则停止增加
                {
                    flp.Height = left_btn_put_1.Height * flp.Controls.Count;
                    menu_is_show = false;
                    Left_menu_showtimer.Stop();
                }
            
        }

        /// <summary>
        /// 隐藏菜单计时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Left_menu_hidetimer_Tick(object sender, EventArgs e)
        {
             flp.Height -= 20;
                if (flp.Height <= 1)                         //如果菜单高度低于1px,则停止减少
                {
                    menu_is_show = true;
                    Left_menu_hidetimer.Stop();
                }
        }
        /// <summary>
        /// 初始化菜单计时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void initialization_timer_Tick(object sender, EventArgs e)
        {
            hideflp.Height -= 20;
            if (hideflp.Height <= 1)
            {
                initialization_timer.Stop();
            }  
        }
        /// <summary>
        /// 入库单列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void left_btn_put_1_Click(object sender, EventArgs e)
        {
            body.Controls.Clear();             //清除body中所有控件
            PutInventory pi = new PutInventory();                                          
            pi.MdiParent = this;
            pi.Dock = DockStyle.Fill;
            pi.Parent = body;                  //设置入库单列表窗体的父容器为body(panel)
            pi.Show(); 
        }
        /// <summary>
        /// 新建入库单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void left_btn_put_2_Click(object sender, EventArgs e)
        {
            body.Controls.Clear();             //清除body中所有控件
            NewPutInventory npi = new NewPutInventory();
            npi.MdiParent = this;
            npi.Dock = DockStyle.Fill;
            npi.Parent = body;
            npi.Show();
        }
        /// <summary>
        /// 出库单列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void left_btn_out_1_Click(object sender, EventArgs e)
        {
            body.Controls.Clear();             //清除body中所有控件
            OutInventory oi = new OutInventory();
            oi.MdiParent = this;
            oi.Dock = DockStyle.Fill;
            oi.Parent = body;
            oi.Show(); 
        }
        /// <summary>
        /// 新建出库单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void left_btn_out_2_Click(object sender, EventArgs e)
        {
            body.Controls.Clear();             //清除body中所有控件
            NewOutInventory noi = new NewOutInventory();
            noi.MdiParent = this;
            noi.Dock = DockStyle.Fill;
            noi.Parent = body;
            noi.Show(); 
        }

        /// <summary>
        /// 查看库存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void left_btn_stock_1_Click(object sender, EventArgs e)
        {
            body.Controls.Clear();             //清除body中所有控件
            Inventory i = new Inventory();
            i.MdiParent = this;
            i.Dock = DockStyle.Fill;
            i.Parent = body;
            i.Show(); 
        }
        /// <summary>
        /// 仓库管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void left_btn_stock_2_Click(object sender, EventArgs e)
        {
            body.Controls.Clear();             //清除body中所有控件
            Warehouse w = new Warehouse();
            w.MdiParent = this;
            w.Dock = DockStyle.Fill;
            w.Parent = body;
            w.Show(); 
        }

         /// <summary>
         /// 货物转仓按钮
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void left_btn_stock_3_Click(object sender, EventArgs e)
        {
            body.Controls.Clear();             //清除body中所有控件
            GoodsDevolve gd = new GoodsDevolve();
            gd.MdiParent = this;
            gd.Dock = DockStyle.Fill;
            gd.Parent = body;
            gd.Show(); 
        }
        /// <summary>
        /// 清单查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void left_btn_stock_4_Click(object sender, EventArgs e)
        {
            body.Controls.Clear();             //清除body中所有控件
            BillFind bm = new BillFind();
            bm.MdiParent = this;
            bm.Dock = DockStyle.Fill;
            bm.Parent = body;
            bm.Show(); 
        }

        /// <summary>
        /// 管理员信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void left_btn_manager_1_Click(object sender, EventArgs e)
        {
            body.Controls.Clear();             //清除body中所有控件
            ManagerInfo mi = new ManagerInfo();
            mi.MdiParent = this;
            mi.Dock = DockStyle.Fill;
            mi.Parent = body;
            mi.Show();
        }
        /// <summary>
        /// 新建管理员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void left_btn_manager_2_Click(object sender, EventArgs e)
        {
            body.Controls.Clear();             //清除body中所有控件
            NewManager nm = new NewManager();
            nm.MdiParent = this;
            nm.Dock = DockStyle.Fill;
            nm.Parent = body;
            nm.Show();
        }

        

        private void left_btn_backstage_1_Click(object sender, EventArgs e)
        {
            body.Controls.Clear();             //清除body中所有控件
            ClientInfo ci = new ClientInfo();
            ci.MdiParent = this;
            ci.Dock = DockStyle.Fill;
            ci.Parent = body;
            ci.Show();
        }

        private void left_btn_backstage_2_Click(object sender, EventArgs e)
        {
            body.Controls.Clear();             //清除body中所有控件
            GoodsType gt = new GoodsType();
            gt.MdiParent = this;
            gt.Dock = DockStyle.Fill;
            gt.Parent = body;
            gt.Show();
        }

       

        
        

        

        


        
    }
}
