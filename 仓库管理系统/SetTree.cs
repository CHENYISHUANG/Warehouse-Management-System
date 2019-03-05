using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseMOD;

namespace 仓库管理系统
{
   public class SetTree
    {
        /// <summary>
        /// 设置树形菜单
        /// </summary>
        public static void Settree(TreeView tr, TreeNode tn, List<GoodsTypeMOD> listg, int parentid)
        {
            foreach (GoodsTypeMOD g in listg)
            {
                if (g.Node_parent == parentid)
                {
                    TreeNode tnode = new TreeNode();
                    tnode.Text = g.Goods_type;
                    tnode.Tag = g.Id;
                    if (g.Node_parent == 0)
                    {
                        tr.Nodes.Add(tnode);
                    }
                    else
                    {
                        tn.Nodes.Add(tnode);
                    }
                    Settree(null, tnode, listg, (int)tnode.Tag);
                }
            }
        }

        public static int GetTreeLevel(List<GoodsTypeMOD> listg)
        {
            int tree_level=0;
            foreach (GoodsTypeMOD gtm in listg)
            {
                if (tree_level < gtm.Node_depth)
                {
                    tree_level = gtm.Node_depth;
                }
            }
            return tree_level;
        }
        private void tvRoleAll_AfterCheck(object sender, System.Windows.Forms.TreeViewEventArgs e)
        {

            if (e.Action != TreeViewAction.Unknown)
            {
                SetNodeCheckStatus(e.Node, e.Node.Checked);
                SetNodeStyle(e.Node);
            }

        }



        private void SetNodeCheckStatus(TreeNode tn, bool Checked)
        {

            if (tn == null) return;
            foreach (TreeNode tnChild in tn.Nodes)
            {

                tnChild.Checked = Checked;

                SetNodeCheckStatus(tnChild, Checked);

            }
            TreeNode tnParent = tn;
        }



        private void SetNodeStyle(TreeNode Node)
        {
            int nNodeCount = 0;
            if (Node.Nodes.Count != 0)
            {
                foreach (TreeNode tnTemp in Node.Nodes)
                {

                    if (tnTemp.Checked == true)

                        nNodeCount++;
                }

                if (nNodeCount == Node.Nodes.Count)
                {
                    Node.Checked = true;
                    Node.ExpandAll();
                    Node.ForeColor = Color.Black;
                }
                else if (nNodeCount == 0)
                {
                    Node.Checked = false;
                    Node.Collapse();
                    Node.ForeColor = Color.Black;
                }
                else
                {
                    Node.Checked = true;
                    Node.ForeColor = Color.Gray;
                }
            }
            //当前节点选择完后，判断父节点的状态，调用此方法递归。  
            if (Node.Parent != null)
                SetNodeStyle(Node.Parent);
        }   
    }
}
