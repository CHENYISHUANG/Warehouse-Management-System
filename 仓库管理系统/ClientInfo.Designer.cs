namespace 仓库管理系统
{
    partial class ClientInfo
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
            this.btn_reset = new System.Windows.Forms.Button();
            this.text_client_note = new System.Windows.Forms.TextBox();
            this.lab_client_note = new System.Windows.Forms.Label();
            this.text_client_position = new System.Windows.Forms.TextBox();
            this.lab_client_position = new System.Windows.Forms.Label();
            this.text_client_name = new System.Windows.Forms.TextBox();
            this.lab_client_name = new System.Windows.Forms.Label();
            this.com_client_id = new System.Windows.Forms.ComboBox();
            this.lab_client_id = new System.Windows.Forms.Label();
            this.panel_new = new System.Windows.Forms.Panel();
            this.panel_manage = new System.Windows.Forms.Panel();
            this.text_client_phone = new System.Windows.Forms.TextBox();
            this.lab_client_phone = new System.Windows.Forms.Label();
            this.text_client_contacts = new System.Windows.Forms.TextBox();
            this.lab_client_contacts = new System.Windows.Forms.Label();
            this.btn_manager = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.text_new_client_phone = new System.Windows.Forms.TextBox();
            this.lab_new_client_phone = new System.Windows.Forms.Label();
            this.text_new_client_contacts = new System.Windows.Forms.TextBox();
            this.lab_new_client_contacts = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.text_new_client_note = new System.Windows.Forms.TextBox();
            this.lab_new_note = new System.Windows.Forms.Label();
            this.text_new_client_position = new System.Windows.Forms.TextBox();
            this.lab_new_client_position = new System.Windows.Forms.Label();
            this.text_new_client_name = new System.Windows.Forms.TextBox();
            this.lab_new_text_client_name = new System.Windows.Forms.Label();
            this.panel_new.SuspendLayout();
            this.panel_manage.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(309, 357);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(121, 23);
            this.btn_reset.TabIndex = 141;
            this.btn_reset.Text = "修  改";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // text_client_note
            // 
            this.text_client_note.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_client_note.Location = new System.Drawing.Point(332, 294);
            this.text_client_note.MaxLength = 9;
            this.text_client_note.Name = "text_client_note";
            this.text_client_note.Size = new System.Drawing.Size(121, 21);
            this.text_client_note.TabIndex = 140;
            this.text_client_note.WordWrap = false;
            // 
            // lab_client_note
            // 
            this.lab_client_note.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_client_note.AutoSize = true;
            this.lab_client_note.Location = new System.Drawing.Point(267, 297);
            this.lab_client_note.Name = "lab_client_note";
            this.lab_client_note.Size = new System.Drawing.Size(59, 12);
            this.lab_client_note.TabIndex = 143;
            this.lab_client_note.Text = "仓库备注:";
            // 
            // text_client_position
            // 
            this.text_client_position.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_client_position.Location = new System.Drawing.Point(332, 244);
            this.text_client_position.MaxLength = 9;
            this.text_client_position.Name = "text_client_position";
            this.text_client_position.Size = new System.Drawing.Size(121, 21);
            this.text_client_position.TabIndex = 139;
            this.text_client_position.WordWrap = false;
            // 
            // lab_client_position
            // 
            this.lab_client_position.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_client_position.AutoSize = true;
            this.lab_client_position.Location = new System.Drawing.Point(267, 247);
            this.lab_client_position.Name = "lab_client_position";
            this.lab_client_position.Size = new System.Drawing.Size(59, 12);
            this.lab_client_position.TabIndex = 141;
            this.lab_client_position.Text = "仓库位置:";
            // 
            // text_client_name
            // 
            this.text_client_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_client_name.Location = new System.Drawing.Point(332, 90);
            this.text_client_name.MaxLength = 9;
            this.text_client_name.Name = "text_client_name";
            this.text_client_name.Size = new System.Drawing.Size(121, 21);
            this.text_client_name.TabIndex = 136;
            this.text_client_name.WordWrap = false;
            // 
            // lab_client_name
            // 
            this.lab_client_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_client_name.AutoSize = true;
            this.lab_client_name.Location = new System.Drawing.Point(267, 93);
            this.lab_client_name.Name = "lab_client_name";
            this.lab_client_name.Size = new System.Drawing.Size(59, 12);
            this.lab_client_name.TabIndex = 139;
            this.lab_client_name.Text = "客户名称:";
            // 
            // com_client_id
            // 
            this.com_client_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.com_client_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_client_id.FormattingEnabled = true;
            this.com_client_id.Location = new System.Drawing.Point(332, 34);
            this.com_client_id.Name = "com_client_id";
            this.com_client_id.Size = new System.Drawing.Size(121, 20);
            this.com_client_id.TabIndex = 135;
            this.com_client_id.SelectionChangeCommitted += new System.EventHandler(this.com_client_id_SelectionChangeCommitted);
            // 
            // lab_client_id
            // 
            this.lab_client_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_client_id.AutoSize = true;
            this.lab_client_id.Location = new System.Drawing.Point(267, 37);
            this.lab_client_id.Name = "lab_client_id";
            this.lab_client_id.Size = new System.Drawing.Size(59, 12);
            this.lab_client_id.TabIndex = 136;
            this.lab_client_id.Text = "选择客户:";
            // 
            // panel_new
            // 
            this.panel_new.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_new.Controls.Add(this.text_new_client_phone);
            this.panel_new.Controls.Add(this.lab_new_client_phone);
            this.panel_new.Controls.Add(this.text_new_client_contacts);
            this.panel_new.Controls.Add(this.lab_new_client_contacts);
            this.panel_new.Controls.Add(this.btn_ok);
            this.panel_new.Controls.Add(this.text_new_client_note);
            this.panel_new.Controls.Add(this.lab_new_note);
            this.panel_new.Controls.Add(this.text_new_client_position);
            this.panel_new.Controls.Add(this.lab_new_client_position);
            this.panel_new.Controls.Add(this.text_new_client_name);
            this.panel_new.Controls.Add(this.lab_new_text_client_name);
            this.panel_new.Location = new System.Drawing.Point(153, 119);
            this.panel_new.Name = "panel_new";
            this.panel_new.Size = new System.Drawing.Size(729, 406);
            this.panel_new.TabIndex = 147;
            this.panel_new.Visible = false;
            // 
            // panel_manage
            // 
            this.panel_manage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_manage.Controls.Add(this.text_client_phone);
            this.panel_manage.Controls.Add(this.lab_client_phone);
            this.panel_manage.Controls.Add(this.text_client_contacts);
            this.panel_manage.Controls.Add(this.lab_client_contacts);
            this.panel_manage.Controls.Add(this.btn_reset);
            this.panel_manage.Controls.Add(this.text_client_note);
            this.panel_manage.Controls.Add(this.lab_client_note);
            this.panel_manage.Controls.Add(this.text_client_position);
            this.panel_manage.Controls.Add(this.lab_client_position);
            this.panel_manage.Controls.Add(this.text_client_name);
            this.panel_manage.Controls.Add(this.lab_client_name);
            this.panel_manage.Controls.Add(this.com_client_id);
            this.panel_manage.Controls.Add(this.lab_client_id);
            this.panel_manage.Location = new System.Drawing.Point(153, 119);
            this.panel_manage.Name = "panel_manage";
            this.panel_manage.Size = new System.Drawing.Size(729, 406);
            this.panel_manage.TabIndex = 146;
            // 
            // text_client_phone
            // 
            this.text_client_phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_client_phone.Location = new System.Drawing.Point(332, 192);
            this.text_client_phone.MaxLength = 9;
            this.text_client_phone.Name = "text_client_phone";
            this.text_client_phone.Size = new System.Drawing.Size(121, 21);
            this.text_client_phone.TabIndex = 138;
            this.text_client_phone.WordWrap = false;
            // 
            // lab_client_phone
            // 
            this.lab_client_phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_client_phone.AutoSize = true;
            this.lab_client_phone.Location = new System.Drawing.Point(267, 195);
            this.lab_client_phone.Name = "lab_client_phone";
            this.lab_client_phone.Size = new System.Drawing.Size(59, 12);
            this.lab_client_phone.TabIndex = 149;
            this.lab_client_phone.Text = "联系电话:";
            // 
            // text_client_contacts
            // 
            this.text_client_contacts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_client_contacts.Location = new System.Drawing.Point(332, 143);
            this.text_client_contacts.MaxLength = 9;
            this.text_client_contacts.Name = "text_client_contacts";
            this.text_client_contacts.Size = new System.Drawing.Size(121, 21);
            this.text_client_contacts.TabIndex = 137;
            this.text_client_contacts.WordWrap = false;
            // 
            // lab_client_contacts
            // 
            this.lab_client_contacts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_client_contacts.AutoSize = true;
            this.lab_client_contacts.Location = new System.Drawing.Point(255, 146);
            this.lab_client_contacts.Name = "lab_client_contacts";
            this.lab_client_contacts.Size = new System.Drawing.Size(71, 12);
            this.lab_client_contacts.TabIndex = 147;
            this.lab_client_contacts.Text = "客户联系人:";
            // 
            // btn_manager
            // 
            this.btn_manager.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_manager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_manager.ForeColor = System.Drawing.Color.Chocolate;
            this.btn_manager.Location = new System.Drawing.Point(153, 91);
            this.btn_manager.Name = "btn_manager";
            this.btn_manager.Size = new System.Drawing.Size(198, 22);
            this.btn_manager.TabIndex = 133;
            this.btn_manager.Text = "客户管理";
            this.btn_manager.UseVisualStyleBackColor = true;
            this.btn_manager.Click += new System.EventHandler(this.btn_manager_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.ForeColor = System.Drawing.Color.Chocolate;
            this.btn_add.Location = new System.Drawing.Point(684, 91);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(198, 22);
            this.btn_add.TabIndex = 134;
            this.btn_add.Text = "添加客户";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Title.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Title.Location = new System.Drawing.Point(492, 18);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(74, 21);
            this.Title.TabIndex = 143;
            this.Title.Text = "客户信息";
            // 
            // text_new_client_phone
            // 
            this.text_new_client_phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_new_client_phone.Location = new System.Drawing.Point(343, 166);
            this.text_new_client_phone.MaxLength = 9;
            this.text_new_client_phone.Name = "text_new_client_phone";
            this.text_new_client_phone.Size = new System.Drawing.Size(121, 21);
            this.text_new_client_phone.TabIndex = 144;
            this.text_new_client_phone.WordWrap = false;
            // 
            // lab_new_client_phone
            // 
            this.lab_new_client_phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_new_client_phone.AutoSize = true;
            this.lab_new_client_phone.Location = new System.Drawing.Point(278, 169);
            this.lab_new_client_phone.Name = "lab_new_client_phone";
            this.lab_new_client_phone.Size = new System.Drawing.Size(59, 12);
            this.lab_new_client_phone.TabIndex = 162;
            this.lab_new_client_phone.Text = "联系电话:";
            // 
            // text_new_client_contacts
            // 
            this.text_new_client_contacts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_new_client_contacts.Location = new System.Drawing.Point(343, 105);
            this.text_new_client_contacts.MaxLength = 9;
            this.text_new_client_contacts.Name = "text_new_client_contacts";
            this.text_new_client_contacts.Size = new System.Drawing.Size(121, 21);
            this.text_new_client_contacts.TabIndex = 143;
            this.text_new_client_contacts.WordWrap = false;
            // 
            // lab_new_client_contacts
            // 
            this.lab_new_client_contacts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_new_client_contacts.AutoSize = true;
            this.lab_new_client_contacts.Location = new System.Drawing.Point(266, 108);
            this.lab_new_client_contacts.Name = "lab_new_client_contacts";
            this.lab_new_client_contacts.Size = new System.Drawing.Size(71, 12);
            this.lab_new_client_contacts.TabIndex = 160;
            this.lab_new_client_contacts.Text = "客户联系人:";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(319, 358);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(121, 32);
            this.btn_ok.TabIndex = 147;
            this.btn_ok.Text = "添   加";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // text_new_client_note
            // 
            this.text_new_client_note.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_new_client_note.Location = new System.Drawing.Point(343, 289);
            this.text_new_client_note.MaxLength = 9;
            this.text_new_client_note.Name = "text_new_client_note";
            this.text_new_client_note.Size = new System.Drawing.Size(121, 21);
            this.text_new_client_note.TabIndex = 146;
            this.text_new_client_note.WordWrap = false;
            // 
            // lab_new_note
            // 
            this.lab_new_note.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_new_note.AutoSize = true;
            this.lab_new_note.Location = new System.Drawing.Point(278, 292);
            this.lab_new_note.Name = "lab_new_note";
            this.lab_new_note.Size = new System.Drawing.Size(59, 12);
            this.lab_new_note.TabIndex = 157;
            this.lab_new_note.Text = "客户备注:";
            // 
            // text_new_client_position
            // 
            this.text_new_client_position.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_new_client_position.Location = new System.Drawing.Point(343, 224);
            this.text_new_client_position.MaxLength = 9;
            this.text_new_client_position.Name = "text_new_client_position";
            this.text_new_client_position.Size = new System.Drawing.Size(121, 21);
            this.text_new_client_position.TabIndex = 145;
            this.text_new_client_position.WordWrap = false;
            // 
            // lab_new_client_position
            // 
            this.lab_new_client_position.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_new_client_position.AutoSize = true;
            this.lab_new_client_position.Location = new System.Drawing.Point(278, 227);
            this.lab_new_client_position.Name = "lab_new_client_position";
            this.lab_new_client_position.Size = new System.Drawing.Size(59, 12);
            this.lab_new_client_position.TabIndex = 155;
            this.lab_new_client_position.Text = "客户地址:";
            // 
            // text_new_client_name
            // 
            this.text_new_client_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_new_client_name.Location = new System.Drawing.Point(343, 43);
            this.text_new_client_name.MaxLength = 9;
            this.text_new_client_name.Name = "text_new_client_name";
            this.text_new_client_name.Size = new System.Drawing.Size(121, 21);
            this.text_new_client_name.TabIndex = 142;
            this.text_new_client_name.WordWrap = false;
            // 
            // lab_new_text_client_name
            // 
            this.lab_new_text_client_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_new_text_client_name.AutoSize = true;
            this.lab_new_text_client_name.Location = new System.Drawing.Point(278, 46);
            this.lab_new_text_client_name.Name = "lab_new_text_client_name";
            this.lab_new_text_client_name.Size = new System.Drawing.Size(59, 12);
            this.lab_new_text_client_name.TabIndex = 153;
            this.lab_new_text_client_name.Text = "客户名称:";
            // 
            // ClientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 543);
            this.Controls.Add(this.panel_new);
            this.Controls.Add(this.panel_manage);
            this.Controls.Add(this.btn_manager);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientInfo";
            this.Text = "ClientInfo";
            this.Load += new System.EventHandler(this.ClientInfo_Load);
            this.panel_new.ResumeLayout(false);
            this.panel_new.PerformLayout();
            this.panel_manage.ResumeLayout(false);
            this.panel_manage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TextBox text_client_note;
        private System.Windows.Forms.Label lab_client_note;
        private System.Windows.Forms.TextBox text_client_position;
        private System.Windows.Forms.Label lab_client_position;
        private System.Windows.Forms.TextBox text_client_name;
        private System.Windows.Forms.Label lab_client_name;
        private System.Windows.Forms.ComboBox com_client_id;
        private System.Windows.Forms.Label lab_client_id;
        private System.Windows.Forms.Panel panel_new;
        private System.Windows.Forms.Panel panel_manage;
        private System.Windows.Forms.Button btn_manager;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox text_client_contacts;
        private System.Windows.Forms.Label lab_client_contacts;
        private System.Windows.Forms.TextBox text_client_phone;
        private System.Windows.Forms.Label lab_client_phone;
        private System.Windows.Forms.TextBox text_new_client_phone;
        private System.Windows.Forms.Label lab_new_client_phone;
        private System.Windows.Forms.TextBox text_new_client_contacts;
        private System.Windows.Forms.Label lab_new_client_contacts;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.TextBox text_new_client_note;
        private System.Windows.Forms.Label lab_new_note;
        private System.Windows.Forms.TextBox text_new_client_position;
        private System.Windows.Forms.Label lab_new_client_position;
        private System.Windows.Forms.TextBox text_new_client_name;
        private System.Windows.Forms.Label lab_new_text_client_name;
    }
}