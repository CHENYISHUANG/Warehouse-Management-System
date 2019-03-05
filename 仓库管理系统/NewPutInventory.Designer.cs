namespace 仓库管理系统
{
    partial class NewPutInventory
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
            this.Tree_show_timer = new System.Windows.Forms.Timer(this.components);
            this.Tree_hide_timer = new System.Windows.Forms.Timer(this.components);
            this.Title = new System.Windows.Forms.Label();
            this.tree_label = new System.Windows.Forms.Label();
            this.Goodstypetree = new System.Windows.Forms.TreeView();
            this.lab_goods_type = new System.Windows.Forms.Label();
            this.btn_storage = new System.Windows.Forms.Button();
            this.text_bill_note = new System.Windows.Forms.TextBox();
            this.lab_bill_note = new System.Windows.Forms.Label();
            this.text_lot_number = new System.Windows.Forms.TextBox();
            this.lab_lot_number = new System.Windows.Forms.Label();
            this.com_type_id = new System.Windows.Forms.ComboBox();
            this.lab_type_id = new System.Windows.Forms.Label();
            this.lab_expiration_date = new System.Windows.Forms.Label();
            this.lab_manufacture_date = new System.Windows.Forms.Label();
            this.text_goods_price = new System.Windows.Forms.TextBox();
            this.lab_goods_price = new System.Windows.Forms.Label();
            this.text_goods_amount = new System.Windows.Forms.TextBox();
            this.lab_goods_amount = new System.Windows.Forms.Label();
            this.text_goods_note = new System.Windows.Forms.TextBox();
            this.lab_goods_note = new System.Windows.Forms.Label();
            this.text_goods_volume = new System.Windows.Forms.TextBox();
            this.lab_goods_volume = new System.Windows.Forms.Label();
            this.text_goods_wight = new System.Windows.Forms.TextBox();
            this.lab_goods_wight = new System.Windows.Forms.Label();
            this.text_specifications = new System.Windows.Forms.TextBox();
            this.lab_specifications = new System.Windows.Forms.Label();
            this.text_goods_code = new System.Windows.Forms.TextBox();
            this.lab_goods_code = new System.Windows.Forms.Label();
            this.comb_goods_name = new System.Windows.Forms.ComboBox();
            this.lab_goods_name = new System.Windows.Forms.Label();
            this.com_warehouse_id = new System.Windows.Forms.ComboBox();
            this.lab_warehouse_id = new System.Windows.Forms.Label();
            this.com_client_id = new System.Windows.Forms.ComboBox();
            this.lab_client_id = new System.Windows.Forms.Label();
            this.text_expiration_date = new System.Windows.Forms.MaskedTextBox();
            this.text_manufacture_date = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Tree_show_timer
            // 
            this.Tree_show_timer.Interval = 1;
            this.Tree_show_timer.Tick += new System.EventHandler(this.Tree_show_timer_Tick);
            // 
            // Tree_hide_timer
            // 
            this.Tree_hide_timer.Interval = 1;
            this.Tree_hide_timer.Tick += new System.EventHandler(this.Tree_hide_timer_Tick);
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
            this.Title.TabIndex = 93;
            this.Title.Text = "入 库 单";
            // 
            // tree_label
            // 
            this.tree_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tree_label.BackColor = System.Drawing.SystemColors.Window;
            this.tree_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tree_label.Location = new System.Drawing.Point(500, 118);
            this.tree_label.Name = "tree_label";
            this.tree_label.Size = new System.Drawing.Size(121, 20);
            this.tree_label.TabIndex = 67;
            this.tree_label.Text = "双击打开下一层";
            this.tree_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tree_label.Click += new System.EventHandler(this.tree_label_Click);
            // 
            // Goodstypetree
            // 
            this.Goodstypetree.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Goodstypetree.CheckBoxes = true;
            this.Goodstypetree.Location = new System.Drawing.Point(500, 118);
            this.Goodstypetree.Name = "Goodstypetree";
            this.Goodstypetree.ShowPlusMinus = false;
            this.Goodstypetree.Size = new System.Drawing.Size(121, 20);
            this.Goodstypetree.TabIndex = 66;
            this.Goodstypetree.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.Goodstypetree_AfterCheck);
            this.Goodstypetree.Enter += new System.EventHandler(this.Goodstypetree_Enter);
            // 
            // lab_goods_type
            // 
            this.lab_goods_type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_goods_type.AutoSize = true;
            this.lab_goods_type.Location = new System.Drawing.Point(435, 121);
            this.lab_goods_type.Name = "lab_goods_type";
            this.lab_goods_type.Size = new System.Drawing.Size(59, 12);
            this.lab_goods_type.TabIndex = 65;
            this.lab_goods_type.Text = "物品类型:";
            // 
            // btn_storage
            // 
            this.btn_storage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_storage.BackColor = System.Drawing.Color.White;
            this.btn_storage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_storage.Location = new System.Drawing.Point(438, 514);
            this.btn_storage.Name = "btn_storage";
            this.btn_storage.Size = new System.Drawing.Size(184, 35);
            this.btn_storage.TabIndex = 97;
            this.btn_storage.Text = "入 库";
            this.btn_storage.UseVisualStyleBackColor = false;
            this.btn_storage.Click += new System.EventHandler(this.btn_storage_Click_1);
            // 
            // text_bill_note
            // 
            this.text_bill_note.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_bill_note.Location = new System.Drawing.Point(800, 302);
            this.text_bill_note.Name = "text_bill_note";
            this.text_bill_note.Size = new System.Drawing.Size(121, 21);
            this.text_bill_note.TabIndex = 87;
            this.text_bill_note.WordWrap = false;
            // 
            // lab_bill_note
            // 
            this.lab_bill_note.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_bill_note.AutoSize = true;
            this.lab_bill_note.Location = new System.Drawing.Point(735, 305);
            this.lab_bill_note.Name = "lab_bill_note";
            this.lab_bill_note.Size = new System.Drawing.Size(59, 12);
            this.lab_bill_note.TabIndex = 90;
            this.lab_bill_note.Text = "入库备注:";
            // 
            // text_lot_number
            // 
            this.text_lot_number.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_lot_number.Location = new System.Drawing.Point(195, 441);
            this.text_lot_number.Name = "text_lot_number";
            this.text_lot_number.Size = new System.Drawing.Size(121, 21);
            this.text_lot_number.TabIndex = 95;
            this.text_lot_number.WordWrap = false;
            // 
            // lab_lot_number
            // 
            this.lab_lot_number.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_lot_number.AutoSize = true;
            this.lab_lot_number.Location = new System.Drawing.Point(130, 444);
            this.lab_lot_number.Name = "lab_lot_number";
            this.lab_lot_number.Size = new System.Drawing.Size(59, 12);
            this.lab_lot_number.TabIndex = 88;
            this.lab_lot_number.Text = "入库批号:";
            // 
            // com_type_id
            // 
            this.com_type_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.com_type_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_type_id.FormattingEnabled = true;
            this.com_type_id.Location = new System.Drawing.Point(501, 374);
            this.com_type_id.Name = "com_type_id";
            this.com_type_id.Size = new System.Drawing.Size(121, 20);
            this.com_type_id.TabIndex = 91;
            // 
            // lab_type_id
            // 
            this.lab_type_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_type_id.AutoSize = true;
            this.lab_type_id.Location = new System.Drawing.Point(436, 377);
            this.lab_type_id.Name = "lab_type_id";
            this.lab_type_id.Size = new System.Drawing.Size(59, 12);
            this.lab_type_id.TabIndex = 86;
            this.lab_type_id.Text = "入库方式:";
            // 
            // lab_expiration_date
            // 
            this.lab_expiration_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_expiration_date.AutoSize = true;
            this.lab_expiration_date.Location = new System.Drawing.Point(130, 305);
            this.lab_expiration_date.Name = "lab_expiration_date";
            this.lab_expiration_date.Size = new System.Drawing.Size(59, 12);
            this.lab_expiration_date.TabIndex = 84;
            this.lab_expiration_date.Text = "到期日期:";
            // 
            // lab_manufacture_date
            // 
            this.lab_manufacture_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_manufacture_date.AutoSize = true;
            this.lab_manufacture_date.Location = new System.Drawing.Point(735, 244);
            this.lab_manufacture_date.Name = "lab_manufacture_date";
            this.lab_manufacture_date.Size = new System.Drawing.Size(59, 12);
            this.lab_manufacture_date.TabIndex = 82;
            this.lab_manufacture_date.Text = "生产日期:";
            // 
            // text_goods_price
            // 
            this.text_goods_price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_goods_price.Location = new System.Drawing.Point(500, 241);
            this.text_goods_price.MaxLength = 9;
            this.text_goods_price.Name = "text_goods_price";
            this.text_goods_price.Size = new System.Drawing.Size(121, 21);
            this.text_goods_price.TabIndex = 79;
            this.text_goods_price.WordWrap = false;
            this.text_goods_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_goods_price_KeyPress);
            // 
            // lab_goods_price
            // 
            this.lab_goods_price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_goods_price.AutoSize = true;
            this.lab_goods_price.Location = new System.Drawing.Point(435, 244);
            this.lab_goods_price.Name = "lab_goods_price";
            this.lab_goods_price.Size = new System.Drawing.Size(59, 12);
            this.lab_goods_price.TabIndex = 80;
            this.lab_goods_price.Text = "物品单价:";
            // 
            // text_goods_amount
            // 
            this.text_goods_amount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_goods_amount.Location = new System.Drawing.Point(195, 241);
            this.text_goods_amount.MaxLength = 9;
            this.text_goods_amount.Name = "text_goods_amount";
            this.text_goods_amount.Size = new System.Drawing.Size(121, 21);
            this.text_goods_amount.TabIndex = 77;
            this.text_goods_amount.WordWrap = false;
            this.text_goods_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_goods_amount_KeyPress);
            // 
            // lab_goods_amount
            // 
            this.lab_goods_amount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_goods_amount.AutoSize = true;
            this.lab_goods_amount.Location = new System.Drawing.Point(130, 244);
            this.lab_goods_amount.Name = "lab_goods_amount";
            this.lab_goods_amount.Size = new System.Drawing.Size(59, 12);
            this.lab_goods_amount.TabIndex = 78;
            this.lab_goods_amount.Text = "物品数量:";
            // 
            // text_goods_note
            // 
            this.text_goods_note.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_goods_note.Location = new System.Drawing.Point(500, 305);
            this.text_goods_note.Name = "text_goods_note";
            this.text_goods_note.Size = new System.Drawing.Size(121, 21);
            this.text_goods_note.TabIndex = 85;
            this.text_goods_note.WordWrap = false;
            // 
            // lab_goods_note
            // 
            this.lab_goods_note.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_goods_note.AutoSize = true;
            this.lab_goods_note.Location = new System.Drawing.Point(435, 308);
            this.lab_goods_note.Name = "lab_goods_note";
            this.lab_goods_note.Size = new System.Drawing.Size(59, 12);
            this.lab_goods_note.TabIndex = 76;
            this.lab_goods_note.Text = "物品备注:";
            // 
            // text_goods_volume
            // 
            this.text_goods_volume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_goods_volume.Location = new System.Drawing.Point(500, 179);
            this.text_goods_volume.MaxLength = 9;
            this.text_goods_volume.Name = "text_goods_volume";
            this.text_goods_volume.Size = new System.Drawing.Size(121, 21);
            this.text_goods_volume.TabIndex = 73;
            this.text_goods_volume.WordWrap = false;
            this.text_goods_volume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_goods_volume_KeyPress);
            // 
            // lab_goods_volume
            // 
            this.lab_goods_volume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_goods_volume.AutoSize = true;
            this.lab_goods_volume.Location = new System.Drawing.Point(412, 182);
            this.lab_goods_volume.Name = "lab_goods_volume";
            this.lab_goods_volume.Size = new System.Drawing.Size(83, 12);
            this.lab_goods_volume.TabIndex = 74;
            this.lab_goods_volume.Text = "物品体积(cm):";
            // 
            // text_goods_wight
            // 
            this.text_goods_wight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_goods_wight.Location = new System.Drawing.Point(800, 179);
            this.text_goods_wight.MaxLength = 9;
            this.text_goods_wight.Name = "text_goods_wight";
            this.text_goods_wight.Size = new System.Drawing.Size(121, 21);
            this.text_goods_wight.TabIndex = 75;
            this.text_goods_wight.WordWrap = false;
            this.text_goods_wight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_goods_wight_KeyPress);
            // 
            // lab_goods_wight
            // 
            this.lab_goods_wight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_goods_wight.AutoSize = true;
            this.lab_goods_wight.Location = new System.Drawing.Point(711, 182);
            this.lab_goods_wight.Name = "lab_goods_wight";
            this.lab_goods_wight.Size = new System.Drawing.Size(83, 12);
            this.lab_goods_wight.TabIndex = 72;
            this.lab_goods_wight.Text = "物品重量(kg):";
            // 
            // text_specifications
            // 
            this.text_specifications.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_specifications.Location = new System.Drawing.Point(195, 179);
            this.text_specifications.Name = "text_specifications";
            this.text_specifications.Size = new System.Drawing.Size(121, 21);
            this.text_specifications.TabIndex = 71;
            this.text_specifications.WordWrap = false;
            // 
            // lab_specifications
            // 
            this.lab_specifications.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_specifications.AutoSize = true;
            this.lab_specifications.Location = new System.Drawing.Point(130, 182);
            this.lab_specifications.Name = "lab_specifications";
            this.lab_specifications.Size = new System.Drawing.Size(59, 12);
            this.lab_specifications.TabIndex = 70;
            this.lab_specifications.Text = "物品规格:";
            // 
            // text_goods_code
            // 
            this.text_goods_code.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_goods_code.Location = new System.Drawing.Point(800, 119);
            this.text_goods_code.Name = "text_goods_code";
            this.text_goods_code.Size = new System.Drawing.Size(121, 21);
            this.text_goods_code.TabIndex = 69;
            this.text_goods_code.WordWrap = false;
            // 
            // lab_goods_code
            // 
            this.lab_goods_code.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_goods_code.AutoSize = true;
            this.lab_goods_code.Location = new System.Drawing.Point(735, 122);
            this.lab_goods_code.Name = "lab_goods_code";
            this.lab_goods_code.Size = new System.Drawing.Size(59, 12);
            this.lab_goods_code.TabIndex = 68;
            this.lab_goods_code.Text = "物品代码:";
            // 
            // comb_goods_name
            // 
            this.comb_goods_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comb_goods_name.Location = new System.Drawing.Point(195, 119);
            this.comb_goods_name.Name = "comb_goods_name";
            this.comb_goods_name.Size = new System.Drawing.Size(121, 20);
            this.comb_goods_name.TabIndex = 64;
            this.comb_goods_name.SelectionChangeCommitted += new System.EventHandler(this.comb_goods_name_SelectionChangeCommitted);
            this.comb_goods_name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comb_goods_name_KeyUp);
            // 
            // lab_goods_name
            // 
            this.lab_goods_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_goods_name.AutoSize = true;
            this.lab_goods_name.Location = new System.Drawing.Point(130, 122);
            this.lab_goods_name.Name = "lab_goods_name";
            this.lab_goods_name.Size = new System.Drawing.Size(59, 12);
            this.lab_goods_name.TabIndex = 63;
            this.lab_goods_name.Text = "物 品 名:";
            // 
            // com_warehouse_id
            // 
            this.com_warehouse_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.com_warehouse_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_warehouse_id.FormattingEnabled = true;
            this.com_warehouse_id.Location = new System.Drawing.Point(800, 374);
            this.com_warehouse_id.Name = "com_warehouse_id";
            this.com_warehouse_id.Size = new System.Drawing.Size(121, 20);
            this.com_warehouse_id.TabIndex = 93;
            // 
            // lab_warehouse_id
            // 
            this.lab_warehouse_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_warehouse_id.AutoSize = true;
            this.lab_warehouse_id.Location = new System.Drawing.Point(735, 377);
            this.lab_warehouse_id.Name = "lab_warehouse_id";
            this.lab_warehouse_id.Size = new System.Drawing.Size(53, 12);
            this.lab_warehouse_id.TabIndex = 94;
            this.lab_warehouse_id.Text = "选择仓库";
            // 
            // com_client_id
            // 
            this.com_client_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.com_client_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_client_id.FormattingEnabled = true;
            this.com_client_id.Location = new System.Drawing.Point(195, 374);
            this.com_client_id.Name = "com_client_id";
            this.com_client_id.Size = new System.Drawing.Size(121, 20);
            this.com_client_id.TabIndex = 89;
            // 
            // lab_client_id
            // 
            this.lab_client_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_client_id.AutoSize = true;
            this.lab_client_id.Location = new System.Drawing.Point(130, 377);
            this.lab_client_id.Name = "lab_client_id";
            this.lab_client_id.Size = new System.Drawing.Size(59, 12);
            this.lab_client_id.TabIndex = 96;
            this.lab_client_id.Text = "选择客户:";
            // 
            // text_expiration_date
            // 
            this.text_expiration_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_expiration_date.Location = new System.Drawing.Point(195, 302);
            this.text_expiration_date.Mask = "0000-00-00";
            this.text_expiration_date.Name = "text_expiration_date";
            this.text_expiration_date.PromptChar = ' ';
            this.text_expiration_date.RejectInputOnFirstFailure = true;
            this.text_expiration_date.ResetOnSpace = false;
            this.text_expiration_date.Size = new System.Drawing.Size(121, 21);
            this.text_expiration_date.TabIndex = 83;
            this.text_expiration_date.MouseClick += new System.Windows.Forms.MouseEventHandler(this.text_expiration_date_MouseClick);
            // 
            // text_manufacture_date
            // 
            this.text_manufacture_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_manufacture_date.Location = new System.Drawing.Point(800, 241);
            this.text_manufacture_date.Mask = "0000-00-00";
            this.text_manufacture_date.Name = "text_manufacture_date";
            this.text_manufacture_date.PromptChar = ' ';
            this.text_manufacture_date.RejectInputOnFirstFailure = true;
            this.text_manufacture_date.ResetOnSpace = false;
            this.text_manufacture_date.Size = new System.Drawing.Size(121, 21);
            this.text_manufacture_date.TabIndex = 81;
            this.text_manufacture_date.MouseClick += new System.Windows.Forms.MouseEventHandler(this.text_manufacture_date_MouseClick);
            // 
            // NewPutInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1050, 602);
            this.Controls.Add(this.text_manufacture_date);
            this.Controls.Add(this.text_expiration_date);
            this.Controls.Add(this.com_client_id);
            this.Controls.Add(this.lab_client_id);
            this.Controls.Add(this.com_warehouse_id);
            this.Controls.Add(this.lab_warehouse_id);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.tree_label);
            this.Controls.Add(this.Goodstypetree);
            this.Controls.Add(this.lab_goods_type);
            this.Controls.Add(this.btn_storage);
            this.Controls.Add(this.text_bill_note);
            this.Controls.Add(this.lab_bill_note);
            this.Controls.Add(this.text_lot_number);
            this.Controls.Add(this.lab_lot_number);
            this.Controls.Add(this.com_type_id);
            this.Controls.Add(this.lab_type_id);
            this.Controls.Add(this.lab_expiration_date);
            this.Controls.Add(this.lab_manufacture_date);
            this.Controls.Add(this.text_goods_price);
            this.Controls.Add(this.lab_goods_price);
            this.Controls.Add(this.text_goods_amount);
            this.Controls.Add(this.lab_goods_amount);
            this.Controls.Add(this.text_goods_note);
            this.Controls.Add(this.lab_goods_note);
            this.Controls.Add(this.text_goods_volume);
            this.Controls.Add(this.lab_goods_volume);
            this.Controls.Add(this.text_goods_wight);
            this.Controls.Add(this.lab_goods_wight);
            this.Controls.Add(this.text_specifications);
            this.Controls.Add(this.lab_specifications);
            this.Controls.Add(this.text_goods_code);
            this.Controls.Add(this.lab_goods_code);
            this.Controls.Add(this.comb_goods_name);
            this.Controls.Add(this.lab_goods_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewPutInventory";
            this.Text = "NewPutInventory";
            this.Load += new System.EventHandler(this.NewPutInventory_Load);
            this.Click += new System.EventHandler(this.NewPutInventory_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Tree_show_timer;
        private System.Windows.Forms.Timer Tree_hide_timer;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label tree_label;
        private System.Windows.Forms.TreeView Goodstypetree;
        private System.Windows.Forms.Label lab_goods_type;
        private System.Windows.Forms.Button btn_storage;
        private System.Windows.Forms.TextBox text_bill_note;
        private System.Windows.Forms.Label lab_bill_note;
        private System.Windows.Forms.TextBox text_lot_number;
        private System.Windows.Forms.Label lab_lot_number;
        private System.Windows.Forms.ComboBox com_type_id;
        private System.Windows.Forms.Label lab_type_id;
        private System.Windows.Forms.Label lab_expiration_date;
        private System.Windows.Forms.Label lab_manufacture_date;
        private System.Windows.Forms.TextBox text_goods_price;
        private System.Windows.Forms.Label lab_goods_price;
        private System.Windows.Forms.TextBox text_goods_amount;
        private System.Windows.Forms.Label lab_goods_amount;
        private System.Windows.Forms.TextBox text_goods_note;
        private System.Windows.Forms.Label lab_goods_note;
        private System.Windows.Forms.TextBox text_goods_volume;
        private System.Windows.Forms.Label lab_goods_volume;
        private System.Windows.Forms.TextBox text_goods_wight;
        private System.Windows.Forms.Label lab_goods_wight;
        private System.Windows.Forms.TextBox text_specifications;
        private System.Windows.Forms.Label lab_specifications;
        private System.Windows.Forms.TextBox text_goods_code;
        private System.Windows.Forms.Label lab_goods_code;
        private System.Windows.Forms.ComboBox comb_goods_name;
        private System.Windows.Forms.Label lab_goods_name;
        private System.Windows.Forms.ComboBox com_warehouse_id;
        private System.Windows.Forms.Label lab_warehouse_id;
        private System.Windows.Forms.ComboBox com_client_id;
        private System.Windows.Forms.Label lab_client_id;
        private System.Windows.Forms.MaskedTextBox text_expiration_date;
        private System.Windows.Forms.MaskedTextBox text_manufacture_date;
    }
}