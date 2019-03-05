namespace 仓库管理系统
{
    partial class NewManager
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
            this.text_manager_username = new System.Windows.Forms.TextBox();
            this.lab_manager_username = new System.Windows.Forms.Label();
            this.text_manager_passowrd = new System.Windows.Forms.TextBox();
            this.lab_manager_password = new System.Windows.Forms.Label();
            this.text_manager_name = new System.Windows.Forms.TextBox();
            this.lab_manager_name = new System.Windows.Forms.Label();
            this.btn_new_ok = new System.Windows.Forms.Button();
            this.text_manager_passowrd2 = new System.Windows.Forms.TextBox();
            this.lab_manager_password2 = new System.Windows.Forms.Label();
            this.lab_prompt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Title.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Title.Location = new System.Drawing.Point(491, 45);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(93, 16);
            this.Title.TabIndex = 3;
            this.Title.Text = "新建管理员";
            // 
            // text_manager_username
            // 
            this.text_manager_username.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_manager_username.Location = new System.Drawing.Point(494, 204);
            this.text_manager_username.MaxLength = 9;
            this.text_manager_username.Name = "text_manager_username";
            this.text_manager_username.Size = new System.Drawing.Size(121, 21);
            this.text_manager_username.TabIndex = 149;
            this.text_manager_username.WordWrap = false;
            this.text_manager_username.Leave += new System.EventHandler(this.text_manager_username_Leave);
            // 
            // lab_manager_username
            // 
            this.lab_manager_username.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lab_manager_username.AutoSize = true;
            this.lab_manager_username.Location = new System.Drawing.Point(405, 207);
            this.lab_manager_username.Name = "lab_manager_username";
            this.lab_manager_username.Size = new System.Drawing.Size(83, 12);
            this.lab_manager_username.TabIndex = 153;
            this.lab_manager_username.Text = "管理员用户名:";
            // 
            // text_manager_passowrd
            // 
            this.text_manager_passowrd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_manager_passowrd.Location = new System.Drawing.Point(494, 281);
            this.text_manager_passowrd.MaxLength = 9;
            this.text_manager_passowrd.Name = "text_manager_passowrd";
            this.text_manager_passowrd.Size = new System.Drawing.Size(121, 21);
            this.text_manager_passowrd.TabIndex = 150;
            this.text_manager_passowrd.WordWrap = false;
            // 
            // lab_manager_password
            // 
            this.lab_manager_password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lab_manager_password.AutoSize = true;
            this.lab_manager_password.Location = new System.Drawing.Point(417, 284);
            this.lab_manager_password.Name = "lab_manager_password";
            this.lab_manager_password.Size = new System.Drawing.Size(71, 12);
            this.lab_manager_password.TabIndex = 151;
            this.lab_manager_password.Text = "管理员密码:";
            // 
            // text_manager_name
            // 
            this.text_manager_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_manager_name.Location = new System.Drawing.Point(494, 130);
            this.text_manager_name.MaxLength = 9;
            this.text_manager_name.Name = "text_manager_name";
            this.text_manager_name.Size = new System.Drawing.Size(121, 21);
            this.text_manager_name.TabIndex = 148;
            this.text_manager_name.WordWrap = false;
            // 
            // lab_manager_name
            // 
            this.lab_manager_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lab_manager_name.AutoSize = true;
            this.lab_manager_name.Location = new System.Drawing.Point(417, 133);
            this.lab_manager_name.Name = "lab_manager_name";
            this.lab_manager_name.Size = new System.Drawing.Size(71, 12);
            this.lab_manager_name.TabIndex = 149;
            this.lab_manager_name.Text = "管理员名称:";
            // 
            // btn_new_ok
            // 
            this.btn_new_ok.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_new_ok.Location = new System.Drawing.Point(431, 435);
            this.btn_new_ok.Name = "btn_new_ok";
            this.btn_new_ok.Size = new System.Drawing.Size(184, 32);
            this.btn_new_ok.TabIndex = 152;
            this.btn_new_ok.Text = "确定";
            this.btn_new_ok.UseVisualStyleBackColor = true;
            this.btn_new_ok.Click += new System.EventHandler(this.btn_new_ok_Click);
            // 
            // text_manager_passowrd2
            // 
            this.text_manager_passowrd2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_manager_passowrd2.Location = new System.Drawing.Point(494, 358);
            this.text_manager_passowrd2.MaxLength = 9;
            this.text_manager_passowrd2.Name = "text_manager_passowrd2";
            this.text_manager_passowrd2.Size = new System.Drawing.Size(121, 21);
            this.text_manager_passowrd2.TabIndex = 151;
            this.text_manager_passowrd2.WordWrap = false;
            // 
            // lab_manager_password2
            // 
            this.lab_manager_password2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lab_manager_password2.AutoSize = true;
            this.lab_manager_password2.Location = new System.Drawing.Point(429, 361);
            this.lab_manager_password2.Name = "lab_manager_password2";
            this.lab_manager_password2.Size = new System.Drawing.Size(59, 12);
            this.lab_manager_password2.TabIndex = 156;
            this.lab_manager_password2.Text = "重复密码:";
            // 
            // lab_prompt
            // 
            this.lab_prompt.AutoSize = true;
            this.lab_prompt.Location = new System.Drawing.Point(634, 207);
            this.lab_prompt.Name = "lab_prompt";
            this.lab_prompt.Size = new System.Drawing.Size(0, 12);
            this.lab_prompt.TabIndex = 157;
            // 
            // NewManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 524);
            this.Controls.Add(this.lab_prompt);
            this.Controls.Add(this.text_manager_passowrd2);
            this.Controls.Add(this.lab_manager_password2);
            this.Controls.Add(this.btn_new_ok);
            this.Controls.Add(this.text_manager_username);
            this.Controls.Add(this.lab_manager_username);
            this.Controls.Add(this.text_manager_passowrd);
            this.Controls.Add(this.lab_manager_password);
            this.Controls.Add(this.text_manager_name);
            this.Controls.Add(this.lab_manager_name);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewManager";
            this.Text = "NewManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox text_manager_username;
        private System.Windows.Forms.Label lab_manager_username;
        private System.Windows.Forms.TextBox text_manager_passowrd;
        private System.Windows.Forms.Label lab_manager_password;
        private System.Windows.Forms.TextBox text_manager_name;
        private System.Windows.Forms.Label lab_manager_name;
        private System.Windows.Forms.Button btn_new_ok;
        private System.Windows.Forms.TextBox text_manager_passowrd2;
        private System.Windows.Forms.Label lab_manager_password2;
        private System.Windows.Forms.Label lab_prompt;
    }
}