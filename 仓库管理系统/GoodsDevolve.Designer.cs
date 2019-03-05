namespace 仓库管理系统
{
    partial class GoodsDevolve
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.com_warehouse_id = new System.Windows.Forms.ComboBox();
            this.lab_warehouse_id = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.panel_center = new System.Windows.Forms.Panel();
            this.data_storage = new System.Windows.Forms.DataGridView();
            this.btn_put = new System.Windows.Forms.Button();
            this.panel_dowm = new System.Windows.Forms.Panel();
            this.text_goods_amount = new System.Windows.Forms.TextBox();
            this.lab_goods_amount = new System.Windows.Forms.Label();
            this.com_put_warehouse = new System.Windows.Forms.ComboBox();
            this.lab_put_warehouse = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.panel_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_storage)).BeginInit();
            this.panel_dowm.SuspendLayout();
            this.SuspendLayout();
            // 
            // com_warehouse_id
            // 
            this.com_warehouse_id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.com_warehouse_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_warehouse_id.FormattingEnabled = true;
            this.com_warehouse_id.Location = new System.Drawing.Point(217, 125);
            this.com_warehouse_id.Name = "com_warehouse_id";
            this.com_warehouse_id.Size = new System.Drawing.Size(121, 20);
            this.com_warehouse_id.TabIndex = 95;
            this.com_warehouse_id.SelectionChangeCommitted += new System.EventHandler(this.com_warehouse_id_SelectionChangeCommitted);
            // 
            // lab_warehouse_id
            // 
            this.lab_warehouse_id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lab_warehouse_id.AutoSize = true;
            this.lab_warehouse_id.Location = new System.Drawing.Point(152, 128);
            this.lab_warehouse_id.Name = "lab_warehouse_id";
            this.lab_warehouse_id.Size = new System.Drawing.Size(53, 12);
            this.lab_warehouse_id.TabIndex = 96;
            this.lab_warehouse_id.Text = "选择仓库";
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Title.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Title.Location = new System.Drawing.Point(478, 32);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(74, 21);
            this.Title.TabIndex = 97;
            this.Title.Text = "货物转仓";
            // 
            // panel_center
            // 
            this.panel_center.BackColor = System.Drawing.Color.White;
            this.panel_center.Controls.Add(this.data_storage);
            this.panel_center.Location = new System.Drawing.Point(5, 228);
            this.panel_center.Name = "panel_center";
            this.panel_center.Size = new System.Drawing.Size(1043, 0);
            this.panel_center.TabIndex = 98;
            // 
            // data_storage
            // 
            this.data_storage.AllowUserToAddRows = false;
            this.data_storage.AllowUserToDeleteRows = false;
            this.data_storage.AllowUserToResizeColumns = false;
            this.data_storage.AllowUserToResizeRows = false;
            this.data_storage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.data_storage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_storage.BackgroundColor = System.Drawing.Color.White;
            this.data_storage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_storage.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.data_storage.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_storage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.data_storage.ColumnHeadersHeight = 40;
            this.data_storage.Location = new System.Drawing.Point(-4, -346);
            this.data_storage.MultiSelect = false;
            this.data_storage.Name = "data_storage";
            this.data_storage.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_storage.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.data_storage.RowHeadersVisible = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.data_storage.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.data_storage.RowTemplate.Height = 30;
            this.data_storage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_storage.Size = new System.Drawing.Size(1050, 0);
            this.data_storage.TabIndex = 99;
            // 
            // btn_put
            // 
            this.btn_put.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_put.BackColor = System.Drawing.Color.White;
            this.btn_put.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_put.Location = new System.Drawing.Point(438, 531);
            this.btn_put.Name = "btn_put";
            this.btn_put.Size = new System.Drawing.Size(184, 35);
            this.btn_put.TabIndex = 103;
            this.btn_put.Text = "确  定";
            this.btn_put.UseVisualStyleBackColor = false;
            this.btn_put.Click += new System.EventHandler(this.btn_put_Click);
            // 
            // panel_dowm
            // 
            this.panel_dowm.BackColor = System.Drawing.Color.Transparent;
            this.panel_dowm.Controls.Add(this.text_goods_amount);
            this.panel_dowm.Controls.Add(this.lab_goods_amount);
            this.panel_dowm.Controls.Add(this.com_put_warehouse);
            this.panel_dowm.Controls.Add(this.lab_put_warehouse);
            this.panel_dowm.Location = new System.Drawing.Point(2, 395);
            this.panel_dowm.Name = "panel_dowm";
            this.panel_dowm.Size = new System.Drawing.Size(1036, 78);
            this.panel_dowm.TabIndex = 104;
            // 
            // text_goods_amount
            // 
            this.text_goods_amount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_goods_amount.Location = new System.Drawing.Point(768, 28);
            this.text_goods_amount.MaxLength = 9;
            this.text_goods_amount.Name = "text_goods_amount";
            this.text_goods_amount.Size = new System.Drawing.Size(121, 21);
            this.text_goods_amount.TabIndex = 125;
            this.text_goods_amount.WordWrap = false;
            // 
            // lab_goods_amount
            // 
            this.lab_goods_amount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_goods_amount.AutoSize = true;
            this.lab_goods_amount.Location = new System.Drawing.Point(703, 31);
            this.lab_goods_amount.Name = "lab_goods_amount";
            this.lab_goods_amount.Size = new System.Drawing.Size(59, 12);
            this.lab_goods_amount.TabIndex = 126;
            this.lab_goods_amount.Text = "物品数量:";
            // 
            // com_put_warehouse
            // 
            this.com_put_warehouse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.com_put_warehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_put_warehouse.FormattingEnabled = true;
            this.com_put_warehouse.Location = new System.Drawing.Point(215, 28);
            this.com_put_warehouse.Name = "com_put_warehouse";
            this.com_put_warehouse.Size = new System.Drawing.Size(121, 20);
            this.com_put_warehouse.TabIndex = 123;
            // 
            // lab_put_warehouse
            // 
            this.lab_put_warehouse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_put_warehouse.AutoSize = true;
            this.lab_put_warehouse.Location = new System.Drawing.Point(150, 31);
            this.lab_put_warehouse.Name = "lab_put_warehouse";
            this.lab_put_warehouse.Size = new System.Drawing.Size(53, 12);
            this.lab_put_warehouse.TabIndex = 124;
            this.lab_put_warehouse.Text = "转入仓库";
            // 
            // btn_reset
            // 
            this.btn_reset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_reset.BackColor = System.Drawing.Color.Transparent;
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Location = new System.Drawing.Point(707, 115);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(184, 30);
            this.btn_reset.TabIndex = 105;
            this.btn_reset.Text = "重  置";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // GoodsDevolve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 602);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.panel_dowm);
            this.Controls.Add(this.btn_put);
            this.Controls.Add(this.panel_center);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.com_warehouse_id);
            this.Controls.Add(this.lab_warehouse_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(497, 53);
            this.Name = "GoodsDevolve";
            this.Text = "GoodsDevolve";
            this.Load += new System.EventHandler(this.GoodsDevolve_Load);
            this.Resize += new System.EventHandler(this.GoodsDevolve_Resize);
            this.panel_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_storage)).EndInit();
            this.panel_dowm.ResumeLayout(false);
            this.panel_dowm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox com_warehouse_id;
        private System.Windows.Forms.Label lab_warehouse_id;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel panel_center;
        private System.Windows.Forms.DataGridView data_storage;
        private System.Windows.Forms.Button btn_put;
        private System.Windows.Forms.Panel panel_dowm;
        private System.Windows.Forms.TextBox text_goods_amount;
        private System.Windows.Forms.Label lab_goods_amount;
        private System.Windows.Forms.ComboBox com_put_warehouse;
        private System.Windows.Forms.Label lab_put_warehouse;
        private System.Windows.Forms.Button btn_reset;
    }
}