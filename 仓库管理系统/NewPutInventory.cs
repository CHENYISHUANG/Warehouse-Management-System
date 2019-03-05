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
    public partial class NewPutInventory : Form
    {
        bool isgive = false;                                          //是否自动赋值
        string tree_count;                                            //treeview的节点数量
        int tree_level = 0;                                           //treeview的节点层数
        int goods_type_id;                                            //物品类型ID 
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
        
        public NewPutInventory()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewPutInventory_Load(object sender, EventArgs e)
        {
            listgtm = gtb.FindAll();
            SetTree.Settree(Goodstypetree, (TreeNode)null, listgtm, 0);            //递归创建TREE
            Goodstypetree.ExpandAll();                                             //展开所有节点
            comb_goods_name.Leave += new EventHandler(comb_goods_name_Leave);      //注册comb_goods_name的焦点失去事件
            Goodstypetree.Leave += new EventHandler(Goodstypetree_Leave);          //注册treeview的焦点失去事件
            com_type_id.DataSource = ob.FindPutAll();                              //绑定数据到操作类型
            com_type_id.ValueMember = "Id";
            com_type_id.DisplayMember = "Operation_type";
            com_client_id.DataSource = cb.FindAll();                               //绑定数据到选择客户
            com_client_id.DisplayMember = "Client_name";
            com_client_id.ValueMember = "Id";
            com_warehouse_id.DataSource = wnb.FindAll();                           //绑定数据到选择仓库
            com_warehouse_id.DisplayMember = "Warehouse_name";
            com_warehouse_id.ValueMember = "Id";
        }
        /// <summary>
        /// treeview的CheckBox事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Goodstypetree_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Unknown)                       //如果不是未知的事件
            {
                foreach (TreeNode tn in Goodstypetree.Nodes)               //遍历treeview的根节点
                {
                    tn.Checked = false;                                   //把根节点改为未选中
                    tn.Collapse();                                        //折叠根节点
                    SetNodeCheckStatus(tn);                               //调用根节点的子节点方法
                }
                e.Node.Checked = true;                                    //把勾上的节点改为选中
                goods_type_id =(int)e.Node.Tag;                           //把当前节点tag赋给物品类型ID
                SetNodeStyle(e.Node);                                     //调用更改父节点折叠的方法
                tree_label.Text = e.Node.Text;                            
            }
        }

        /// <summary>
        /// 子节点的递归
        /// </summary>
        /// <param name="tn"></param>
        private void SetNodeCheckStatus(TreeNode tn)
        {

            if (tn == null) return;
            foreach (TreeNode tnChild in tn.Nodes)
            {
                tnChild.Checked = false;
                tnChild.Collapse();
                SetNodeCheckStatus(tnChild);
            }
        }

        /// <summary>
        /// 父节点的递归
        /// </summary>
        /// <param name="Node"></param>
        private void SetNodeStyle(TreeNode Node)
        {
            if (Node.Parent != null)
            {
                Node.Parent.Expand();
                SetNodeStyle(Node.Parent);
            }
        }

        /// <summary>
        /// treeview的显示计时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tree_show_timer_Tick(object sender, EventArgs e)
        {
            if (Goodstypetree.Width < tree_level * 45)
            {
                Goodstypetree.Width += 15;
            }
            if (Goodstypetree.Height < int.Parse(tree_count) * 15)
            {
                Goodstypetree.Height += 25;
            }
            if (Goodstypetree.Width >= tree_level * 45 && Goodstypetree.Height >= int.Parse(tree_count) * 15)
            {
                Tree_show_timer.Stop();
            }
        }
        /// <summary>
        /// treeview的隐藏计时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tree_hide_timer_Tick(object sender, EventArgs e)
        {
            if (Goodstypetree.Width >= 121)
            {
                Goodstypetree.Width -= 5;
            }
            if (Goodstypetree.Height >= 20)
            {
                Goodstypetree.Height -= 15;
            }
            if (Goodstypetree.Width <= 121 && Goodstypetree.Height <= 20)
            {
                tree_label.Show();
                Tree_hide_timer.Stop();
            }
        }
        /// <summary>
        /// treeview的单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tree_label_Click(object sender, EventArgs e)
        {
            tree_label.Hide();                                          //显示treeview
            tree_count = Goodstypetree.GetNodeCount(true).ToString();
            tree_level = SetTree.GetTreeLevel(listgtm);
            if (Goodstypetree.Width < tree_level * 45 || Goodstypetree.Height < int.Parse(tree_count) * 15)
            {
                Tree_show_timer.Start();
            }
        }

        /// <summary>
        ///     tree的焦点失去事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Goodstypetree_Leave(object sender, EventArgs e)
        {
            if (Goodstypetree.Width > 121 || Goodstypetree.Height > 20)
            {
                Tree_hide_timer.Start();                                    //隐藏treeview
            }
        }
        /// <summary>
        /// 背景单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewPutInventory_Click(object sender, EventArgs e)
        {   
            SetGoodsinfo();
            if (Goodstypetree.Width > 121 || Goodstypetree.Height > 20)
            {
                Tree_hide_timer.Start();                                    //隐藏treeview
            }
           
        }
        /// <summary>
        /// 入库按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_storage_Click_1(object sender, EventArgs e)
        {
            Boolean isnull = true;                           //标识textbox是否有空
            foreach (Control c in this.Controls)             //循环判断textbox是否为空
            {
                if (c is TextBox)
                {
                    if (c.Text == "")
                    {
                        isnull = false;
                    }
                }
            }
            try
            {
                DateTime dt = DateTime.Parse(text_expiration_date.Text);     //判断用户输入的日期格式是否正确
                dt = DateTime.Parse(text_manufacture_date.Text);
            }
            catch (Exception)
            {
                isnull = false;
            }
            if (comb_goods_name.Text != "" && tree_label.Text != "" &&
                com_warehouse_id.Text != "" && com_type_id.Text != "" &&
                isnull && com_client_id.Text != "")   //判断下拉列表是否为空
            {
                gm.Goods_name = comb_goods_name.Text;                           //物品名
                gm.Goods_type_id = goods_type_id;                               //物品类型ID
                gm.Goods_code = text_goods_code.Text;                           //物品代码
                gm.Specifications = text_specifications.Text;                   //物品规格
                gm.Goods_volume = text_goods_volume.Text;                       //物品体积
                gm.Goods_wight = text_goods_wight.Text;                         //物品重量
                gm.Goods_note = text_goods_note.Text;                           //物品备注
                listgm.Clear();
                listgm = gb.FindAllCondition(gm);                                //把物品所有信息当做条件进行查询
                if (listgm.Count == 0)                                          //如果插入的物品和数据库不一致
                {
                    bm.Goods_id = gb.Insert(gm);                                       //物品ID
                }
                else
                {
                    bm.Goods_id = listgm[0].Id;
                }
                bm.Goods_price = Double.Parse(text_goods_price.Text);               //物品价格
                bm.Lot_number = text_lot_number.Text;                              //入库批号
                bm.Client_id = (int)com_client_id.SelectedValue;                   //客户ID
                bm.Goods_amount = Int32.Parse(text_goods_amount.Text);              //物品数量
                bm.Manager_id = LoginInfo.manager_info.Id;                         //管理员ID
                bm.Manufacture_date = text_manufacture_date.Text;                  //生产日期
                bm.Expiration_date = text_expiration_date.Text;                    //到期日期
                bm.Operation_time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");  //操作日期
                bm.Warehouse_id = (int)com_warehouse_id.SelectedValue;             //仓库号
                bm.Operation_type_id = (int)com_type_id.SelectedValue;             //操作方式
                bm.Bill_note = text_bill_note.Text;                                //清单备注
                bb.Insert(bm);                                                     //插入到清单表
                im.Goods_id = bm.Goods_id;                                         //物品ID
                im.Warehouse_id = bm.Warehouse_id;                                 //仓库ID
                im.Client_id = bm.Client_id;                                       //客户ID
                im.Goods_amount = bm.Goods_amount;                                 //物品总数
                im.Goods_total = bm.Goods_amount * bm.Goods_price;                 //物品总价
                listi = ib.FindId(im.Goods_id, im.Warehouse_id, im.Client_id);
                if (listi.Count > 0)
                {
                    ib.Update(listi[0], im.Goods_amount, im.Goods_total);
                }
                else
                {

                    ib.Insert(im);
                }
                PutInventory pi = new PutInventory();
                pi.TopLevel = false;
                pi.MdiParent = this.MdiParent;
                pi.Parent = this.Parent;
                pi.Dock = DockStyle.Fill;
                pi.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("请确保填入内容的完整性！", "警告!");
            }
        }
        /// <summary>
        /// 物品名输入框的文字改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        int c_count = 0;                                                                //储存文本长度
        private void comb_goods_name_KeyUp(object sender, KeyEventArgs e)
      {
            if (comb_goods_name.Text.Length != c_count && comb_goods_name.Text.Length != 0)    //如果事件触发时文本长度和原长度不一致同时不为空时触发
            {
                listgm.Clear();
                string text = comb_goods_name.Text;                                        //把文本框值赋给text
                listgm = gb.FindLike(comb_goods_name.Text);                                //根据用户输入的值查询
                DataTable ta = new DataTable();                                            //绑定数据到 comb_goods_name
                ta.Columns.Add("ID");
                ta.Columns.Add("名称");
                foreach (GoodsMOD item in listgm)
                {
                    DataRow row = ta.NewRow();
                    row["ID"] = item.Id;
                    row["名称"] = item.Goods_name;
                    ta.Rows.Add(row);
                }
                comb_goods_name.DataSource = ta;
                comb_goods_name.DisplayMember = "名称";
                comb_goods_name.ValueMember = "ID";
                Cursor = Cursors.Default;                                                   // 重新获取鼠标
                this.comb_goods_name.DroppedDown = true;                                    //弹出下拉列表   
                comb_goods_name.Text = text;                                                //把text的值赋给文本框
                comb_goods_name.SelectionStart = comb_goods_name.Text.Length;               //把光标移到最后面    
            }
            c_count = comb_goods_name.Text.Length;                                          //把当前文本长度赋给c_count
        }
        /// <summary>
        ///     comb_goods_name的焦点失去事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comb_goods_name_Leave(object sender, EventArgs e)
        {
            SetGoodsinfo();
        }

        private void SetGoodsinfo()               //自动填入物品信息输入框的值
        {
            if (comb_goods_name.Text != ""&&isgive)
            {
                listgm = gb.ById(Int32.Parse(comb_goods_name.SelectedValue.ToString()));
                if (listgm.Count > 0)
                {
                    gm = listgm[0];
                    gtm = gtb.FindID(gm.Goods_type_id);
                    if (tree_label.Text == "双击打开下一层")
                    {
                        tree_label.Text = gtm.Goods_type;
                        goods_type_id = gtm.Id;
                    }
                    text_goods_code.Text = gm.Goods_code;
                    text_specifications.Text = gm.Specifications;
                    text_goods_volume.Text = gm.Goods_volume;
                    text_goods_wight.Text = gm.Goods_wight;
                    text_goods_note.Text = gm.Goods_note;
                    isgive = false;
                }

            }
        }
        /// <summary>
        /// 限制输入类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void text_goods_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符
                }
            }
        }
        private void text_goods_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符
                }
            }
        }

        private void text_goods_volume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符
                }
            }
        }

        private void text_goods_wight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符
                }
            }
        }
        /// <summary>
        /// 单击控件时把光标移到最左边
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void text_manufacture_date_MouseClick(object sender, MouseEventArgs e)
        {
            if(text_manufacture_date.Text=="    -  -")
            {
                text_manufacture_date.SelectionStart = 0;
            }
        }
        /// <summary>
        /// 单击控件时把光标移到最左边
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void text_expiration_date_MouseClick(object sender, MouseEventArgs e)
        {
            if (text_expiration_date.Text == "    -  -")
            {
                text_expiration_date.SelectionStart = 0;
            }
        }

        /// <summary>
        /// treeview的焦点获得事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Goodstypetree_Enter(object sender, EventArgs e)
        {
            tree_label.Hide();                                          //显示treeview
            tree_count = Goodstypetree.GetNodeCount(true).ToString();
            tree_level = SetTree.GetTreeLevel(listgtm);
            if (Goodstypetree.Width < tree_level * 45 || Goodstypetree.Height < int.Parse(tree_count) * 15)
            {
                Tree_show_timer.Start();
            }  
        }
        /// <summary>
        /// 物品选择下拉列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comb_goods_name_SelectionChangeCommitted(object sender, EventArgs e)
        {
            isgive = true;
        }

        private void btn_print_Click(object sender, EventArgs e)
        {

        }
    }
}
