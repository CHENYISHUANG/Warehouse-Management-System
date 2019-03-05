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
    public partial class DeleteNode : Form
    {
        GoodsTypeBLL gtb = new GoodsTypeBLL();
        int id; 
        public DeleteNode(int id)
        {
            this.id = id;
            InitializeComponent();
        }
        /// <summary>
        /// 关闭按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
        /// <summary>
        /// 删除该类型及下面所有类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            gtb.DeleteAll(id);
            this.DialogResult = DialogResult.OK;
            this.Close(); 
        }
        /// <summary>
        /// 删除当前类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            gtb.Delete(id);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
