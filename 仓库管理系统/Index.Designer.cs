namespace 仓库管理系统
{
    partial class Index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.index_top = new System.Windows.Forms.Panel();
            this.Titile = new System.Windows.Forms.Label();
            this.Log_cancel = new System.Windows.Forms.Label();
            this.name_img = new System.Windows.Forms.PictureBox();
            this.Log_namelabel = new System.Windows.Forms.Label();
            this.Btn_max = new System.Windows.Forms.Button();
            this.Btn_mini = new System.Windows.Forms.Button();
            this.Btn_close = new System.Windows.Forms.Button();
            this.Index_movetimer = new System.Windows.Forms.Timer(this.components);
            this.Left_menu = new System.Windows.Forms.FlowLayoutPanel();
            this.left_btn_put = new System.Windows.Forms.Button();
            this.Left_menu_put = new System.Windows.Forms.FlowLayoutPanel();
            this.left_btn_put_1 = new System.Windows.Forms.Button();
            this.left_btn_put_2 = new System.Windows.Forms.Button();
            this.left_btn_out = new System.Windows.Forms.Button();
            this.left_menu_out = new System.Windows.Forms.FlowLayoutPanel();
            this.left_btn_out_1 = new System.Windows.Forms.Button();
            this.left_btn_out_2 = new System.Windows.Forms.Button();
            this.left_btn_stock = new System.Windows.Forms.Button();
            this.left_menu_stock = new System.Windows.Forms.FlowLayoutPanel();
            this.left_btn_stock_1 = new System.Windows.Forms.Button();
            this.left_btn_stock_2 = new System.Windows.Forms.Button();
            this.left_btn_stock_3 = new System.Windows.Forms.Button();
            this.left_btn_stock_4 = new System.Windows.Forms.Button();
            this.left_btn_manager = new System.Windows.Forms.Button();
            this.left_menu_manager = new System.Windows.Forms.FlowLayoutPanel();
            this.left_btn_manager_1 = new System.Windows.Forms.Button();
            this.left_btn_manager_2 = new System.Windows.Forms.Button();
            this.left_btn_backstage = new System.Windows.Forms.Button();
            this.left_menu_backstage = new System.Windows.Forms.FlowLayoutPanel();
            this.left_btn_backstage_1 = new System.Windows.Forms.Button();
            this.left_btn_backstage_2 = new System.Windows.Forms.Button();
            this.Left_menu_showtimer = new System.Windows.Forms.Timer(this.components);
            this.Left_menu_hidetimer = new System.Windows.Forms.Timer(this.components);
            this.initialization_timer = new System.Windows.Forms.Timer(this.components);
            this.body = new System.Windows.Forms.Panel();
            this.index_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.name_img)).BeginInit();
            this.Left_menu.SuspendLayout();
            this.Left_menu_put.SuspendLayout();
            this.left_menu_out.SuspendLayout();
            this.left_menu_stock.SuspendLayout();
            this.left_menu_manager.SuspendLayout();
            this.left_menu_backstage.SuspendLayout();
            this.SuspendLayout();
            // 
            // index_top
            // 
            this.index_top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.index_top.BackColor = System.Drawing.Color.LightGray;
            this.index_top.Controls.Add(this.Titile);
            this.index_top.Controls.Add(this.Log_cancel);
            this.index_top.Controls.Add(this.name_img);
            this.index_top.Controls.Add(this.Log_namelabel);
            this.index_top.Controls.Add(this.Btn_max);
            this.index_top.Controls.Add(this.Btn_mini);
            this.index_top.Controls.Add(this.Btn_close);
            this.index_top.Location = new System.Drawing.Point(0, 0);
            this.index_top.Name = "index_top";
            this.index_top.Size = new System.Drawing.Size(1280, 80);
            this.index_top.TabIndex = 0;
            this.index_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.index_top_MouseDown);
            this.index_top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.index_top_MouseUp);
            // 
            // Titile
            // 
            this.Titile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Titile.AutoSize = true;
            this.Titile.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Titile.Location = new System.Drawing.Point(589, 9);
            this.Titile.Name = "Titile";
            this.Titile.Size = new System.Drawing.Size(77, 12);
            this.Titile.TabIndex = 6;
            this.Titile.Text = "仓库管理系统";
            // 
            // Log_cancel
            // 
            this.Log_cancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Log_cancel.AutoSize = true;
            this.Log_cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Log_cancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Log_cancel.Location = new System.Drawing.Point(999, 33);
            this.Log_cancel.Name = "Log_cancel";
            this.Log_cancel.Size = new System.Drawing.Size(40, 17);
            this.Log_cancel.TabIndex = 5;
            this.Log_cancel.Text = "[注销]";
            this.Log_cancel.Click += new System.EventHandler(this.Log_cancel_Click);
            this.Log_cancel.MouseEnter += new System.EventHandler(this.Log_cancel_MouseEnter);
            this.Log_cancel.MouseLeave += new System.EventHandler(this.Log_cancel_MouseLeave);
            // 
            // name_img
            // 
            this.name_img.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.name_img.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("name_img.BackgroundImage")));
            this.name_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.name_img.Location = new System.Drawing.Point(841, 23);
            this.name_img.Name = "name_img";
            this.name_img.Size = new System.Drawing.Size(40, 40);
            this.name_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.name_img.TabIndex = 1;
            this.name_img.TabStop = false;
            // 
            // Log_namelabel
            // 
            this.Log_namelabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Log_namelabel.AutoSize = true;
            this.Log_namelabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Log_namelabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Log_namelabel.Location = new System.Drawing.Point(887, 33);
            this.Log_namelabel.Name = "Log_namelabel";
            this.Log_namelabel.Size = new System.Drawing.Size(0, 17);
            this.Log_namelabel.TabIndex = 4;
            // 
            // Btn_max
            // 
            this.Btn_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_max.BackColor = System.Drawing.Color.Transparent;
            this.Btn_max.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Btn_max.FlatAppearance.BorderSize = 0;
            this.Btn_max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_max.Font = new System.Drawing.Font("宋体", 20F);
            this.Btn_max.Location = new System.Drawing.Point(1180, 0);
            this.Btn_max.Name = "Btn_max";
            this.Btn_max.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Btn_max.Size = new System.Drawing.Size(50, 50);
            this.Btn_max.TabIndex = 3;
            this.Btn_max.Text = "□";
            this.Btn_max.UseVisualStyleBackColor = false;
            this.Btn_max.Click += new System.EventHandler(this.Btn_max_Click);
            // 
            // Btn_mini
            // 
            this.Btn_mini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_mini.BackColor = System.Drawing.Color.Transparent;
            this.Btn_mini.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Btn_mini.FlatAppearance.BorderSize = 0;
            this.Btn_mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_mini.Font = new System.Drawing.Font("微软雅黑 Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_mini.Location = new System.Drawing.Point(1130, 0);
            this.Btn_mini.Name = "Btn_mini";
            this.Btn_mini.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.Btn_mini.Size = new System.Drawing.Size(50, 50);
            this.Btn_mini.TabIndex = 2;
            this.Btn_mini.Text = "－";
            this.Btn_mini.UseVisualStyleBackColor = false;
            this.Btn_mini.Click += new System.EventHandler(this.Btn_mini_Click);
            // 
            // Btn_close
            // 
            this.Btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_close.BackColor = System.Drawing.Color.Transparent;
            this.Btn_close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Btn_close.FlatAppearance.BorderSize = 0;
            this.Btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_close.Font = new System.Drawing.Font("微软雅黑 Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_close.Location = new System.Drawing.Point(1230, 0);
            this.Btn_close.Name = "Btn_close";
            this.Btn_close.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.Btn_close.Size = new System.Drawing.Size(50, 50);
            this.Btn_close.TabIndex = 1;
            this.Btn_close.Text = "×";
            this.Btn_close.UseVisualStyleBackColor = false;
            this.Btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // Index_movetimer
            // 
            this.Index_movetimer.Interval = 10;
            this.Index_movetimer.Tick += new System.EventHandler(this.Index_movetimer_Tick);
            // 
            // Left_menu
            // 
            this.Left_menu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Left_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Left_menu.Controls.Add(this.left_btn_put);
            this.Left_menu.Controls.Add(this.Left_menu_put);
            this.Left_menu.Controls.Add(this.left_btn_out);
            this.Left_menu.Controls.Add(this.left_menu_out);
            this.Left_menu.Controls.Add(this.left_btn_stock);
            this.Left_menu.Controls.Add(this.left_menu_stock);
            this.Left_menu.Controls.Add(this.left_btn_manager);
            this.Left_menu.Controls.Add(this.left_menu_manager);
            this.Left_menu.Controls.Add(this.left_btn_backstage);
            this.Left_menu.Controls.Add(this.left_menu_backstage);
            this.Left_menu.Location = new System.Drawing.Point(0, 80);
            this.Left_menu.Margin = new System.Windows.Forms.Padding(0);
            this.Left_menu.Name = "Left_menu";
            this.Left_menu.Size = new System.Drawing.Size(230, 602);
            this.Left_menu.TabIndex = 8;
            // 
            // left_btn_put
            // 
            this.left_btn_put.FlatAppearance.BorderSize = 0;
            this.left_btn_put.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.left_btn_put.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.left_btn_put.ForeColor = System.Drawing.Color.DarkCyan;
            this.left_btn_put.Location = new System.Drawing.Point(0, 0);
            this.left_btn_put.Margin = new System.Windows.Forms.Padding(0);
            this.left_btn_put.Name = "left_btn_put";
            this.left_btn_put.Size = new System.Drawing.Size(230, 38);
            this.left_btn_put.TabIndex = 1;
            this.left_btn_put.Text = "入库管理";
            this.left_btn_put.UseVisualStyleBackColor = true;
            this.left_btn_put.Click += new System.EventHandler(this.left_menu_btn1_Click);
            // 
            // Left_menu_put
            // 
            this.Left_menu_put.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Left_menu_put.Controls.Add(this.left_btn_put_1);
            this.Left_menu_put.Controls.Add(this.left_btn_put_2);
            this.Left_menu_put.Location = new System.Drawing.Point(1, 38);
            this.Left_menu_put.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.Left_menu_put.Name = "Left_menu_put";
            this.Left_menu_put.Size = new System.Drawing.Size(228, 0);
            this.Left_menu_put.TabIndex = 0;
            // 
            // left_btn_put_1
            // 
            this.left_btn_put_1.FlatAppearance.BorderSize = 0;
            this.left_btn_put_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.left_btn_put_1.Font = new System.Drawing.Font("宋体", 9F);
            this.left_btn_put_1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.left_btn_put_1.Location = new System.Drawing.Point(0, 0);
            this.left_btn_put_1.Margin = new System.Windows.Forms.Padding(0);
            this.left_btn_put_1.Name = "left_btn_put_1";
            this.left_btn_put_1.Size = new System.Drawing.Size(227, 23);
            this.left_btn_put_1.TabIndex = 0;
            this.left_btn_put_1.Text = "入库记录";
            this.left_btn_put_1.UseVisualStyleBackColor = true;
            this.left_btn_put_1.Click += new System.EventHandler(this.left_btn_put_1_Click);
            // 
            // left_btn_put_2
            // 
            this.left_btn_put_2.FlatAppearance.BorderSize = 0;
            this.left_btn_put_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.left_btn_put_2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.left_btn_put_2.Location = new System.Drawing.Point(0, 23);
            this.left_btn_put_2.Margin = new System.Windows.Forms.Padding(0);
            this.left_btn_put_2.Name = "left_btn_put_2";
            this.left_btn_put_2.Size = new System.Drawing.Size(227, 23);
            this.left_btn_put_2.TabIndex = 1;
            this.left_btn_put_2.Text = "入库登记";
            this.left_btn_put_2.UseVisualStyleBackColor = true;
            this.left_btn_put_2.Click += new System.EventHandler(this.left_btn_put_2_Click);
            // 
            // left_btn_out
            // 
            this.left_btn_out.FlatAppearance.BorderSize = 0;
            this.left_btn_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.left_btn_out.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.left_btn_out.ForeColor = System.Drawing.Color.DarkCyan;
            this.left_btn_out.Location = new System.Drawing.Point(0, 38);
            this.left_btn_out.Margin = new System.Windows.Forms.Padding(0);
            this.left_btn_out.Name = "left_btn_out";
            this.left_btn_out.Size = new System.Drawing.Size(230, 46);
            this.left_btn_out.TabIndex = 2;
            this.left_btn_out.Text = "出库管理";
            this.left_btn_out.UseVisualStyleBackColor = true;
            this.left_btn_out.Click += new System.EventHandler(this.left_btn_out_Click);
            // 
            // left_menu_out
            // 
            this.left_menu_out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.left_menu_out.Controls.Add(this.left_btn_out_1);
            this.left_menu_out.Controls.Add(this.left_btn_out_2);
            this.left_menu_out.Location = new System.Drawing.Point(1, 84);
            this.left_menu_out.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.left_menu_out.Name = "left_menu_out";
            this.left_menu_out.Size = new System.Drawing.Size(228, 0);
            this.left_menu_out.TabIndex = 6;
            // 
            // left_btn_out_1
            // 
            this.left_btn_out_1.FlatAppearance.BorderSize = 0;
            this.left_btn_out_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.left_btn_out_1.Font = new System.Drawing.Font("宋体", 9F);
            this.left_btn_out_1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.left_btn_out_1.Location = new System.Drawing.Point(0, 0);
            this.left_btn_out_1.Margin = new System.Windows.Forms.Padding(0);
            this.left_btn_out_1.Name = "left_btn_out_1";
            this.left_btn_out_1.Size = new System.Drawing.Size(227, 23);
            this.left_btn_out_1.TabIndex = 0;
            this.left_btn_out_1.Text = "出库记录";
            this.left_btn_out_1.UseVisualStyleBackColor = true;
            this.left_btn_out_1.Click += new System.EventHandler(this.left_btn_out_1_Click);
            // 
            // left_btn_out_2
            // 
            this.left_btn_out_2.FlatAppearance.BorderSize = 0;
            this.left_btn_out_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.left_btn_out_2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.left_btn_out_2.Location = new System.Drawing.Point(0, 23);
            this.left_btn_out_2.Margin = new System.Windows.Forms.Padding(0);
            this.left_btn_out_2.Name = "left_btn_out_2";
            this.left_btn_out_2.Size = new System.Drawing.Size(227, 23);
            this.left_btn_out_2.TabIndex = 1;
            this.left_btn_out_2.Text = "出库登记";
            this.left_btn_out_2.UseVisualStyleBackColor = true;
            this.left_btn_out_2.Click += new System.EventHandler(this.left_btn_out_2_Click);
            // 
            // left_btn_stock
            // 
            this.left_btn_stock.FlatAppearance.BorderSize = 0;
            this.left_btn_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.left_btn_stock.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.left_btn_stock.ForeColor = System.Drawing.Color.DarkCyan;
            this.left_btn_stock.Location = new System.Drawing.Point(0, 84);
            this.left_btn_stock.Margin = new System.Windows.Forms.Padding(0);
            this.left_btn_stock.Name = "left_btn_stock";
            this.left_btn_stock.Size = new System.Drawing.Size(230, 46);
            this.left_btn_stock.TabIndex = 3;
            this.left_btn_stock.Text = "库存管理";
            this.left_btn_stock.UseVisualStyleBackColor = true;
            this.left_btn_stock.Click += new System.EventHandler(this.left_btn_stock_Click);
            // 
            // left_menu_stock
            // 
            this.left_menu_stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.left_menu_stock.Controls.Add(this.left_btn_stock_1);
            this.left_menu_stock.Controls.Add(this.left_btn_stock_2);
            this.left_menu_stock.Controls.Add(this.left_btn_stock_3);
            this.left_menu_stock.Controls.Add(this.left_btn_stock_4);
            this.left_menu_stock.Location = new System.Drawing.Point(1, 130);
            this.left_menu_stock.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.left_menu_stock.Name = "left_menu_stock";
            this.left_menu_stock.Size = new System.Drawing.Size(228, 0);
            this.left_menu_stock.TabIndex = 7;
            // 
            // left_btn_stock_1
            // 
            this.left_btn_stock_1.FlatAppearance.BorderSize = 0;
            this.left_btn_stock_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.left_btn_stock_1.Font = new System.Drawing.Font("宋体", 9F);
            this.left_btn_stock_1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.left_btn_stock_1.Location = new System.Drawing.Point(0, 0);
            this.left_btn_stock_1.Margin = new System.Windows.Forms.Padding(0);
            this.left_btn_stock_1.Name = "left_btn_stock_1";
            this.left_btn_stock_1.Size = new System.Drawing.Size(227, 23);
            this.left_btn_stock_1.TabIndex = 0;
            this.left_btn_stock_1.Text = "查看库存";
            this.left_btn_stock_1.UseVisualStyleBackColor = true;
            this.left_btn_stock_1.Click += new System.EventHandler(this.left_btn_stock_1_Click);
            // 
            // left_btn_stock_2
            // 
            this.left_btn_stock_2.FlatAppearance.BorderSize = 0;
            this.left_btn_stock_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.left_btn_stock_2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.left_btn_stock_2.Location = new System.Drawing.Point(0, 23);
            this.left_btn_stock_2.Margin = new System.Windows.Forms.Padding(0);
            this.left_btn_stock_2.Name = "left_btn_stock_2";
            this.left_btn_stock_2.Size = new System.Drawing.Size(227, 23);
            this.left_btn_stock_2.TabIndex = 2;
            this.left_btn_stock_2.Text = "仓库管理";
            this.left_btn_stock_2.UseVisualStyleBackColor = true;
            this.left_btn_stock_2.Click += new System.EventHandler(this.left_btn_stock_2_Click);
            // 
            // left_btn_stock_3
            // 
            this.left_btn_stock_3.FlatAppearance.BorderSize = 0;
            this.left_btn_stock_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.left_btn_stock_3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.left_btn_stock_3.Location = new System.Drawing.Point(0, 46);
            this.left_btn_stock_3.Margin = new System.Windows.Forms.Padding(0);
            this.left_btn_stock_3.Name = "left_btn_stock_3";
            this.left_btn_stock_3.Size = new System.Drawing.Size(227, 23);
            this.left_btn_stock_3.TabIndex = 3;
            this.left_btn_stock_3.Text = "货物转仓";
            this.left_btn_stock_3.UseVisualStyleBackColor = true;
            this.left_btn_stock_3.Click += new System.EventHandler(this.left_btn_stock_3_Click);
            // 
            // left_btn_stock_4
            // 
            this.left_btn_stock_4.FlatAppearance.BorderSize = 0;
            this.left_btn_stock_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.left_btn_stock_4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.left_btn_stock_4.Location = new System.Drawing.Point(0, 69);
            this.left_btn_stock_4.Margin = new System.Windows.Forms.Padding(0);
            this.left_btn_stock_4.Name = "left_btn_stock_4";
            this.left_btn_stock_4.Size = new System.Drawing.Size(227, 23);
            this.left_btn_stock_4.TabIndex = 4;
            this.left_btn_stock_4.Text = "清单查询";
            this.left_btn_stock_4.UseVisualStyleBackColor = true;
            this.left_btn_stock_4.Click += new System.EventHandler(this.left_btn_stock_4_Click);
            // 
            // left_btn_manager
            // 
            this.left_btn_manager.FlatAppearance.BorderSize = 0;
            this.left_btn_manager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.left_btn_manager.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.left_btn_manager.ForeColor = System.Drawing.Color.DarkCyan;
            this.left_btn_manager.Location = new System.Drawing.Point(0, 130);
            this.left_btn_manager.Margin = new System.Windows.Forms.Padding(0);
            this.left_btn_manager.Name = "left_btn_manager";
            this.left_btn_manager.Size = new System.Drawing.Size(230, 37);
            this.left_btn_manager.TabIndex = 4;
            this.left_btn_manager.Text = "管理员页面";
            this.left_btn_manager.UseVisualStyleBackColor = true;
            this.left_btn_manager.Click += new System.EventHandler(this.left_btn_manager_Click);
            // 
            // left_menu_manager
            // 
            this.left_menu_manager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.left_menu_manager.Controls.Add(this.left_btn_manager_1);
            this.left_menu_manager.Controls.Add(this.left_btn_manager_2);
            this.left_menu_manager.Location = new System.Drawing.Point(0, 167);
            this.left_menu_manager.Margin = new System.Windows.Forms.Padding(0);
            this.left_menu_manager.Name = "left_menu_manager";
            this.left_menu_manager.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.left_menu_manager.Size = new System.Drawing.Size(228, 0);
            this.left_menu_manager.TabIndex = 8;
            // 
            // left_btn_manager_1
            // 
            this.left_btn_manager_1.FlatAppearance.BorderSize = 0;
            this.left_btn_manager_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.left_btn_manager_1.Font = new System.Drawing.Font("宋体", 9F);
            this.left_btn_manager_1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.left_btn_manager_1.Location = new System.Drawing.Point(1, 0);
            this.left_btn_manager_1.Margin = new System.Windows.Forms.Padding(0);
            this.left_btn_manager_1.Name = "left_btn_manager_1";
            this.left_btn_manager_1.Size = new System.Drawing.Size(227, 23);
            this.left_btn_manager_1.TabIndex = 0;
            this.left_btn_manager_1.Text = "管理员信息";
            this.left_btn_manager_1.UseVisualStyleBackColor = true;
            this.left_btn_manager_1.Click += new System.EventHandler(this.left_btn_manager_1_Click);
            // 
            // left_btn_manager_2
            // 
            this.left_btn_manager_2.FlatAppearance.BorderSize = 0;
            this.left_btn_manager_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.left_btn_manager_2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.left_btn_manager_2.Location = new System.Drawing.Point(1, 23);
            this.left_btn_manager_2.Margin = new System.Windows.Forms.Padding(0);
            this.left_btn_manager_2.Name = "left_btn_manager_2";
            this.left_btn_manager_2.Size = new System.Drawing.Size(227, 23);
            this.left_btn_manager_2.TabIndex = 1;
            this.left_btn_manager_2.Text = "新建管理员";
            this.left_btn_manager_2.UseVisualStyleBackColor = true;
            this.left_btn_manager_2.Click += new System.EventHandler(this.left_btn_manager_2_Click);
            // 
            // left_btn_backstage
            // 
            this.left_btn_backstage.FlatAppearance.BorderSize = 0;
            this.left_btn_backstage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.left_btn_backstage.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.left_btn_backstage.ForeColor = System.Drawing.Color.DarkCyan;
            this.left_btn_backstage.Location = new System.Drawing.Point(0, 167);
            this.left_btn_backstage.Margin = new System.Windows.Forms.Padding(0);
            this.left_btn_backstage.Name = "left_btn_backstage";
            this.left_btn_backstage.Size = new System.Drawing.Size(230, 46);
            this.left_btn_backstage.TabIndex = 5;
            this.left_btn_backstage.Text = "后台管理";
            this.left_btn_backstage.UseVisualStyleBackColor = true;
            this.left_btn_backstage.Click += new System.EventHandler(this.left_btn_backstage_Click);
            // 
            // left_menu_backstage
            // 
            this.left_menu_backstage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.left_menu_backstage.Controls.Add(this.left_btn_backstage_1);
            this.left_menu_backstage.Controls.Add(this.left_btn_backstage_2);
            this.left_menu_backstage.Location = new System.Drawing.Point(1, 213);
            this.left_menu_backstage.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.left_menu_backstage.Name = "left_menu_backstage";
            this.left_menu_backstage.Size = new System.Drawing.Size(228, 0);
            this.left_menu_backstage.TabIndex = 9;
            // 
            // left_btn_backstage_1
            // 
            this.left_btn_backstage_1.FlatAppearance.BorderSize = 0;
            this.left_btn_backstage_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.left_btn_backstage_1.Font = new System.Drawing.Font("宋体", 9F);
            this.left_btn_backstage_1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.left_btn_backstage_1.Location = new System.Drawing.Point(0, 0);
            this.left_btn_backstage_1.Margin = new System.Windows.Forms.Padding(0);
            this.left_btn_backstage_1.Name = "left_btn_backstage_1";
            this.left_btn_backstage_1.Size = new System.Drawing.Size(227, 23);
            this.left_btn_backstage_1.TabIndex = 0;
            this.left_btn_backstage_1.Text = "客户信息管理";
            this.left_btn_backstage_1.UseVisualStyleBackColor = true;
            this.left_btn_backstage_1.Click += new System.EventHandler(this.left_btn_backstage_1_Click);
            // 
            // left_btn_backstage_2
            // 
            this.left_btn_backstage_2.FlatAppearance.BorderSize = 0;
            this.left_btn_backstage_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.left_btn_backstage_2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.left_btn_backstage_2.Location = new System.Drawing.Point(0, 23);
            this.left_btn_backstage_2.Margin = new System.Windows.Forms.Padding(0);
            this.left_btn_backstage_2.Name = "left_btn_backstage_2";
            this.left_btn_backstage_2.Size = new System.Drawing.Size(227, 23);
            this.left_btn_backstage_2.TabIndex = 1;
            this.left_btn_backstage_2.Text = "物品分类管理";
            this.left_btn_backstage_2.UseVisualStyleBackColor = true;
            this.left_btn_backstage_2.Click += new System.EventHandler(this.left_btn_backstage_2_Click);
            // 
            // Left_menu_showtimer
            // 
            this.Left_menu_showtimer.Interval = 1;
            this.Left_menu_showtimer.Tick += new System.EventHandler(this.Left_menu_showtimer_Tick);
            // 
            // Left_menu_hidetimer
            // 
            this.Left_menu_hidetimer.Interval = 1;
            this.Left_menu_hidetimer.Tick += new System.EventHandler(this.Left_menu_hidetimer_Tick);
            // 
            // initialization_timer
            // 
            this.initialization_timer.Interval = 1;
            this.initialization_timer.Tick += new System.EventHandler(this.initialization_timer_Tick);
            // 
            // body
            // 
            this.body.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.body.BackColor = System.Drawing.SystemColors.Control;
            this.body.Location = new System.Drawing.Point(229, 79);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(1050, 602);
            this.body.TabIndex = 9;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1280, 680);
            this.Controls.Add(this.body);
            this.Controls.Add(this.Left_menu);
            this.Controls.Add(this.index_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "仓库管理系统";
            this.Load += new System.EventHandler(this.Index_Load);
            this.Resize += new System.EventHandler(this.Index_Resize);
            this.index_top.ResumeLayout(false);
            this.index_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.name_img)).EndInit();
            this.Left_menu.ResumeLayout(false);
            this.Left_menu_put.ResumeLayout(false);
            this.left_menu_out.ResumeLayout(false);
            this.left_menu_stock.ResumeLayout(false);
            this.left_menu_manager.ResumeLayout(false);
            this.left_menu_backstage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel index_top;
        private System.Windows.Forms.Timer Index_movetimer;
        private System.Windows.Forms.Button Btn_mini;
        private System.Windows.Forms.Button Btn_close;
        private System.Windows.Forms.Button Btn_max;
        private System.Windows.Forms.Label Log_namelabel;
        private System.Windows.Forms.Label Log_cancel;
        private System.Windows.Forms.PictureBox name_img;
        private System.Windows.Forms.Label Titile;
        private System.Windows.Forms.FlowLayoutPanel Left_menu;
        private System.Windows.Forms.FlowLayoutPanel Left_menu_put;
        private System.Windows.Forms.Button left_btn_put;
        private System.Windows.Forms.Timer Left_menu_showtimer;
        private System.Windows.Forms.Button left_btn_put_1;
        private System.Windows.Forms.Button left_btn_out;
        private System.Windows.Forms.Button left_btn_stock;
        private System.Windows.Forms.Button left_btn_manager;
        private System.Windows.Forms.Button left_btn_backstage;
        private System.Windows.Forms.Button left_btn_put_2;
        private System.Windows.Forms.Timer Left_menu_hidetimer;
        private System.Windows.Forms.FlowLayoutPanel left_menu_out;
        private System.Windows.Forms.Button left_btn_out_1;
        private System.Windows.Forms.Button left_btn_out_2;
        private System.Windows.Forms.Timer initialization_timer;
        private System.Windows.Forms.FlowLayoutPanel left_menu_stock;
        private System.Windows.Forms.Button left_btn_stock_1;
        private System.Windows.Forms.Button left_btn_stock_2;
        private System.Windows.Forms.FlowLayoutPanel left_menu_manager;
        private System.Windows.Forms.Button left_btn_manager_1;
        private System.Windows.Forms.Button left_btn_manager_2;
        private System.Windows.Forms.FlowLayoutPanel left_menu_backstage;
        private System.Windows.Forms.Button left_btn_backstage_1;
        private System.Windows.Forms.Button left_btn_backstage_2;
        private System.Windows.Forms.Panel body;
        private System.Windows.Forms.Button left_btn_stock_3;
        private System.Windows.Forms.Button left_btn_stock_4;

    }
}