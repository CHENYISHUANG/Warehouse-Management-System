namespace 仓库管理系统
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Minibtn = new System.Windows.Forms.Button();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.Closebtn = new System.Windows.Forms.Button();
            this.Passwordtext = new System.Windows.Forms.TextBox();
            this.Nametext = new System.Windows.Forms.TextBox();
            this.Passwordlable = new System.Windows.Forms.Label();
            this.Namelable = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.MoveTime = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.Minibtn);
            this.panel1.Controls.Add(this.Loginbtn);
            this.panel1.Controls.Add(this.Closebtn);
            this.panel1.Controls.Add(this.Passwordtext);
            this.panel1.Controls.Add(this.Nametext);
            this.panel1.Controls.Add(this.Passwordlable);
            this.panel1.Controls.Add(this.Namelable);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 298);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // Minibtn
            // 
            this.Minibtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Minibtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Minibtn.FlatAppearance.BorderSize = 0;
            this.Minibtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Minibtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Minibtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minibtn.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.Minibtn.Location = new System.Drawing.Point(513, 0);
            this.Minibtn.Name = "Minibtn";
            this.Minibtn.Size = new System.Drawing.Size(34, 34);
            this.Minibtn.TabIndex = 14;
            this.Minibtn.Text = "-";
            this.Minibtn.UseVisualStyleBackColor = false;
            this.Minibtn.Click += new System.EventHandler(this.Minibtn_Click);
            // 
            // Loginbtn
            // 
            this.Loginbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Loginbtn.Location = new System.Drawing.Point(259, 224);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(75, 33);
            this.Loginbtn.TabIndex = 13;
            this.Loginbtn.Text = "登 录";
            this.Loginbtn.UseVisualStyleBackColor = true;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // Closebtn
            // 
            this.Closebtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Closebtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Closebtn.FlatAppearance.BorderSize = 0;
            this.Closebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Closebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closebtn.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.Closebtn.Location = new System.Drawing.Point(544, 0);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(34, 34);
            this.Closebtn.TabIndex = 12;
            this.Closebtn.Text = "×";
            this.Closebtn.UseVisualStyleBackColor = false;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // Passwordtext
            // 
            this.Passwordtext.Location = new System.Drawing.Point(228, 149);
            this.Passwordtext.Name = "Passwordtext";
            this.Passwordtext.PasswordChar = '●';
            this.Passwordtext.Size = new System.Drawing.Size(201, 21);
            this.Passwordtext.TabIndex = 11;
            this.Passwordtext.Text = "123456";
            // 
            // Nametext
            // 
            this.Nametext.Location = new System.Drawing.Point(228, 93);
            this.Nametext.Name = "Nametext";
            this.Nametext.Size = new System.Drawing.Size(201, 21);
            this.Nametext.TabIndex = 10;
            this.Nametext.Text = "Admin";
            // 
            // Passwordlable
            // 
            this.Passwordlable.AutoSize = true;
            this.Passwordlable.Location = new System.Drawing.Point(147, 152);
            this.Passwordlable.Name = "Passwordlable";
            this.Passwordlable.Size = new System.Drawing.Size(53, 12);
            this.Passwordlable.TabIndex = 9;
            this.Passwordlable.Text = "密  码：";
            // 
            // Namelable
            // 
            this.Namelable.AutoSize = true;
            this.Namelable.Location = new System.Drawing.Point(147, 96);
            this.Namelable.Name = "Namelable";
            this.Namelable.Size = new System.Drawing.Size(53, 12);
            this.Namelable.TabIndex = 8;
            this.Namelable.Text = "用户名：";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Title.Location = new System.Drawing.Point(224, 25);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(135, 20);
            this.Title.TabIndex = 7;
            this.Title.Text = "仓管系统登陆";
            // 
            // MoveTime
            // 
            this.MoveTime.Interval = 10;
            this.MoveTime.Tick += new System.EventHandler(this.MoveTime_Tick);
            // 
            // Login
            // 
            this.AcceptButton = this.Loginbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(580, 300);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "仓库系统登录界面";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.Button Closebtn;
        private System.Windows.Forms.TextBox Passwordtext;
        private System.Windows.Forms.TextBox Nametext;
        private System.Windows.Forms.Label Passwordlable;
        private System.Windows.Forms.Label Namelable;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button Minibtn;
        private System.Windows.Forms.Timer MoveTime;

    }
}

