namespace 仓库管理系统
{
    partial class ManagerInfo
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
            this.panel_manage = new System.Windows.Forms.Panel();
            this.lab_prompt = new System.Windows.Forms.Label();
            this.text_manager_username = new System.Windows.Forms.TextBox();
            this.lab_manager_username = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.text_manager_passowrd = new System.Windows.Forms.TextBox();
            this.lab_manager_password = new System.Windows.Forms.Label();
            this.text_manager_name = new System.Windows.Forms.TextBox();
            this.lab_manager_name = new System.Windows.Forms.Label();
            this.com_manager_id = new System.Windows.Forms.ComboBox();
            this.lab_manager_id = new System.Windows.Forms.Label();
            this.panel_manage.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Title.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Title.Location = new System.Drawing.Point(492, 34);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(93, 16);
            this.Title.TabIndex = 2;
            this.Title.Text = "管理员信息";
            // 
            // panel_manage
            // 
            this.panel_manage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_manage.Controls.Add(this.lab_prompt);
            this.panel_manage.Controls.Add(this.text_manager_username);
            this.panel_manage.Controls.Add(this.lab_manager_username);
            this.panel_manage.Controls.Add(this.btn_delete);
            this.panel_manage.Controls.Add(this.btn_reset);
            this.panel_manage.Controls.Add(this.text_manager_passowrd);
            this.panel_manage.Controls.Add(this.lab_manager_password);
            this.panel_manage.Controls.Add(this.text_manager_name);
            this.panel_manage.Controls.Add(this.lab_manager_name);
            this.panel_manage.Controls.Add(this.com_manager_id);
            this.panel_manage.Controls.Add(this.lab_manager_id);
            this.panel_manage.Location = new System.Drawing.Point(163, 89);
            this.panel_manage.Name = "panel_manage";
            this.panel_manage.Size = new System.Drawing.Size(729, 462);
            this.panel_manage.TabIndex = 142;
            // 
            // lab_prompt
            // 
            this.lab_prompt.AutoSize = true;
            this.lab_prompt.Location = new System.Drawing.Point(470, 212);
            this.lab_prompt.Name = "lab_prompt";
            this.lab_prompt.Size = new System.Drawing.Size(0, 12);
            this.lab_prompt.TabIndex = 148;
            // 
            // text_manager_username
            // 
            this.text_manager_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_manager_username.Location = new System.Drawing.Point(332, 209);
            this.text_manager_username.MaxLength = 9;
            this.text_manager_username.Name = "text_manager_username";
            this.text_manager_username.Size = new System.Drawing.Size(121, 21);
            this.text_manager_username.TabIndex = 137;
            this.text_manager_username.WordWrap = false;
            this.text_manager_username.Leave += new System.EventHandler(this.text_manager_username_Leave);
            // 
            // lab_manager_username
            // 
            this.lab_manager_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_manager_username.AutoSize = true;
            this.lab_manager_username.Location = new System.Drawing.Point(243, 212);
            this.lab_manager_username.Name = "lab_manager_username";
            this.lab_manager_username.Size = new System.Drawing.Size(83, 12);
            this.lab_manager_username.TabIndex = 147;
            this.lab_manager_username.Text = "管理员用户名:";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(269, 365);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 139;
            this.btn_delete.Text = "删除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(378, 365);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 140;
            this.btn_reset.Text = "更改";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // text_manager_passowrd
            // 
            this.text_manager_passowrd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_manager_passowrd.Location = new System.Drawing.Point(332, 286);
            this.text_manager_passowrd.MaxLength = 9;
            this.text_manager_passowrd.Name = "text_manager_passowrd";
            this.text_manager_passowrd.Size = new System.Drawing.Size(121, 21);
            this.text_manager_passowrd.TabIndex = 138;
            this.text_manager_passowrd.WordWrap = false;
            // 
            // lab_manager_password
            // 
            this.lab_manager_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_manager_password.AutoSize = true;
            this.lab_manager_password.Location = new System.Drawing.Point(255, 289);
            this.lab_manager_password.Name = "lab_manager_password";
            this.lab_manager_password.Size = new System.Drawing.Size(71, 12);
            this.lab_manager_password.TabIndex = 141;
            this.lab_manager_password.Text = "管理员密码:";
            // 
            // text_manager_name
            // 
            this.text_manager_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_manager_name.Location = new System.Drawing.Point(332, 135);
            this.text_manager_name.MaxLength = 9;
            this.text_manager_name.Name = "text_manager_name";
            this.text_manager_name.Size = new System.Drawing.Size(121, 21);
            this.text_manager_name.TabIndex = 136;
            this.text_manager_name.WordWrap = false;
            // 
            // lab_manager_name
            // 
            this.lab_manager_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_manager_name.AutoSize = true;
            this.lab_manager_name.Location = new System.Drawing.Point(255, 138);
            this.lab_manager_name.Name = "lab_manager_name";
            this.lab_manager_name.Size = new System.Drawing.Size(71, 12);
            this.lab_manager_name.TabIndex = 139;
            this.lab_manager_name.Text = "管理员名称:";
            // 
            // com_manager_id
            // 
            this.com_manager_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.com_manager_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_manager_id.FormattingEnabled = true;
            this.com_manager_id.Location = new System.Drawing.Point(332, 62);
            this.com_manager_id.Name = "com_manager_id";
            this.com_manager_id.Size = new System.Drawing.Size(121, 20);
            this.com_manager_id.TabIndex = 135;
            this.com_manager_id.SelectionChangeCommitted += new System.EventHandler(this.com_manager_id_SelectionChangeCommitted);
            // 
            // lab_manager_id
            // 
            this.lab_manager_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_manager_id.AutoSize = true;
            this.lab_manager_id.Location = new System.Drawing.Point(255, 65);
            this.lab_manager_id.Name = "lab_manager_id";
            this.lab_manager_id.Size = new System.Drawing.Size(71, 12);
            this.lab_manager_id.TabIndex = 136;
            this.lab_manager_id.Text = "选择管理员:";
            // 
            // ManagerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 563);
            this.Controls.Add(this.panel_manage);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerInfo";
            this.Text = "ManagerInfo";
            this.Load += new System.EventHandler(this.ManagerInfo_Load);
            this.panel_manage.ResumeLayout(false);
            this.panel_manage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel panel_manage;
        private System.Windows.Forms.TextBox text_manager_username;
        private System.Windows.Forms.Label lab_manager_username;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TextBox text_manager_passowrd;
        private System.Windows.Forms.Label lab_manager_password;
        private System.Windows.Forms.TextBox text_manager_name;
        private System.Windows.Forms.Label lab_manager_name;
        private System.Windows.Forms.ComboBox com_manager_id;
        private System.Windows.Forms.Label lab_manager_id;
        private System.Windows.Forms.Label lab_prompt;
    }
}