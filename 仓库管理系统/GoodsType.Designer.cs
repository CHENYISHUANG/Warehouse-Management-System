namespace 仓库管理系统
{
    partial class GoodsType
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.Goodstypetree = new System.Windows.Forms.TreeView();
            this.panel_down = new System.Windows.Forms.Panel();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_add_parent = new System.Windows.Forms.Button();
            this.text_edit = new System.Windows.Forms.TextBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add_node = new System.Windows.Forms.Button();
            this.lab_now_select_text = new System.Windows.Forms.Label();
            this.lab_now_select = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.panel_down.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Title.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Title.Location = new System.Drawing.Point(495, 21);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(74, 21);
            this.Title.TabIndex = 144;
            this.Title.Text = "分类管理";
            // 
            // Goodstypetree
            // 
            this.Goodstypetree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Goodstypetree.BackColor = System.Drawing.Color.White;
            this.Goodstypetree.HideSelection = false;
            this.Goodstypetree.Location = new System.Drawing.Point(187, 78);
            this.Goodstypetree.Name = "Goodstypetree";
            this.Goodstypetree.Size = new System.Drawing.Size(664, 333);
            this.Goodstypetree.TabIndex = 145;
            this.Goodstypetree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.Goodstypetree_NodeMouseClick);
            // 
            // panel_down
            // 
            this.panel_down.Controls.Add(this.btn_delete);
            this.panel_down.Controls.Add(this.btn_ok);
            this.panel_down.Controls.Add(this.btn_add_parent);
            this.panel_down.Controls.Add(this.text_edit);
            this.panel_down.Controls.Add(this.btn_edit);
            this.panel_down.Controls.Add(this.btn_add_node);
            this.panel_down.Controls.Add(this.lab_now_select_text);
            this.panel_down.Controls.Add(this.lab_now_select);
            this.panel_down.Location = new System.Drawing.Point(187, 417);
            this.panel_down.Name = "panel_down";
            this.panel_down.Size = new System.Drawing.Size(664, 61);
            this.panel_down.TabIndex = 146;
            // 
            // btn_ok
            // 
            this.btn_ok.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_ok.Location = new System.Drawing.Point(484, 38);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(99, 23);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_add_parent
            // 
            this.btn_add_parent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_add_parent.Location = new System.Drawing.Point(195, 4);
            this.btn_add_parent.Name = "btn_add_parent";
            this.btn_add_parent.Size = new System.Drawing.Size(75, 23);
            this.btn_add_parent.TabIndex = 5;
            this.btn_add_parent.Text = "添加总类型";
            this.btn_add_parent.UseVisualStyleBackColor = true;
            this.btn_add_parent.Click += new System.EventHandler(this.btn_add_parent_Click);
            // 
            // text_edit
            // 
            this.text_edit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_edit.Enabled = false;
            this.text_edit.Location = new System.Drawing.Point(484, 4);
            this.text_edit.Name = "text_edit";
            this.text_edit.Size = new System.Drawing.Size(142, 21);
            this.text_edit.TabIndex = 4;
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_edit.Location = new System.Drawing.Point(391, 4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 3;
            this.btn_edit.Text = "编辑";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add_node
            // 
            this.btn_add_node.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_add_node.Location = new System.Drawing.Point(288, 4);
            this.btn_add_node.Name = "btn_add_node";
            this.btn_add_node.Size = new System.Drawing.Size(75, 23);
            this.btn_add_node.TabIndex = 2;
            this.btn_add_node.Text = "添加子类型";
            this.btn_add_node.UseVisualStyleBackColor = true;
            this.btn_add_node.Click += new System.EventHandler(this.btn_add_node_Click);
            // 
            // lab_now_select_text
            // 
            this.lab_now_select_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_now_select_text.AutoSize = true;
            this.lab_now_select_text.Location = new System.Drawing.Point(106, 9);
            this.lab_now_select_text.Name = "lab_now_select_text";
            this.lab_now_select_text.Size = new System.Drawing.Size(0, 12);
            this.lab_now_select_text.TabIndex = 1;
            // 
            // lab_now_select
            // 
            this.lab_now_select.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_now_select.AutoSize = true;
            this.lab_now_select.Location = new System.Drawing.Point(40, 9);
            this.lab_now_select.Name = "lab_now_select";
            this.lab_now_select.Size = new System.Drawing.Size(59, 12);
            this.lab_now_select.TabIndex = 0;
            this.lab_now_select.Text = "当前选中:";
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_delete.Location = new System.Drawing.Point(92, 38);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(99, 23);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "删除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // GoodsType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 543);
            this.Controls.Add(this.panel_down);
            this.Controls.Add(this.Goodstypetree);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GoodsType";
            this.Text = "GoodsType";
            this.Load += new System.EventHandler(this.GoodsType_Load);
            this.Resize += new System.EventHandler(this.GoodsType_Resize);
            this.panel_down.ResumeLayout(false);
            this.panel_down.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TreeView Goodstypetree;
        private System.Windows.Forms.Panel panel_down;
        private System.Windows.Forms.TextBox text_edit;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add_node;
        private System.Windows.Forms.Label lab_now_select_text;
        private System.Windows.Forms.Label lab_now_select;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_add_parent;
        private System.Windows.Forms.Button btn_delete;
    }
}