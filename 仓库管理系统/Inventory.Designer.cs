namespace 仓库管理系统
{
    partial class Inventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_top = new System.Windows.Forms.Panel();
            this.com_find_type2 = new System.Windows.Forms.ComboBox();
            this.lab_find_type2 = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_query = new System.Windows.Forms.Button();
            this.com_find_type = new System.Windows.Forms.ComboBox();
            this.lab_find_type = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.data_storage = new System.Windows.Forms.DataGridView();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_storage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_top.Controls.Add(this.com_find_type2);
            this.panel_top.Controls.Add(this.lab_find_type2);
            this.panel_top.Controls.Add(this.btn_reset);
            this.panel_top.Controls.Add(this.btn_query);
            this.panel_top.Controls.Add(this.com_find_type);
            this.panel_top.Controls.Add(this.lab_find_type);
            this.panel_top.Controls.Add(this.Title);
            this.panel_top.Location = new System.Drawing.Point(0, -1);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1050, 161);
            this.panel_top.TabIndex = 5;
            // 
            // com_find_type2
            // 
            this.com_find_type2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.com_find_type2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_find_type2.FormattingEnabled = true;
            this.com_find_type2.Location = new System.Drawing.Point(535, 92);
            this.com_find_type2.Name = "com_find_type2";
            this.com_find_type2.Size = new System.Drawing.Size(121, 20);
            this.com_find_type2.TabIndex = 10;
            // 
            // lab_find_type2
            // 
            this.lab_find_type2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_find_type2.AutoSize = true;
            this.lab_find_type2.Location = new System.Drawing.Point(464, 95);
            this.lab_find_type2.Name = "lab_find_type2";
            this.lab_find_type2.Size = new System.Drawing.Size(41, 12);
            this.lab_find_type2.TabIndex = 9;
            this.lab_find_type2.Text = "请选择";
            // 
            // btn_reset
            // 
            this.btn_reset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_reset.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Location = new System.Drawing.Point(843, 90);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 8;
            this.btn_reset.Text = "重置";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_query
            // 
            this.btn_query.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_query.BackColor = System.Drawing.Color.LightBlue;
            this.btn_query.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_query.Location = new System.Drawing.Point(743, 90);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(75, 23);
            this.btn_query.TabIndex = 7;
            this.btn_query.Text = "查询";
            this.btn_query.UseVisualStyleBackColor = false;
            this.btn_query.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // com_find_type
            // 
            this.com_find_type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.com_find_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_find_type.FormattingEnabled = true;
            this.com_find_type.Location = new System.Drawing.Point(238, 92);
            this.com_find_type.Name = "com_find_type";
            this.com_find_type.Size = new System.Drawing.Size(121, 20);
            this.com_find_type.TabIndex = 3;
            this.com_find_type.SelectionChangeCommitted += new System.EventHandler(this.com_find_type_SelectionChangeCommitted);
            // 
            // lab_find_type
            // 
            this.lab_find_type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_find_type.AutoSize = true;
            this.lab_find_type.Location = new System.Drawing.Point(179, 95);
            this.lab_find_type.Name = "lab_find_type";
            this.lab_find_type.Size = new System.Drawing.Size(53, 12);
            this.lab_find_type.TabIndex = 2;
            this.lab_find_type.Text = "查询方式";
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Title.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Title.Location = new System.Drawing.Point(478, 32);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(96, 16);
            this.Title.TabIndex = 1;
            this.Title.Text = "库      存";
            // 
            // data_storage
            // 
            this.data_storage.AllowUserToAddRows = false;
            this.data_storage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_storage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_storage.BackgroundColor = System.Drawing.Color.White;
            this.data_storage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_storage.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.data_storage.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_storage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_storage.ColumnHeadersHeight = 40;
            this.data_storage.Location = new System.Drawing.Point(0, 166);
            this.data_storage.MultiSelect = false;
            this.data_storage.Name = "data_storage";
            this.data_storage.ReadOnly = true;
            this.data_storage.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_storage.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.data_storage.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.data_storage.RowTemplate.Height = 30;
            this.data_storage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_storage.Size = new System.Drawing.Size(1050, 437);
            this.data_storage.TabIndex = 4;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 602);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.data_storage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.Resize += new System.EventHandler(this.Inventory_Resize);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_storage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.ComboBox com_find_type;
        private System.Windows.Forms.Label lab_find_type;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.ComboBox com_find_type2;
        private System.Windows.Forms.Label lab_find_type2;
        private System.Windows.Forms.DataGridView data_storage;

    }
}