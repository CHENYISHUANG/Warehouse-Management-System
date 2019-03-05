namespace 仓库管理系统
{
    partial class PutInventoryprint
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
            this.lab_client_id = new System.Windows.Forms.Label();
            this.lab_warehouse_id = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.lab_goods_type = new System.Windows.Forms.Label();
            this.btn_storage = new System.Windows.Forms.Button();
            this.lab_bill_note = new System.Windows.Forms.Label();
            this.lab_lot_number = new System.Windows.Forms.Label();
            this.lab_type_id = new System.Windows.Forms.Label();
            this.lab_expiration_date = new System.Windows.Forms.Label();
            this.lab_manufacture_date = new System.Windows.Forms.Label();
            this.lab_goods_price = new System.Windows.Forms.Label();
            this.lab_goods_amount = new System.Windows.Forms.Label();
            this.lab_goods_note = new System.Windows.Forms.Label();
            this.lab_goods_volume = new System.Windows.Forms.Label();
            this.lab_goods_wight = new System.Windows.Forms.Label();
            this.lab_specifications = new System.Windows.Forms.Label();
            this.lab_goods_code = new System.Windows.Forms.Label();
            this.lab_goods_name = new System.Windows.Forms.Label();
            this.Tree_hide_timer = new System.Windows.Forms.Timer(this.components);
            this.Tree_show_timer = new System.Windows.Forms.Timer(this.components);
            this.goods_type_text = new System.Windows.Forms.Label();
            this.goods_volume_text = new System.Windows.Forms.Label();
            this.goods_price_text = new System.Windows.Forms.Label();
            this.goods_note_text = new System.Windows.Forms.Label();
            this.type_id_text = new System.Windows.Forms.Label();
            this.warehouse_text = new System.Windows.Forms.Label();
            this.bill_note_text = new System.Windows.Forms.Label();
            this.manufacture_date_text = new System.Windows.Forms.Label();
            this.goods_wight_text = new System.Windows.Forms.Label();
            this.goods_code_text = new System.Windows.Forms.Label();
            this.goods_name_text = new System.Windows.Forms.Label();
            this.specifications_text = new System.Windows.Forms.Label();
            this.goods_amount_text = new System.Windows.Forms.Label();
            this.expiration_date_text = new System.Windows.Forms.Label();
            this.client_text = new System.Windows.Forms.Label();
            this.lot_number_text = new System.Windows.Forms.Label();
            this.lab_operaion_name = new System.Windows.Forms.Label();
            this.operation_name_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_client_id
            // 
            this.lab_client_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_client_id.AutoSize = true;
            this.lab_client_id.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_client_id.Location = new System.Drawing.Point(170, 350);
            this.lab_client_id.Name = "lab_client_id";
            this.lab_client_id.Size = new System.Drawing.Size(68, 20);
            this.lab_client_id.TabIndex = 132;
            this.lab_client_id.Text = "客户名称:";
            this.lab_client_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_warehouse_id
            // 
            this.lab_warehouse_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_warehouse_id.AutoSize = true;
            this.lab_warehouse_id.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.lab_warehouse_id.Location = new System.Drawing.Point(773, 349);
            this.lab_warehouse_id.Name = "lab_warehouse_id";
            this.lab_warehouse_id.Size = new System.Drawing.Size(68, 20);
            this.lab_warehouse_id.TabIndex = 130;
            this.lab_warehouse_id.Text = "选择仓库:";
            this.lab_warehouse_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Title.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Title.Location = new System.Drawing.Point(497, 24);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(110, 21);
            this.Title.TabIndex = 128;
            this.Title.Text = "入 库 单 详 情";
            // 
            // lab_goods_type
            // 
            this.lab_goods_type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_goods_type.AutoSize = true;
            this.lab_goods_type.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.lab_goods_type.Location = new System.Drawing.Point(473, 93);
            this.lab_goods_type.Name = "lab_goods_type";
            this.lab_goods_type.Size = new System.Drawing.Size(68, 20);
            this.lab_goods_type.TabIndex = 101;
            this.lab_goods_type.Text = "物品类型:";
            this.lab_goods_type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_storage
            // 
            this.btn_storage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_storage.BackColor = System.Drawing.Color.White;
            this.btn_storage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_storage.Location = new System.Drawing.Point(454, 514);
            this.btn_storage.Name = "btn_storage";
            this.btn_storage.Size = new System.Drawing.Size(184, 35);
            this.btn_storage.TabIndex = 133;
            this.btn_storage.Text = "打印入库单";
            this.btn_storage.UseVisualStyleBackColor = false;
            this.btn_storage.Click += new System.EventHandler(this.btn_storage_Click);
            // 
            // lab_bill_note
            // 
            this.lab_bill_note.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_bill_note.AutoSize = true;
            this.lab_bill_note.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.lab_bill_note.Location = new System.Drawing.Point(773, 278);
            this.lab_bill_note.Name = "lab_bill_note";
            this.lab_bill_note.Size = new System.Drawing.Size(68, 20);
            this.lab_bill_note.TabIndex = 126;
            this.lab_bill_note.Text = "入库备注:";
            this.lab_bill_note.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_lot_number
            // 
            this.lab_lot_number.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_lot_number.AutoSize = true;
            this.lab_lot_number.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_lot_number.Location = new System.Drawing.Point(170, 417);
            this.lab_lot_number.Name = "lab_lot_number";
            this.lab_lot_number.Size = new System.Drawing.Size(68, 20);
            this.lab_lot_number.TabIndex = 124;
            this.lab_lot_number.Text = "入库批号:";
            this.lab_lot_number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_type_id
            // 
            this.lab_type_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_type_id.AutoSize = true;
            this.lab_type_id.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.lab_type_id.Location = new System.Drawing.Point(473, 349);
            this.lab_type_id.Name = "lab_type_id";
            this.lab_type_id.Size = new System.Drawing.Size(68, 20);
            this.lab_type_id.TabIndex = 122;
            this.lab_type_id.Text = "入库方式:";
            this.lab_type_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_expiration_date
            // 
            this.lab_expiration_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_expiration_date.AutoSize = true;
            this.lab_expiration_date.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_expiration_date.Location = new System.Drawing.Point(170, 278);
            this.lab_expiration_date.Name = "lab_expiration_date";
            this.lab_expiration_date.Size = new System.Drawing.Size(68, 20);
            this.lab_expiration_date.TabIndex = 120;
            this.lab_expiration_date.Text = "到期日期:";
            this.lab_expiration_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_manufacture_date
            // 
            this.lab_manufacture_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_manufacture_date.AutoSize = true;
            this.lab_manufacture_date.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.lab_manufacture_date.Location = new System.Drawing.Point(773, 217);
            this.lab_manufacture_date.Name = "lab_manufacture_date";
            this.lab_manufacture_date.Size = new System.Drawing.Size(68, 20);
            this.lab_manufacture_date.TabIndex = 118;
            this.lab_manufacture_date.Text = "生产日期:";
            this.lab_manufacture_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_goods_price
            // 
            this.lab_goods_price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_goods_price.AutoSize = true;
            this.lab_goods_price.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.lab_goods_price.Location = new System.Drawing.Point(473, 216);
            this.lab_goods_price.Name = "lab_goods_price";
            this.lab_goods_price.Size = new System.Drawing.Size(68, 20);
            this.lab_goods_price.TabIndex = 116;
            this.lab_goods_price.Text = "物品单价:";
            this.lab_goods_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_goods_amount
            // 
            this.lab_goods_amount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_goods_amount.AutoSize = true;
            this.lab_goods_amount.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_goods_amount.Location = new System.Drawing.Point(170, 217);
            this.lab_goods_amount.Name = "lab_goods_amount";
            this.lab_goods_amount.Size = new System.Drawing.Size(68, 20);
            this.lab_goods_amount.TabIndex = 114;
            this.lab_goods_amount.Text = "物品数量:";
            this.lab_goods_amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_goods_note
            // 
            this.lab_goods_note.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_goods_note.AutoSize = true;
            this.lab_goods_note.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.lab_goods_note.Location = new System.Drawing.Point(473, 280);
            this.lab_goods_note.Name = "lab_goods_note";
            this.lab_goods_note.Size = new System.Drawing.Size(68, 20);
            this.lab_goods_note.TabIndex = 112;
            this.lab_goods_note.Text = "物品备注:";
            this.lab_goods_note.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_goods_volume
            // 
            this.lab_goods_volume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_goods_volume.AutoSize = true;
            this.lab_goods_volume.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.lab_goods_volume.Location = new System.Drawing.Point(443, 155);
            this.lab_goods_volume.Name = "lab_goods_volume";
            this.lab_goods_volume.Size = new System.Drawing.Size(98, 20);
            this.lab_goods_volume.TabIndex = 110;
            this.lab_goods_volume.Text = "物品体积(cm):";
            this.lab_goods_volume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_goods_wight
            // 
            this.lab_goods_wight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_goods_wight.AutoSize = true;
            this.lab_goods_wight.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.lab_goods_wight.Location = new System.Drawing.Point(746, 155);
            this.lab_goods_wight.Name = "lab_goods_wight";
            this.lab_goods_wight.Size = new System.Drawing.Size(95, 20);
            this.lab_goods_wight.TabIndex = 108;
            this.lab_goods_wight.Text = "物品重量(kg):";
            this.lab_goods_wight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_specifications
            // 
            this.lab_specifications.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_specifications.AutoSize = true;
            this.lab_specifications.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_specifications.Location = new System.Drawing.Point(170, 155);
            this.lab_specifications.Name = "lab_specifications";
            this.lab_specifications.Size = new System.Drawing.Size(68, 20);
            this.lab_specifications.TabIndex = 106;
            this.lab_specifications.Text = "物品规格:";
            this.lab_specifications.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_goods_code
            // 
            this.lab_goods_code.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_goods_code.AutoSize = true;
            this.lab_goods_code.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.lab_goods_code.Location = new System.Drawing.Point(773, 95);
            this.lab_goods_code.Name = "lab_goods_code";
            this.lab_goods_code.Size = new System.Drawing.Size(68, 20);
            this.lab_goods_code.TabIndex = 104;
            this.lab_goods_code.Text = "物品代码:";
            this.lab_goods_code.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_goods_name
            // 
            this.lab_goods_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_goods_name.AutoSize = true;
            this.lab_goods_name.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_goods_name.Location = new System.Drawing.Point(176, 95);
            this.lab_goods_name.Name = "lab_goods_name";
            this.lab_goods_name.Size = new System.Drawing.Size(62, 20);
            this.lab_goods_name.TabIndex = 99;
            this.lab_goods_name.Text = "物 品 名:";
            this.lab_goods_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tree_hide_timer
            // 
            this.Tree_hide_timer.Interval = 1;
            // 
            // Tree_show_timer
            // 
            this.Tree_show_timer.Interval = 1;
            // 
            // goods_type_text
            // 
            this.goods_type_text.AutoSize = true;
            this.goods_type_text.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.goods_type_text.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.goods_type_text.Location = new System.Drawing.Point(547, 94);
            this.goods_type_text.Name = "goods_type_text";
            this.goods_type_text.Size = new System.Drawing.Size(0, 20);
            this.goods_type_text.TabIndex = 141;
            this.goods_type_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goods_volume_text
            // 
            this.goods_volume_text.AutoSize = true;
            this.goods_volume_text.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.goods_volume_text.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.goods_volume_text.Location = new System.Drawing.Point(547, 156);
            this.goods_volume_text.Name = "goods_volume_text";
            this.goods_volume_text.Size = new System.Drawing.Size(0, 20);
            this.goods_volume_text.TabIndex = 142;
            this.goods_volume_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goods_price_text
            // 
            this.goods_price_text.AutoSize = true;
            this.goods_price_text.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.goods_price_text.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.goods_price_text.Location = new System.Drawing.Point(547, 217);
            this.goods_price_text.Name = "goods_price_text";
            this.goods_price_text.Size = new System.Drawing.Size(0, 20);
            this.goods_price_text.TabIndex = 143;
            this.goods_price_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goods_note_text
            // 
            this.goods_note_text.AutoSize = true;
            this.goods_note_text.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.goods_note_text.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.goods_note_text.Location = new System.Drawing.Point(547, 281);
            this.goods_note_text.Name = "goods_note_text";
            this.goods_note_text.Size = new System.Drawing.Size(0, 20);
            this.goods_note_text.TabIndex = 144;
            this.goods_note_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // type_id_text
            // 
            this.type_id_text.AutoSize = true;
            this.type_id_text.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.type_id_text.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.type_id_text.Location = new System.Drawing.Point(547, 350);
            this.type_id_text.Name = "type_id_text";
            this.type_id_text.Size = new System.Drawing.Size(0, 20);
            this.type_id_text.TabIndex = 145;
            this.type_id_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // warehouse_text
            // 
            this.warehouse_text.AutoSize = true;
            this.warehouse_text.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.warehouse_text.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.warehouse_text.Location = new System.Drawing.Point(846, 350);
            this.warehouse_text.Name = "warehouse_text";
            this.warehouse_text.Size = new System.Drawing.Size(0, 20);
            this.warehouse_text.TabIndex = 150;
            this.warehouse_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bill_note_text
            // 
            this.bill_note_text.AutoSize = true;
            this.bill_note_text.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.bill_note_text.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bill_note_text.Location = new System.Drawing.Point(846, 279);
            this.bill_note_text.Name = "bill_note_text";
            this.bill_note_text.Size = new System.Drawing.Size(0, 20);
            this.bill_note_text.TabIndex = 149;
            this.bill_note_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // manufacture_date_text
            // 
            this.manufacture_date_text.AutoSize = true;
            this.manufacture_date_text.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.manufacture_date_text.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.manufacture_date_text.Location = new System.Drawing.Point(846, 218);
            this.manufacture_date_text.Name = "manufacture_date_text";
            this.manufacture_date_text.Size = new System.Drawing.Size(0, 20);
            this.manufacture_date_text.TabIndex = 148;
            this.manufacture_date_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goods_wight_text
            // 
            this.goods_wight_text.AutoSize = true;
            this.goods_wight_text.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.goods_wight_text.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.goods_wight_text.Location = new System.Drawing.Point(846, 156);
            this.goods_wight_text.Name = "goods_wight_text";
            this.goods_wight_text.Size = new System.Drawing.Size(0, 20);
            this.goods_wight_text.TabIndex = 147;
            this.goods_wight_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goods_code_text
            // 
            this.goods_code_text.AutoSize = true;
            this.goods_code_text.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.goods_code_text.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.goods_code_text.Location = new System.Drawing.Point(846, 96);
            this.goods_code_text.Name = "goods_code_text";
            this.goods_code_text.Size = new System.Drawing.Size(0, 20);
            this.goods_code_text.TabIndex = 146;
            this.goods_code_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goods_name_text
            // 
            this.goods_name_text.AutoSize = true;
            this.goods_name_text.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.goods_name_text.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.goods_name_text.Location = new System.Drawing.Point(243, 96);
            this.goods_name_text.Name = "goods_name_text";
            this.goods_name_text.Size = new System.Drawing.Size(0, 20);
            this.goods_name_text.TabIndex = 135;
            this.goods_name_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // specifications_text
            // 
            this.specifications_text.AutoSize = true;
            this.specifications_text.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.specifications_text.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.specifications_text.Location = new System.Drawing.Point(243, 156);
            this.specifications_text.Name = "specifications_text";
            this.specifications_text.Size = new System.Drawing.Size(0, 20);
            this.specifications_text.TabIndex = 136;
            this.specifications_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goods_amount_text
            // 
            this.goods_amount_text.AutoSize = true;
            this.goods_amount_text.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.goods_amount_text.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.goods_amount_text.Location = new System.Drawing.Point(243, 218);
            this.goods_amount_text.Name = "goods_amount_text";
            this.goods_amount_text.Size = new System.Drawing.Size(0, 20);
            this.goods_amount_text.TabIndex = 137;
            this.goods_amount_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // expiration_date_text
            // 
            this.expiration_date_text.AutoSize = true;
            this.expiration_date_text.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.expiration_date_text.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.expiration_date_text.Location = new System.Drawing.Point(243, 279);
            this.expiration_date_text.Name = "expiration_date_text";
            this.expiration_date_text.Size = new System.Drawing.Size(0, 20);
            this.expiration_date_text.TabIndex = 138;
            this.expiration_date_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // client_text
            // 
            this.client_text.AutoSize = true;
            this.client_text.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.client_text.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.client_text.Location = new System.Drawing.Point(243, 351);
            this.client_text.Name = "client_text";
            this.client_text.Size = new System.Drawing.Size(0, 20);
            this.client_text.TabIndex = 139;
            this.client_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lot_number_text
            // 
            this.lot_number_text.AutoSize = true;
            this.lot_number_text.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.lot_number_text.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lot_number_text.Location = new System.Drawing.Point(243, 418);
            this.lot_number_text.Name = "lot_number_text";
            this.lot_number_text.Size = new System.Drawing.Size(0, 20);
            this.lot_number_text.TabIndex = 140;
            this.lot_number_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_operaion_name
            // 
            this.lab_operaion_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_operaion_name.AutoSize = true;
            this.lab_operaion_name.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_operaion_name.Location = new System.Drawing.Point(773, 466);
            this.lab_operaion_name.Name = "lab_operaion_name";
            this.lab_operaion_name.Size = new System.Drawing.Size(68, 20);
            this.lab_operaion_name.TabIndex = 151;
            this.lab_operaion_name.Text = "操作人员:";
            this.lab_operaion_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // operation_name_text
            // 
            this.operation_name_text.AutoSize = true;
            this.operation_name_text.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.operation_name_text.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.operation_name_text.Location = new System.Drawing.Point(847, 466);
            this.operation_name_text.Name = "operation_name_text";
            this.operation_name_text.Size = new System.Drawing.Size(0, 20);
            this.operation_name_text.TabIndex = 152;
            this.operation_name_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PutInventoryprint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1050, 602);
            this.Controls.Add(this.operation_name_text);
            this.Controls.Add(this.lab_operaion_name);
            this.Controls.Add(this.warehouse_text);
            this.Controls.Add(this.bill_note_text);
            this.Controls.Add(this.manufacture_date_text);
            this.Controls.Add(this.goods_wight_text);
            this.Controls.Add(this.goods_code_text);
            this.Controls.Add(this.type_id_text);
            this.Controls.Add(this.goods_note_text);
            this.Controls.Add(this.goods_price_text);
            this.Controls.Add(this.goods_volume_text);
            this.Controls.Add(this.goods_type_text);
            this.Controls.Add(this.lot_number_text);
            this.Controls.Add(this.client_text);
            this.Controls.Add(this.expiration_date_text);
            this.Controls.Add(this.goods_amount_text);
            this.Controls.Add(this.specifications_text);
            this.Controls.Add(this.goods_name_text);
            this.Controls.Add(this.lab_client_id);
            this.Controls.Add(this.lab_warehouse_id);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.lab_goods_type);
            this.Controls.Add(this.btn_storage);
            this.Controls.Add(this.lab_bill_note);
            this.Controls.Add(this.lab_lot_number);
            this.Controls.Add(this.lab_type_id);
            this.Controls.Add(this.lab_expiration_date);
            this.Controls.Add(this.lab_manufacture_date);
            this.Controls.Add(this.lab_goods_price);
            this.Controls.Add(this.lab_goods_amount);
            this.Controls.Add(this.lab_goods_note);
            this.Controls.Add(this.lab_goods_volume);
            this.Controls.Add(this.lab_goods_wight);
            this.Controls.Add(this.lab_specifications);
            this.Controls.Add(this.lab_goods_code);
            this.Controls.Add(this.lab_goods_name);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PutInventoryprint";
            this.Text = "PutInventoryprint";
            this.Load += new System.EventHandler(this.PutInventoryprint_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_client_id;
        private System.Windows.Forms.Label lab_warehouse_id;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label lab_goods_type;
        private System.Windows.Forms.Button btn_storage;
        private System.Windows.Forms.Label lab_bill_note;
        private System.Windows.Forms.Label lab_lot_number;
        private System.Windows.Forms.Label lab_type_id;
        private System.Windows.Forms.Label lab_expiration_date;
        private System.Windows.Forms.Label lab_manufacture_date;
        private System.Windows.Forms.Label lab_goods_price;
        private System.Windows.Forms.Label lab_goods_amount;
        private System.Windows.Forms.Label lab_goods_note;
        private System.Windows.Forms.Label lab_goods_volume;
        private System.Windows.Forms.Label lab_goods_wight;
        private System.Windows.Forms.Label lab_specifications;
        private System.Windows.Forms.Label lab_goods_code;
        private System.Windows.Forms.Label lab_goods_name;
        private System.Windows.Forms.Timer Tree_hide_timer;
        private System.Windows.Forms.Timer Tree_show_timer;
        private System.Windows.Forms.Label goods_type_text;
        private System.Windows.Forms.Label goods_volume_text;
        private System.Windows.Forms.Label goods_price_text;
        private System.Windows.Forms.Label goods_note_text;
        private System.Windows.Forms.Label type_id_text;
        private System.Windows.Forms.Label warehouse_text;
        private System.Windows.Forms.Label bill_note_text;
        private System.Windows.Forms.Label manufacture_date_text;
        private System.Windows.Forms.Label goods_wight_text;
        private System.Windows.Forms.Label goods_code_text;
        private System.Windows.Forms.Label goods_name_text;
        private System.Windows.Forms.Label specifications_text;
        private System.Windows.Forms.Label goods_amount_text;
        private System.Windows.Forms.Label expiration_date_text;
        private System.Windows.Forms.Label client_text;
        private System.Windows.Forms.Label lot_number_text;
        private System.Windows.Forms.Label lab_operaion_name;
        private System.Windows.Forms.Label operation_name_text;

    }
}