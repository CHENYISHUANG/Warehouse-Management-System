namespace 仓库管理系统
{
    partial class NewOutInventory
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.com_warehouse_id = new System.Windows.Forms.ComboBox();
            this.lab_warehouse_id = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.btn_storage = new System.Windows.Forms.Button();
            this.com_type_id = new System.Windows.Forms.ComboBox();
            this.lab_type_id = new System.Windows.Forms.Label();
            this.text_goods_amount = new System.Windows.Forms.TextBox();
            this.lab_goods_amount = new System.Windows.Forms.Label();
            this.Data_hide_timer = new System.Windows.Forms.Timer(this.components);
            this.Data_show_timer = new System.Windows.Forms.Timer(this.components);
            this.lab_goods_name = new System.Windows.Forms.Label();
            this.lab_lot_number = new System.Windows.Forms.Label();
            this.text_lot_number = new System.Windows.Forms.TextBox();
            this.lab_client_id = new System.Windows.Forms.Label();
            this.com_client_id = new System.Windows.Forms.ComboBox();
            this.lab_goods_price = new System.Windows.Forms.Label();
            this.text_goods_price = new System.Windows.Forms.TextBox();
            this.lab_bill_note = new System.Windows.Forms.Label();
            this.text_bill_note = new System.Windows.Forms.TextBox();
            this.labe_goods = new System.Windows.Forms.Label();
            this.data_storage = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_storage)).BeginInit();
            this.SuspendLayout();
            // 
            // com_warehouse_id
            // 
            this.com_warehouse_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.com_warehouse_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_warehouse_id.FormattingEnabled = true;
            this.com_warehouse_id.Location = new System.Drawing.Point(195, 119);
            this.com_warehouse_id.Name = "com_warehouse_id";
            this.com_warehouse_id.Size = new System.Drawing.Size(121, 20);
            this.com_warehouse_id.TabIndex = 128;
            this.com_warehouse_id.TextChanged += new System.EventHandler(this.com_warehouse_id_TextChanged);
            // 
            // lab_warehouse_id
            // 
            this.lab_warehouse_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_warehouse_id.AutoSize = true;
            this.lab_warehouse_id.Location = new System.Drawing.Point(130, 122);
            this.lab_warehouse_id.Name = "lab_warehouse_id";
            this.lab_warehouse_id.Size = new System.Drawing.Size(59, 12);
            this.lab_warehouse_id.TabIndex = 129;
            this.lab_warehouse_id.Text = "选择仓库:";
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Title.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Title.Location = new System.Drawing.Point(497, 53);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(68, 21);
            this.Title.TabIndex = 127;
            this.Title.Text = "出 库 单";
            // 
            // btn_storage
            // 
            this.btn_storage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_storage.BackColor = System.Drawing.Color.White;
            this.btn_storage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_storage.Location = new System.Drawing.Point(437, 494);
            this.btn_storage.Name = "btn_storage";
            this.btn_storage.Size = new System.Drawing.Size(184, 35);
            this.btn_storage.TabIndex = 132;
            this.btn_storage.Text = "出  库";
            this.btn_storage.UseVisualStyleBackColor = false;
            this.btn_storage.Click += new System.EventHandler(this.btn_storage_Click);
            // 
            // com_type_id
            // 
            this.com_type_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.com_type_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_type_id.FormattingEnabled = true;
            this.com_type_id.Location = new System.Drawing.Point(800, 119);
            this.com_type_id.Name = "com_type_id";
            this.com_type_id.Size = new System.Drawing.Size(121, 20);
            this.com_type_id.TabIndex = 126;
            // 
            // lab_type_id
            // 
            this.lab_type_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_type_id.AutoSize = true;
            this.lab_type_id.Location = new System.Drawing.Point(735, 122);
            this.lab_type_id.Name = "lab_type_id";
            this.lab_type_id.Size = new System.Drawing.Size(59, 12);
            this.lab_type_id.TabIndex = 121;
            this.lab_type_id.Text = "出库方式:";
            // 
            // text_goods_amount
            // 
            this.text_goods_amount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_goods_amount.Location = new System.Drawing.Point(195, 241);
            this.text_goods_amount.MaxLength = 9;
            this.text_goods_amount.Name = "text_goods_amount";
            this.text_goods_amount.Size = new System.Drawing.Size(121, 21);
            this.text_goods_amount.TabIndex = 112;
            this.text_goods_amount.WordWrap = false;
            // 
            // lab_goods_amount
            // 
            this.lab_goods_amount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_goods_amount.AutoSize = true;
            this.lab_goods_amount.Location = new System.Drawing.Point(130, 244);
            this.lab_goods_amount.Name = "lab_goods_amount";
            this.lab_goods_amount.Size = new System.Drawing.Size(59, 12);
            this.lab_goods_amount.TabIndex = 113;
            this.lab_goods_amount.Text = "物品数量:";
            // 
            // Data_hide_timer
            // 
            this.Data_hide_timer.Interval = 1;
            this.Data_hide_timer.Tick += new System.EventHandler(this.Date_hide_timer_Tick);
            // 
            // Data_show_timer
            // 
            this.Data_show_timer.Interval = 1;
            this.Data_show_timer.Tick += new System.EventHandler(this.Data_show_timer_Tick);
            // 
            // lab_goods_name
            // 
            this.lab_goods_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_goods_name.AutoSize = true;
            this.lab_goods_name.Location = new System.Drawing.Point(436, 122);
            this.lab_goods_name.Name = "lab_goods_name";
            this.lab_goods_name.Size = new System.Drawing.Size(59, 12);
            this.lab_goods_name.TabIndex = 98;
            this.lab_goods_name.Text = "选择物品:";
            // 
            // lab_lot_number
            // 
            this.lab_lot_number.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_lot_number.AutoSize = true;
            this.lab_lot_number.Location = new System.Drawing.Point(435, 362);
            this.lab_lot_number.Name = "lab_lot_number";
            this.lab_lot_number.Size = new System.Drawing.Size(59, 12);
            this.lab_lot_number.TabIndex = 123;
            this.lab_lot_number.Text = "出库批号:";
            // 
            // text_lot_number
            // 
            this.text_lot_number.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_lot_number.Location = new System.Drawing.Point(500, 359);
            this.text_lot_number.Name = "text_lot_number";
            this.text_lot_number.Size = new System.Drawing.Size(121, 21);
            this.text_lot_number.TabIndex = 130;
            this.text_lot_number.WordWrap = false;
            // 
            // lab_client_id
            // 
            this.lab_client_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_client_id.AutoSize = true;
            this.lab_client_id.Location = new System.Drawing.Point(735, 244);
            this.lab_client_id.Name = "lab_client_id";
            this.lab_client_id.Size = new System.Drawing.Size(59, 12);
            this.lab_client_id.TabIndex = 131;
            this.lab_client_id.Text = "选择客户:";
            // 
            // com_client_id
            // 
            this.com_client_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.com_client_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_client_id.FormattingEnabled = true;
            this.com_client_id.Location = new System.Drawing.Point(800, 241);
            this.com_client_id.Name = "com_client_id";
            this.com_client_id.Size = new System.Drawing.Size(121, 20);
            this.com_client_id.TabIndex = 124;
            // 
            // lab_goods_price
            // 
            this.lab_goods_price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_goods_price.AutoSize = true;
            this.lab_goods_price.Location = new System.Drawing.Point(435, 244);
            this.lab_goods_price.Name = "lab_goods_price";
            this.lab_goods_price.Size = new System.Drawing.Size(59, 12);
            this.lab_goods_price.TabIndex = 115;
            this.lab_goods_price.Text = "物品单价:";
            // 
            // text_goods_price
            // 
            this.text_goods_price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_goods_price.Location = new System.Drawing.Point(500, 241);
            this.text_goods_price.MaxLength = 9;
            this.text_goods_price.Name = "text_goods_price";
            this.text_goods_price.Size = new System.Drawing.Size(121, 21);
            this.text_goods_price.TabIndex = 114;
            this.text_goods_price.WordWrap = false;
            // 
            // lab_bill_note
            // 
            this.lab_bill_note.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_bill_note.AutoSize = true;
            this.lab_bill_note.Location = new System.Drawing.Point(130, 356);
            this.lab_bill_note.Name = "lab_bill_note";
            this.lab_bill_note.Size = new System.Drawing.Size(59, 12);
            this.lab_bill_note.TabIndex = 125;
            this.lab_bill_note.Text = "出库备注:";
            // 
            // text_bill_note
            // 
            this.text_bill_note.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_bill_note.Location = new System.Drawing.Point(195, 353);
            this.text_bill_note.Name = "text_bill_note";
            this.text_bill_note.Size = new System.Drawing.Size(121, 21);
            this.text_bill_note.TabIndex = 122;
            this.text_bill_note.WordWrap = false;
            // 
            // labe_goods
            // 
            this.labe_goods.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labe_goods.BackColor = System.Drawing.SystemColors.Window;
            this.labe_goods.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labe_goods.Location = new System.Drawing.Point(500, 118);
            this.labe_goods.Name = "labe_goods";
            this.labe_goods.Size = new System.Drawing.Size(121, 20);
            this.labe_goods.TabIndex = 133;
            this.labe_goods.Text = "双击选择物品";
            this.labe_goods.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labe_goods.Click += new System.EventHandler(this.labe_goods_Click);
            // 
            // data_storage
            // 
            this.data_storage.AllowUserToAddRows = false;
            this.data_storage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.data_storage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_storage.BackgroundColor = System.Drawing.Color.White;
            this.data_storage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_storage.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.data_storage.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_storage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.data_storage.ColumnHeadersHeight = 40;
            this.data_storage.Location = new System.Drawing.Point(-1, 139);
            this.data_storage.MultiSelect = false;
            this.data_storage.Name = "data_storage";
            this.data_storage.ReadOnly = true;
            this.data_storage.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_storage.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.data_storage.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.data_storage.RowTemplate.Height = 30;
            this.data_storage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_storage.Size = new System.Drawing.Size(1050, 0);
            this.data_storage.TabIndex = 134;
            this.data_storage.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.data_storage_CellMouseDoubleClick);
            // 
            // NewOutInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1050, 602);
            this.Controls.Add(this.data_storage);
            this.Controls.Add(this.labe_goods);
            this.Controls.Add(this.com_client_id);
            this.Controls.Add(this.lab_client_id);
            this.Controls.Add(this.com_warehouse_id);
            this.Controls.Add(this.lab_warehouse_id);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.btn_storage);
            this.Controls.Add(this.text_bill_note);
            this.Controls.Add(this.lab_bill_note);
            this.Controls.Add(this.text_lot_number);
            this.Controls.Add(this.lab_lot_number);
            this.Controls.Add(this.com_type_id);
            this.Controls.Add(this.lab_type_id);
            this.Controls.Add(this.text_goods_price);
            this.Controls.Add(this.lab_goods_price);
            this.Controls.Add(this.text_goods_amount);
            this.Controls.Add(this.lab_goods_amount);
            this.Controls.Add(this.lab_goods_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewOutInventory";
            this.Text = "NewOutInventory";
            this.Load += new System.EventHandler(this.NewOutInventory_Load);
            this.Click += new System.EventHandler(this.NewOutInventory_Click);
            this.Resize += new System.EventHandler(this.NewOutInventory_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.data_storage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox com_warehouse_id;
        private System.Windows.Forms.Label lab_warehouse_id;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button btn_storage;
        private System.Windows.Forms.ComboBox com_type_id;
        private System.Windows.Forms.Label lab_type_id;
        private System.Windows.Forms.TextBox text_goods_amount;
        private System.Windows.Forms.Label lab_goods_amount;
        private System.Windows.Forms.Timer Data_hide_timer;
        private System.Windows.Forms.Timer Data_show_timer;
        private System.Windows.Forms.Label lab_goods_name;
        private System.Windows.Forms.Label lab_lot_number;
        private System.Windows.Forms.TextBox text_lot_number;
        private System.Windows.Forms.Label lab_client_id;
        private System.Windows.Forms.ComboBox com_client_id;
        private System.Windows.Forms.Label lab_goods_price;
        private System.Windows.Forms.TextBox text_goods_price;
        private System.Windows.Forms.Label lab_bill_note;
        private System.Windows.Forms.TextBox text_bill_note;
        private System.Windows.Forms.Label labe_goods;
        private System.Windows.Forms.DataGridView data_storage;
    }
}