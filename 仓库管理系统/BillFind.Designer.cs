namespace 仓库管理系统
{
    partial class BillFind
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_top = new System.Windows.Forms.Panel();
            this.date_stop_time = new System.Windows.Forms.DateTimePicker();
            this.date_start_time = new System.Windows.Forms.DateTimePicker();
            this.text_find_name = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_query = new System.Windows.Forms.Button();
            this.lab_stop_text = new System.Windows.Forms.Label();
            this.lab_start_text = new System.Windows.Forms.Label();
            this.com_find_type = new System.Windows.Forms.ComboBox();
            this.lab_find_type = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.data_storage = new System.Windows.Forms.DataGridView();
            this.lab_find_name = new System.Windows.Forms.Label();
            this.com_type_id = new System.Windows.Forms.ComboBox();
            this.lab_type_id = new System.Windows.Forms.Label();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_storage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_top.Controls.Add(this.com_type_id);
            this.panel_top.Controls.Add(this.lab_type_id);
            this.panel_top.Controls.Add(this.lab_find_name);
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
            this.panel_top.Location = new System.Drawing.Point(-8, -21);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1050, 161);
            this.panel_top.TabIndex = 3;
            // 
            // date_stop_time
            // 
            this.date_stop_time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date_stop_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_stop_time.Location = new System.Drawing.Point(520, 128);
            this.date_stop_time.Name = "date_stop_time";
            this.date_stop_time.Size = new System.Drawing.Size(121, 21);
            this.date_stop_time.TabIndex = 6;
            this.date_stop_time.CloseUp += new System.EventHandler(this.date_stop_time_Enter);
            this.date_stop_time.Enter += new System.EventHandler(this.date_stop_time_Enter);
            // 
            // date_start_time
            // 
            this.date_start_time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date_start_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_start_time.Location = new System.Drawing.Point(186, 128);
            this.date_start_time.Name = "date_start_time";
            this.date_start_time.Size = new System.Drawing.Size(121, 21);
            this.date_start_time.TabIndex = 5;
            this.date_start_time.CloseUp += new System.EventHandler(this.date_start_time_CloseUp);
            // 
            // text_find_name
            // 
            this.text_find_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_find_name.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.text_find_name.Location = new System.Drawing.Point(520, 90);
            this.text_find_name.Name = "text_find_name";
            this.text_find_name.Size = new System.Drawing.Size(121, 21);
            this.text_find_name.TabIndex = 4;
            this.text_find_name.Text = "请输入查询关键字";
            this.text_find_name.Enter += new System.EventHandler(this.text_find_name_Enter);
            // 
            // btn_reset
            // 
            this.btn_reset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_reset.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Location = new System.Drawing.Point(846, 126);
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
            this.btn_query.Location = new System.Drawing.Point(743, 126);
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
            this.lab_stop_text.Location = new System.Drawing.Point(461, 131);
            this.lab_stop_text.Name = "lab_stop_text";
            this.lab_stop_text.Size = new System.Drawing.Size(53, 12);
            this.lab_stop_text.TabIndex = 6;
            this.lab_stop_text.Text = "截止时间";
            // 
            // lab_start_text
            // 
            this.lab_start_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_start_text.AutoSize = true;
            this.lab_start_text.Location = new System.Drawing.Point(127, 131);
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
            this.com_find_type.Location = new System.Drawing.Point(186, 90);
            this.com_find_type.Name = "com_find_type";
            this.com_find_type.Size = new System.Drawing.Size(121, 20);
            this.com_find_type.TabIndex = 3;
            // 
            // lab_find_type
            // 
            this.lab_find_type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_find_type.AutoSize = true;
            this.lab_find_type.Location = new System.Drawing.Point(127, 93);
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
            this.Title.Location = new System.Drawing.Point(506, 30);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(76, 16);
            this.Title.TabIndex = 1;
            this.Title.Text = "清单查询";
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_storage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.data_storage.ColumnHeadersHeight = 40;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_storage.DefaultCellStyle = dataGridViewCellStyle6;
            this.data_storage.Location = new System.Drawing.Point(-8, 146);
            this.data_storage.MultiSelect = false;
            this.data_storage.Name = "data_storage";
            this.data_storage.ReadOnly = true;
            this.data_storage.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_storage.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.data_storage.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.data_storage.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.data_storage.RowTemplate.Height = 30;
            this.data_storage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_storage.Size = new System.Drawing.Size(1050, 437);
            this.data_storage.TabIndex = 2;
            // 
            // lab_find_name
            // 
            this.lab_find_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_find_name.AutoSize = true;
            this.lab_find_name.Location = new System.Drawing.Point(473, 93);
            this.lab_find_name.Name = "lab_find_name";
            this.lab_find_name.Size = new System.Drawing.Size(41, 12);
            this.lab_find_name.TabIndex = 9;
            this.lab_find_name.Text = "关键字";
            // 
            // com_type_id
            // 
            this.com_type_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.com_type_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_type_id.FormattingEnabled = true;
            this.com_type_id.Location = new System.Drawing.Point(800, 90);
            this.com_type_id.Name = "com_type_id";
            this.com_type_id.Size = new System.Drawing.Size(121, 20);
            this.com_type_id.TabIndex = 93;
            // 
            // lab_type_id
            // 
            this.lab_type_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_type_id.AutoSize = true;
            this.lab_type_id.Location = new System.Drawing.Point(741, 93);
            this.lab_type_id.Name = "lab_type_id";
            this.lab_type_id.Size = new System.Drawing.Size(53, 12);
            this.lab_type_id.TabIndex = 92;
            this.lab_type_id.Text = "操作方式";
            // 
            // BillFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 563);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.data_storage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BillFind";
            this.Text = "BillManage";
            this.Load += new System.EventHandler(this.BillManage_Load);
            this.Resize += new System.EventHandler(this.BillManage_Resize);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_storage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.DateTimePicker date_stop_time;
        private System.Windows.Forms.DateTimePicker date_start_time;
        private System.Windows.Forms.TextBox text_find_name;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.Label lab_stop_text;
        private System.Windows.Forms.Label lab_start_text;
        private System.Windows.Forms.ComboBox com_find_type;
        private System.Windows.Forms.Label lab_find_type;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.DataGridView data_storage;
        private System.Windows.Forms.Label lab_find_name;
        private System.Windows.Forms.ComboBox com_type_id;
        private System.Windows.Forms.Label lab_type_id;

    }
}