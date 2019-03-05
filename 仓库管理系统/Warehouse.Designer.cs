namespace 仓库管理系统
{
    partial class Warehouse
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_manager = new System.Windows.Forms.Button();
            this.panel_manage = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.text_warehouse_note = new System.Windows.Forms.TextBox();
            this.lab_warehouse_note = new System.Windows.Forms.Label();
            this.text_warehouse_position = new System.Windows.Forms.TextBox();
            this.lab_warehouse_position = new System.Windows.Forms.Label();
            this.text_warehouse_name = new System.Windows.Forms.TextBox();
            this.lab_warehouse_name = new System.Windows.Forms.Label();
            this.com_warehouse_id = new System.Windows.Forms.ComboBox();
            this.lab_warehouse_id = new System.Windows.Forms.Label();
            this.panel_new = new System.Windows.Forms.Panel();
            this.lab_prompt = new System.Windows.Forms.Label();
            this.btn_new_ok = new System.Windows.Forms.Button();
            this.text_new_warehouse_note = new System.Windows.Forms.TextBox();
            this.lab_new_warehouse_note = new System.Windows.Forms.Label();
            this.text_new_warehouse_position = new System.Windows.Forms.TextBox();
            this.lab_new_warehouse_position = new System.Windows.Forms.Label();
            this.text__new_warehouse_name = new System.Windows.Forms.TextBox();
            this.lab_new_warehouse_name = new System.Windows.Forms.Label();
            this.panel_manage.SuspendLayout();
            this.panel_new.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Title.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Title.Location = new System.Drawing.Point(497, 53);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(74, 21);
            this.Title.TabIndex = 138;
            this.Title.Text = "仓库管理";
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.ForeColor = System.Drawing.Color.Chocolate;
            this.btn_add.Location = new System.Drawing.Point(689, 126);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(198, 22);
            this.btn_add.TabIndex = 139;
            this.btn_add.Text = "添加仓库";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_manager
            // 
            this.btn_manager.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_manager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_manager.ForeColor = System.Drawing.Color.Chocolate;
            this.btn_manager.Location = new System.Drawing.Point(158, 126);
            this.btn_manager.Name = "btn_manager";
            this.btn_manager.Size = new System.Drawing.Size(198, 22);
            this.btn_manager.TabIndex = 140;
            this.btn_manager.Text = "仓库管理";
            this.btn_manager.UseVisualStyleBackColor = true;
            this.btn_manager.Click += new System.EventHandler(this.btn_manager_Click);
            // 
            // panel_manage
            // 
            this.panel_manage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_manage.Controls.Add(this.btn_delete);
            this.panel_manage.Controls.Add(this.btn_reset);
            this.panel_manage.Controls.Add(this.text_warehouse_note);
            this.panel_manage.Controls.Add(this.lab_warehouse_note);
            this.panel_manage.Controls.Add(this.text_warehouse_position);
            this.panel_manage.Controls.Add(this.lab_warehouse_position);
            this.panel_manage.Controls.Add(this.text_warehouse_name);
            this.panel_manage.Controls.Add(this.lab_warehouse_name);
            this.panel_manage.Controls.Add(this.com_warehouse_id);
            this.panel_manage.Controls.Add(this.lab_warehouse_id);
            this.panel_manage.Location = new System.Drawing.Point(158, 154);
            this.panel_manage.Name = "panel_manage";
            this.panel_manage.Size = new System.Drawing.Size(729, 406);
            this.panel_manage.TabIndex = 141;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(269, 320);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 145;
            this.btn_delete.Text = "删除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(378, 320);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 144;
            this.btn_reset.Text = "更改";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // text_warehouse_note
            // 
            this.text_warehouse_note.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_warehouse_note.Location = new System.Drawing.Point(332, 216);
            this.text_warehouse_note.MaxLength = 9;
            this.text_warehouse_note.Name = "text_warehouse_note";
            this.text_warehouse_note.Size = new System.Drawing.Size(121, 21);
            this.text_warehouse_note.TabIndex = 142;
            this.text_warehouse_note.WordWrap = false;
            // 
            // lab_warehouse_note
            // 
            this.lab_warehouse_note.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_warehouse_note.AutoSize = true;
            this.lab_warehouse_note.Location = new System.Drawing.Point(267, 219);
            this.lab_warehouse_note.Name = "lab_warehouse_note";
            this.lab_warehouse_note.Size = new System.Drawing.Size(59, 12);
            this.lab_warehouse_note.TabIndex = 143;
            this.lab_warehouse_note.Text = "仓库备注:";
            // 
            // text_warehouse_position
            // 
            this.text_warehouse_position.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_warehouse_position.Location = new System.Drawing.Point(332, 156);
            this.text_warehouse_position.MaxLength = 9;
            this.text_warehouse_position.Name = "text_warehouse_position";
            this.text_warehouse_position.Size = new System.Drawing.Size(121, 21);
            this.text_warehouse_position.TabIndex = 140;
            this.text_warehouse_position.WordWrap = false;
            // 
            // lab_warehouse_position
            // 
            this.lab_warehouse_position.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_warehouse_position.AutoSize = true;
            this.lab_warehouse_position.Location = new System.Drawing.Point(267, 159);
            this.lab_warehouse_position.Name = "lab_warehouse_position";
            this.lab_warehouse_position.Size = new System.Drawing.Size(59, 12);
            this.lab_warehouse_position.TabIndex = 141;
            this.lab_warehouse_position.Text = "仓库位置:";
            // 
            // text_warehouse_name
            // 
            this.text_warehouse_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_warehouse_name.Location = new System.Drawing.Point(332, 94);
            this.text_warehouse_name.MaxLength = 9;
            this.text_warehouse_name.Name = "text_warehouse_name";
            this.text_warehouse_name.Size = new System.Drawing.Size(121, 21);
            this.text_warehouse_name.TabIndex = 138;
            this.text_warehouse_name.WordWrap = false;
            // 
            // lab_warehouse_name
            // 
            this.lab_warehouse_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_warehouse_name.AutoSize = true;
            this.lab_warehouse_name.Location = new System.Drawing.Point(279, 97);
            this.lab_warehouse_name.Name = "lab_warehouse_name";
            this.lab_warehouse_name.Size = new System.Drawing.Size(47, 12);
            this.lab_warehouse_name.TabIndex = 139;
            this.lab_warehouse_name.Text = "仓库名:";
            // 
            // com_warehouse_id
            // 
            this.com_warehouse_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.com_warehouse_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_warehouse_id.FormattingEnabled = true;
            this.com_warehouse_id.Location = new System.Drawing.Point(332, 34);
            this.com_warehouse_id.Name = "com_warehouse_id";
            this.com_warehouse_id.Size = new System.Drawing.Size(121, 20);
            this.com_warehouse_id.TabIndex = 135;
            this.com_warehouse_id.SelectionChangeCommitted += new System.EventHandler(this.com_warehouse_id_SelectionChangeCommitted);
            // 
            // lab_warehouse_id
            // 
            this.lab_warehouse_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_warehouse_id.AutoSize = true;
            this.lab_warehouse_id.Location = new System.Drawing.Point(267, 37);
            this.lab_warehouse_id.Name = "lab_warehouse_id";
            this.lab_warehouse_id.Size = new System.Drawing.Size(59, 12);
            this.lab_warehouse_id.TabIndex = 136;
            this.lab_warehouse_id.Text = "选择仓库:";
            // 
            // panel_new
            // 
            this.panel_new.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_new.Controls.Add(this.lab_prompt);
            this.panel_new.Controls.Add(this.btn_new_ok);
            this.panel_new.Controls.Add(this.text_new_warehouse_note);
            this.panel_new.Controls.Add(this.lab_new_warehouse_note);
            this.panel_new.Controls.Add(this.text_new_warehouse_position);
            this.panel_new.Controls.Add(this.lab_new_warehouse_position);
            this.panel_new.Controls.Add(this.text__new_warehouse_name);
            this.panel_new.Controls.Add(this.lab_new_warehouse_name);
            this.panel_new.Location = new System.Drawing.Point(158, 154);
            this.panel_new.Name = "panel_new";
            this.panel_new.Size = new System.Drawing.Size(729, 406);
            this.panel_new.TabIndex = 142;
            this.panel_new.Visible = false;
            // 
            // lab_prompt
            // 
            this.lab_prompt.AutoSize = true;
            this.lab_prompt.Location = new System.Drawing.Point(459, 63);
            this.lab_prompt.Name = "lab_prompt";
            this.lab_prompt.Size = new System.Drawing.Size(0, 12);
            this.lab_prompt.TabIndex = 145;
            // 
            // btn_new_ok
            // 
            this.btn_new_ok.Location = new System.Drawing.Point(269, 308);
            this.btn_new_ok.Name = "btn_new_ok";
            this.btn_new_ok.Size = new System.Drawing.Size(184, 23);
            this.btn_new_ok.TabIndex = 144;
            this.btn_new_ok.Text = "确定";
            this.btn_new_ok.UseVisualStyleBackColor = true;
            this.btn_new_ok.Click += new System.EventHandler(this.btn_new_ok_Click);
            // 
            // text_new_warehouse_note
            // 
            this.text_new_warehouse_note.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_new_warehouse_note.Location = new System.Drawing.Point(332, 221);
            this.text_new_warehouse_note.MaxLength = 20;
            this.text_new_warehouse_note.Name = "text_new_warehouse_note";
            this.text_new_warehouse_note.Size = new System.Drawing.Size(121, 21);
            this.text_new_warehouse_note.TabIndex = 142;
            this.text_new_warehouse_note.WordWrap = false;
            // 
            // lab_new_warehouse_note
            // 
            this.lab_new_warehouse_note.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_new_warehouse_note.AutoSize = true;
            this.lab_new_warehouse_note.Location = new System.Drawing.Point(267, 224);
            this.lab_new_warehouse_note.Name = "lab_new_warehouse_note";
            this.lab_new_warehouse_note.Size = new System.Drawing.Size(59, 12);
            this.lab_new_warehouse_note.TabIndex = 143;
            this.lab_new_warehouse_note.Text = "仓库备注:";
            // 
            // text_new_warehouse_position
            // 
            this.text_new_warehouse_position.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_new_warehouse_position.Location = new System.Drawing.Point(332, 143);
            this.text_new_warehouse_position.MaxLength = 12;
            this.text_new_warehouse_position.Name = "text_new_warehouse_position";
            this.text_new_warehouse_position.Size = new System.Drawing.Size(121, 21);
            this.text_new_warehouse_position.TabIndex = 140;
            this.text_new_warehouse_position.WordWrap = false;
            // 
            // lab_new_warehouse_position
            // 
            this.lab_new_warehouse_position.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_new_warehouse_position.AutoSize = true;
            this.lab_new_warehouse_position.Location = new System.Drawing.Point(267, 146);
            this.lab_new_warehouse_position.Name = "lab_new_warehouse_position";
            this.lab_new_warehouse_position.Size = new System.Drawing.Size(59, 12);
            this.lab_new_warehouse_position.TabIndex = 141;
            this.lab_new_warehouse_position.Text = "仓库位置:";
            // 
            // text__new_warehouse_name
            // 
            this.text__new_warehouse_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text__new_warehouse_name.Location = new System.Drawing.Point(332, 60);
            this.text__new_warehouse_name.MaxLength = 12;
            this.text__new_warehouse_name.Name = "text__new_warehouse_name";
            this.text__new_warehouse_name.Size = new System.Drawing.Size(121, 21);
            this.text__new_warehouse_name.TabIndex = 138;
            this.text__new_warehouse_name.WordWrap = false;
            this.text__new_warehouse_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text__new_warehouse_name_KeyPress);
            this.text__new_warehouse_name.Leave += new System.EventHandler(this.text__new_warehouse_name_Leave);
            // 
            // lab_new_warehouse_name
            // 
            this.lab_new_warehouse_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_new_warehouse_name.AutoSize = true;
            this.lab_new_warehouse_name.Location = new System.Drawing.Point(279, 63);
            this.lab_new_warehouse_name.Name = "lab_new_warehouse_name";
            this.lab_new_warehouse_name.Size = new System.Drawing.Size(47, 12);
            this.lab_new_warehouse_name.TabIndex = 139;
            this.lab_new_warehouse_name.Text = "仓库名:";
            // 
            // Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 563);
            this.Controls.Add(this.panel_new);
            this.Controls.Add(this.panel_manage);
            this.Controls.Add(this.btn_manager);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Warehouse";
            this.Text = "WarehouseNumber";
            this.Load += new System.EventHandler(this.Warehouse_Load);
            this.panel_manage.ResumeLayout(false);
            this.panel_manage.PerformLayout();
            this.panel_new.ResumeLayout(false);
            this.panel_new.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_manager;
        private System.Windows.Forms.Panel panel_manage;
        private System.Windows.Forms.ComboBox com_warehouse_id;
        private System.Windows.Forms.Label lab_warehouse_id;
        private System.Windows.Forms.TextBox text_warehouse_note;
        private System.Windows.Forms.Label lab_warehouse_note;
        private System.Windows.Forms.TextBox text_warehouse_position;
        private System.Windows.Forms.Label lab_warehouse_position;
        private System.Windows.Forms.TextBox text_warehouse_name;
        private System.Windows.Forms.Label lab_warehouse_name;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Panel panel_new;
        private System.Windows.Forms.Button btn_new_ok;
        private System.Windows.Forms.TextBox text_new_warehouse_note;
        private System.Windows.Forms.Label lab_new_warehouse_note;
        private System.Windows.Forms.TextBox text_new_warehouse_position;
        private System.Windows.Forms.Label lab_new_warehouse_position;
        private System.Windows.Forms.TextBox text__new_warehouse_name;
        private System.Windows.Forms.Label lab_new_warehouse_name;
        private System.Windows.Forms.Label lab_prompt;
    }
}