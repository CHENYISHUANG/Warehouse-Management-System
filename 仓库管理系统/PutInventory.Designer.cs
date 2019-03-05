namespace 仓库管理系统
{
    partial class PutInventory
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
            this.data_storage = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.Label();
            this.panel_top = new System.Windows.Forms.Panel();
            this.btn_print = new System.Windows.Forms.Button();
            this.date_stop_time = new System.Windows.Forms.DateTimePicker();
            this.date_start_time = new System.Windows.Forms.DateTimePicker();
            this.text_find_name = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_query = new System.Windows.Forms.Button();
            this.lab_stop_text = new System.Windows.Forms.Label();
            this.lab_start_text = new System.Windows.Forms.Label();
            this.com_find_type = new System.Windows.Forms.ComboBox();
            this.lab_find_type = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_storage)).BeginInit();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
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
            this.data_storage.TabIndex = 0;
            this.data_storage.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_storage_CellDoubleClick);
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Title.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Title.Location = new System.Drawing.Point(478, 32);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(93, 16);
            this.Title.TabIndex = 1;
            this.Title.Text = "入库单记录";
            // 
            // panel_top
            // 
            this.panel_top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_top.Controls.Add(this.btn_print);
            this.panel_top.Controls.Add(this.date_stop_time);
            this.panel_top.Controls.Add(this.date_start_time);
            this.panel_top.Controls.Add(this.text_find_name);
            this.panel_top.Controls.Add(this.btn_reset);
            this.panel_top.Controls.Add(this.btn_query);
            this.panel_top.Controls.Add(this.lab_stop_text);
            this.panel_top.Controls.Add(this.lab_start_text);
            this.panel_top.Controls.Add(this.com_find_type);
            this.panel_top.Controls.Add(this.lab_find_type);
            this.panel_top.Controls.Add(this.Title);
            this.panel_top.Location = new System.Drawing.Point(0, -1);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1050, 161);
            this.panel_top.TabIndex = 1;
            // 
            // btn_print
            // 
            this.btn_print.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_print.Location = new System.Drawing.Point(950, 0);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(101, 29);
            this.btn_print.TabIndex = 9;
            this.btn_print.Text = "入库单生成报表";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // date_stop_time
            // 
            this.date_stop_time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date_stop_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_stop_time.Location = new System.Drawing.Point(663, 92);
            this.date_stop_time.Name = "date_stop_time";
            this.date_stop_time.Size = new System.Drawing.Size(121, 21);
            this.date_stop_time.TabIndex = 6;
            this.date_stop_time.CloseUp += new System.EventHandler(this.date_stop_time_CloseUp);
            this.date_stop_time.Enter += new System.EventHandler(this.date_stop_time_Enter);
            // 
            // date_start_time
            // 
            this.date_start_time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date_start_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_start_time.Location = new System.Drawing.Point(477, 92);
            this.date_start_time.Name = "date_start_time";
            this.date_start_time.Size = new System.Drawing.Size(121, 21);
            this.date_start_time.TabIndex = 5;
            this.date_start_time.CloseUp += new System.EventHandler(this.date_start_time_CloseUp);
            // 
            // text_find_name
            // 
            this.text_find_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_find_name.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.text_find_name.Location = new System.Drawing.Point(271, 92);
            this.text_find_name.Name = "text_find_name";
            this.text_find_name.Size = new System.Drawing.Size(121, 21);
            this.text_find_name.TabIndex = 4;
            this.text_find_name.Text = "请输入关键字";
            this.text_find_name.Enter += new System.EventHandler(this.text_find_name_Enter);
            // 
            // btn_reset
            // 
            this.btn_reset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_reset.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Location = new System.Drawing.Point(905, 90);
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
            this.btn_query.Location = new System.Drawing.Point(805, 90);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(75, 23);
            this.btn_query.TabIndex = 7;
            this.btn_query.Text = "查询";
            this.btn_query.UseVisualStyleBackColor = false;
            this.btn_query.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // lab_stop_text
            // 
            this.lab_stop_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_stop_text.AutoSize = true;
            this.lab_stop_text.Location = new System.Drawing.Point(604, 95);
            this.lab_stop_text.Name = "lab_stop_text";
            this.lab_stop_text.Size = new System.Drawing.Size(53, 12);
            this.lab_stop_text.TabIndex = 6;
            this.lab_stop_text.Text = "截止时间";
            // 
            // lab_start_text
            // 
            this.lab_start_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_start_text.AutoSize = true;
            this.lab_start_text.Location = new System.Drawing.Point(408, 95);
            this.lab_start_text.Name = "lab_start_text";
            this.lab_start_text.Size = new System.Drawing.Size(53, 12);
            this.lab_start_text.TabIndex = 4;
            this.lab_start_text.Text = "起始时间";
            // 
            // com_find_type
            // 
            this.com_find_type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.com_find_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_find_type.FormattingEnabled = true;
            this.com_find_type.Location = new System.Drawing.Point(119, 92);
            this.com_find_type.Name = "com_find_type";
            this.com_find_type.Size = new System.Drawing.Size(121, 20);
            this.com_find_type.TabIndex = 3;
            // 
            // lab_find_type
            // 
            this.lab_find_type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_find_type.AutoSize = true;
            this.lab_find_type.Location = new System.Drawing.Point(60, 95);
            this.lab_find_type.Name = "lab_find_type";
            this.lab_find_type.Size = new System.Drawing.Size(53, 12);
            this.lab_find_type.TabIndex = 2;
            this.lab_find_type.Text = "查询方式";
            // 
            // PutInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 602);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.data_storage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PutInventory";
            this.Text = "PutInventory";
            this.Load += new System.EventHandler(this.PutInventory_Load);
            this.Resize += new System.EventHandler(this.PutInventory_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.data_storage)).EndInit();
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_storage;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.ComboBox com_find_type;
        private System.Windows.Forms.Label lab_find_type;
        private System.Windows.Forms.Label lab_stop_text;
        private System.Windows.Forms.Label lab_start_text;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.TextBox text_find_name;
        private System.Windows.Forms.DateTimePicker date_start_time;
        private System.Windows.Forms.DateTimePicker date_stop_time;
        private System.Windows.Forms.Button btn_print;

    }
}