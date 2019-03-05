namespace 仓库管理系统
{
    partial class DeleteWarehouse
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
            this.label1 = new System.Windows.Forms.Label();
            this.com_warehouse_id = new System.Windows.Forms.ComboBox();
            this.lab_warehouse_id = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(217, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "删除仓库";
            // 
            // com_warehouse_id
            // 
            this.com_warehouse_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.com_warehouse_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_warehouse_id.FormattingEnabled = true;
            this.com_warehouse_id.Location = new System.Drawing.Point(263, 99);
            this.com_warehouse_id.Name = "com_warehouse_id";
            this.com_warehouse_id.Size = new System.Drawing.Size(121, 20);
            this.com_warehouse_id.TabIndex = 137;
            // 
            // lab_warehouse_id
            // 
            this.lab_warehouse_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_warehouse_id.AutoSize = true;
            this.lab_warehouse_id.Location = new System.Drawing.Point(102, 102);
            this.lab_warehouse_id.Name = "lab_warehouse_id";
            this.lab_warehouse_id.Size = new System.Drawing.Size(155, 12);
            this.lab_warehouse_id.TabIndex = 138;
            this.lab_warehouse_id.Text = "请将仓库存货转移到新仓库:";
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(444, -1);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(38, 36);
            this.btn_close.TabIndex = 139;
            this.btn_close.Text = "×";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(309, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 140;
            this.button1.Text = "确定转移";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(104, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 141;
            this.button2.Text = "我不想转移";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DeleteWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(481, 282);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.com_warehouse_id);
            this.Controls.Add(this.lab_warehouse_id);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteWarehouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DeleteWarehouse";
            this.Load += new System.EventHandler(this.DeleteWarehouse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox com_warehouse_id;
        private System.Windows.Forms.Label lab_warehouse_id;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}