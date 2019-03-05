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
    public partial class GoodsType : Form
    {
        int goods_type_id;                                            //物品类型ID 
        GoodsTypeBLL gtb = new GoodsTypeBLL();                        //物品类型逻辑层
        GoodsTypeMOD gtm = new GoodsTypeMOD();                        //数据类型实体类
        List<GoodsTypeMOD> listgtm = new List<GoodsTypeMOD>();        //物品类型集合
        int btn_type = 0;                                             //标记按的哪个按钮(1)添加总类型(2)添加子类型(3)编辑
        public GoodsType()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoodsType_Load(object sender, EventArgs e)
        {
            listgtm = gtb.FindAll();
            SetTree.Settree(Goodstypetree, (TreeNode)null, listgtm, 0);            //递归创建TREE
            Goodstypetree.ExpandAll();                                             //展开所有节点
        }
        /// <summary>
        /// 大小改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoodsType_Resize(object sender, EventArgs e)
        {
            Goodstypetree.Width =Convert.ToInt32(this.Width * 0.6);
            Goodstypetree.Height = Convert.ToInt32(this.Height * 0.5);
            Goodstypetree.Left = Convert.ToInt32(this.Width-Goodstypetree.Width)/2;
            panel_down.Left = Goodstypetree.Left;
            panel_down.Top = Goodstypetree.Top + Goodstypetree.Height;
            panel_down.Width = Goodstypetree.Width;
            panel_down.Height = Convert.ToInt32(this.Height * 0.3);
        }
         /// <summary>
         /// 节点单击事件
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void Goodstypetree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            lab_now_select_text.Text = e.Node.Text;
            goods_type_id = (int)e.Node.Tag;
        }
        /// <summary>
        /// 编辑按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_edit_Click(object sender, EventArgs e)
        {
            text_edit.Text = "";
            if(lab_now_select_text.Text!="")
            {
                text_edit.Enabled = true;                 //激活编辑框
                text_edit.Text = lab_now_select_text.Text;//设置编辑框值为需要更改的内容
                text_edit.Focus();
                text_edit.SelectAll();
            }
            btn_type = 3;
        }
        /// <summary>
        /// 遍历treeview
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tn"></param>
        /// <returns></returns>
        private TreeNode TreeTraversal(int id) 
        {
            foreach (TreeNode treenode in Goodstypetree.Nodes)
            {
                TreeNode tt;
                if ((int)treenode.Tag == id)
                {
                    return treenode;
                }
                tt=NodeTraversal(id, treenode);     //接收子节点方法传回参数
                if (tt == null)
                {
                    continue;
                }
                else 
                {
                    return tt;
                }
            }
            return null;
        }
        /// <summary>
        /// 遍历子节点
        /// </summary>
        private TreeNode NodeTraversal(int id,TreeNode tn)
        {
            TreeNode tt;
            if (tn.Nodes == null)
            {
                return null;
            } 
            foreach (TreeNode treenode in tn.Nodes)
            {
                if((int)treenode.Tag==id)
                {
                    return treenode;
                }
                tt= NodeTraversal(id,treenode);
                if(tt!=null)
                {
                    return tt;
                }
            }
            return null;
        }
        /// <summary>
        /// 确定按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(text_edit.Text!=""&&btn_type==3)
            {
                if (MessageBox.Show("您确定将 " + lab_now_select_text.Text + " 更改为 " + text_edit.Text + " ？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    TreeNode tn = TreeTraversal(goods_type_id);
                    tn.Text = text_edit.Text;
                    gtb.Update(goods_type_id, text_edit.Text);
                    text_edit.Enabled = false;
                    ReSet();
                }
            }
            else if (text_edit.Text != "" && btn_type == 1)
            {
                if (MessageBox.Show("您确定要创建一个名为 " + text_edit.Text + " 的总类型？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    TreeNode tn = TreeTraversal(goods_type_id);
                    gtm.Goods_type = text_edit.Text;
                    gtm.Node_parent = 0;
                    gtm.Node_depth = 1;
                    gtb.Insert(gtm);
                    ReSet();
                }
            }
            else if (text_edit.Text != "" && btn_type == 2&&lab_now_select.Text!="")
            {
                if (MessageBox.Show("您确定在 " + lab_now_select_text.Text + " 类型下添加" + text_edit.Text + " 类型？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    TreeNode tn = TreeTraversal(goods_type_id);
                    gtm.Goods_type = text_edit.Text;
                    gtm.Node_parent = goods_type_id;
                    gtm.Node_depth = tn.Level + 2;
                    gtb.Insert(gtm);
                    ReSet();
                }
            }
            btn_type = 0;
        }
        /// <summary>
        /// 添加总类型按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_add_parent_Click(object sender, EventArgs e)
        {
            text_edit.Enabled = true;
            text_edit.Focus();
            btn_type = 1;
        }
        /// <summary>
        /// 添加子类型按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_add_node_Click(object sender, EventArgs e)
        {
            text_edit.Text = "";
            text_edit.Enabled = true;
            text_edit.Focus();
            btn_type = 2;
        }
        /// <summary>
        /// 重置
        /// </summary>
        private void ReSet() 
        {
            lab_now_select_text.Text = "";
            text_edit.Text = "";
            listgtm = gtb.FindAll();
            text_edit.Enabled=false;
            goods_type_id = 0;
            Goodstypetree.Nodes.Clear();                                           //清空树节点
            SetTree.Settree(Goodstypetree, (TreeNode)null, listgtm, 0);            //递归创建TREE
            Goodstypetree.ExpandAll();                                             //展开所有节点
        }
        /// <summary>
        /// 删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (lab_now_select_text.Text != "")
            {
                DeleteNode dn = new DeleteNode(goods_type_id);
                DialogResult result = dn.ShowDialog();
                if (DialogResult.OK == result)
                {
                    MessageBox.Show("删除成功");
                    ReSet();
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
        }
    }
}
