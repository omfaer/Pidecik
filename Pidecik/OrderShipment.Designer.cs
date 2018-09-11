namespace Pidecik
{
    partial class OrderShipment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.customer_list_dgw = new System.Windows.Forms.DataGridView();
            this.customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.search_tbx = new System.Windows.Forms.TextBox();
            this.ship_title_lbl = new System.Windows.Forms.Label();
            this.shiporders_lv = new System.Windows.Forms.ListView();
            this.product_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.product_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.product_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.order_title_lbl = new System.Windows.Forms.Label();
            this.selectall = new System.Windows.Forms.CheckBox();
            this.customername_tbx = new MetroFramework.Controls.MetroTextBox();
            this.category_cbx = new MetroFramework.Controls.MetroComboBox();
            this.product_list_dgw = new MetroFramework.Controls.MetroGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add_product_btn = new MetroFramework.Controls.MetroButton();
            this.ship_number = new System.Windows.Forms.TextBox();
            this.shipment_number_lbl = new MetroFramework.Controls.MetroLabel();
            this.cname_lbl = new MetroFramework.Controls.MetroLabel();
            this.shipaddress_tbx = new MetroFramework.Controls.MetroTextBox();
            this.address_lbl = new MetroFramework.Controls.MetroLabel();
            this.shiptype_cbx = new MetroFramework.Controls.MetroComboBox();
            this.personel_cbx = new MetroFramework.Controls.MetroComboBox();
            this.ship_datetimepicker = new MetroFramework.Controls.MetroDateTime();
            this.shipdetails_tbx = new MetroFramework.Controls.MetroTextBox();
            this.shiptype_lbl = new MetroFramework.Controls.MetroLabel();
            this.carrier_lbl = new MetroFramework.Controls.MetroLabel();
            this.shiptime_lbl = new MetroFramework.Controls.MetroLabel();
            this.details_lbl = new MetroFramework.Controls.MetroLabel();
            this.cancel_product = new MetroFramework.Controls.MetroButton();
            this.product_title = new System.Windows.Forms.Label();
            this.categorycbx_lbl = new MetroFramework.Controls.MetroLabel();
            this.search_product_tbx = new MetroFramework.Controls.MetroTextBox();
            this.search_prod_lbl = new MetroFramework.Controls.MetroLabel();
            this.newshipment_btn = new MetroFramework.Controls.MetroButton();
            this.search_customer_lbl = new MetroFramework.Controls.MetroLabel();
            this.total_price_title_lbl = new MetroFramework.Controls.MetroLabel();
            this.total_price_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customer_list_dgw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_list_dgw)).BeginInit();
            this.SuspendLayout();
            // 
            // customer_list_dgw
            // 
            this.customer_list_dgw.AllowUserToAddRows = false;
            this.customer_list_dgw.AllowUserToDeleteRows = false;
            this.customer_list_dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customer_list_dgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customer_id,
            this.first_name,
            this.last_name,
            this.phone,
            this.address});
            this.customer_list_dgw.Location = new System.Drawing.Point(63, 473);
            this.customer_list_dgw.Name = "customer_list_dgw";
            this.customer_list_dgw.ReadOnly = true;
            this.customer_list_dgw.RowTemplate.Height = 24;
            this.customer_list_dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customer_list_dgw.Size = new System.Drawing.Size(786, 290);
            this.customer_list_dgw.TabIndex = 0;
            this.customer_list_dgw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.customer_list_dgw_MouseClick);
            // 
            // customer_id
            // 
            this.customer_id.DataPropertyName = "customer_id";
            this.customer_id.HeaderText = "ID";
            this.customer_id.Name = "customer_id";
            this.customer_id.ReadOnly = true;
            this.customer_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.customer_id.Width = 30;
            // 
            // first_name
            // 
            this.first_name.DataPropertyName = "customer_first_name";
            this.first_name.HeaderText = "Ad";
            this.first_name.Name = "first_name";
            this.first_name.ReadOnly = true;
            this.first_name.Width = 110;
            // 
            // last_name
            // 
            this.last_name.DataPropertyName = "customer_last_name";
            this.last_name.HeaderText = "Soyad";
            this.last_name.Name = "last_name";
            this.last_name.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "customer_phone";
            this.phone.HeaderText = "Telefon";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // address
            // 
            this.address.DataPropertyName = "customer_address";
            this.address.HeaderText = "Adres";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 200;
            // 
            // search_tbx
            // 
            this.search_tbx.Location = new System.Drawing.Point(213, 410);
            this.search_tbx.Multiline = true;
            this.search_tbx.Name = "search_tbx";
            this.search_tbx.Size = new System.Drawing.Size(636, 32);
            this.search_tbx.TabIndex = 2;
            this.search_tbx.TextChanged += new System.EventHandler(this.customersearch_tbx_TextChanged);
            // 
            // ship_title_lbl
            // 
            this.ship_title_lbl.AutoSize = true;
            this.ship_title_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ship_title_lbl.Location = new System.Drawing.Point(155, 93);
            this.ship_title_lbl.Name = "ship_title_lbl";
            this.ship_title_lbl.Size = new System.Drawing.Size(181, 25);
            this.ship_title_lbl.TabIndex = 19;
            this.ship_title_lbl.Text = "Gönderi Bilgileri";
            // 
            // shiporders_lv
            // 
            this.shiporders_lv.CheckBoxes = true;
            this.shiporders_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.product_id,
            this.product_name,
            this.product_price});
            this.shiporders_lv.Location = new System.Drawing.Point(986, 528);
            this.shiporders_lv.Name = "shiporders_lv";
            this.shiporders_lv.Size = new System.Drawing.Size(390, 235);
            this.shiporders_lv.TabIndex = 24;
            this.shiporders_lv.UseCompatibleStateImageBehavior = false;
            this.shiporders_lv.View = System.Windows.Forms.View.Details;
            // 
            // product_id
            // 
            this.product_id.Text = "Sipariş ID";
            this.product_id.Width = 65;
            // 
            // product_name
            // 
            this.product_name.Text = "Ürün Adı";
            this.product_name.Width = 120;
            // 
            // product_price
            // 
            this.product_price.Text = "Ücreti";
            // 
            // order_title_lbl
            // 
            this.order_title_lbl.AutoSize = true;
            this.order_title_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.order_title_lbl.Location = new System.Drawing.Point(981, 473);
            this.order_title_lbl.Name = "order_title_lbl";
            this.order_title_lbl.Size = new System.Drawing.Size(143, 25);
            this.order_title_lbl.TabIndex = 25;
            this.order_title_lbl.Text = "Paket İçeriği";
            // 
            // selectall
            // 
            this.selectall.AutoSize = true;
            this.selectall.Location = new System.Drawing.Point(986, 782);
            this.selectall.Name = "selectall";
            this.selectall.Size = new System.Drawing.Size(110, 21);
            this.selectall.TabIndex = 26;
            this.selectall.Text = "Tümünü Seç";
            this.selectall.UseVisualStyleBackColor = true;
            this.selectall.CheckedChanged += new System.EventHandler(this.selectall_CheckedChanged);
            // 
            // customername_tbx
            // 
            // 
            // 
            // 
            this.customername_tbx.CustomButton.Image = null;
            this.customername_tbx.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.customername_tbx.CustomButton.Name = "";
            this.customername_tbx.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.customername_tbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.customername_tbx.CustomButton.TabIndex = 1;
            this.customername_tbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.customername_tbx.CustomButton.UseSelectable = true;
            this.customername_tbx.CustomButton.Visible = false;
            this.customername_tbx.Lines = new string[0];
            this.customername_tbx.Location = new System.Drawing.Point(213, 209);
            this.customername_tbx.MaxLength = 32767;
            this.customername_tbx.Name = "customername_tbx";
            this.customername_tbx.PasswordChar = '\0';
            this.customername_tbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.customername_tbx.SelectedText = "";
            this.customername_tbx.SelectionLength = 0;
            this.customername_tbx.SelectionStart = 0;
            this.customername_tbx.ShortcutsEnabled = true;
            this.customername_tbx.Size = new System.Drawing.Size(200, 30);
            this.customername_tbx.TabIndex = 29;
            this.customername_tbx.UseSelectable = true;
            this.customername_tbx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.customername_tbx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // category_cbx
            // 
            this.category_cbx.FormattingEnabled = true;
            this.category_cbx.ItemHeight = 24;
            this.category_cbx.Location = new System.Drawing.Point(1096, 105);
            this.category_cbx.Name = "category_cbx";
            this.category_cbx.Size = new System.Drawing.Size(162, 30);
            this.category_cbx.TabIndex = 30;
            this.category_cbx.UseSelectable = true;
            this.category_cbx.SelectedIndexChanged += new System.EventHandler(this.category_cbx_SelectedIndexChanged);
            // 
            // product_list_dgw
            // 
            this.product_list_dgw.AllowUserToAddRows = false;
            this.product_list_dgw.AllowUserToDeleteRows = false;
            this.product_list_dgw.AllowUserToResizeRows = false;
            this.product_list_dgw.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.product_list_dgw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.product_list_dgw.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.product_list_dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.product_list_dgw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.product_list_dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_list_dgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name,
            this.price,
            this.description});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.product_list_dgw.DefaultCellStyle = dataGridViewCellStyle2;
            this.product_list_dgw.EnableHeadersVisualStyles = false;
            this.product_list_dgw.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.product_list_dgw.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.product_list_dgw.Location = new System.Drawing.Point(981, 150);
            this.product_list_dgw.Margin = new System.Windows.Forms.Padding(0);
            this.product_list_dgw.Name = "product_list_dgw";
            this.product_list_dgw.ReadOnly = true;
            this.product_list_dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.product_list_dgw.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.product_list_dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.product_list_dgw.RowTemplate.Height = 24;
            this.product_list_dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.product_list_dgw.Size = new System.Drawing.Size(760, 292);
            this.product_list_dgw.TabIndex = 31;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ID.DataPropertyName = "product_id";
            this.ID.FillWeight = 120F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Width = 58;
            // 
            // name
            // 
            this.name.DataPropertyName = "product_name";
            this.name.FillWeight = 120F;
            this.name.HeaderText = "Ürün Adı";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 130;
            // 
            // price
            // 
            this.price.DataPropertyName = "product_price";
            this.price.FillWeight = 120F;
            this.price.HeaderText = "Ücreti";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // description
            // 
            this.description.DataPropertyName = "product_description";
            this.description.FillWeight = 120F;
            this.description.HeaderText = "Açıklama";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 250;
            // 
            // add_product_btn
            // 
            this.add_product_btn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.add_product_btn.Location = new System.Drawing.Point(1472, 528);
            this.add_product_btn.Name = "add_product_btn";
            this.add_product_btn.Size = new System.Drawing.Size(269, 37);
            this.add_product_btn.TabIndex = 32;
            this.add_product_btn.Text = "Ekle";
            this.add_product_btn.UseSelectable = true;
            this.add_product_btn.Click += new System.EventHandler(this.add_product_btn_Click);
            // 
            // ship_number
            // 
            this.ship_number.Location = new System.Drawing.Point(213, 159);
            this.ship_number.Multiline = true;
            this.ship_number.Name = "ship_number";
            this.ship_number.ReadOnly = true;
            this.ship_number.Size = new System.Drawing.Size(200, 30);
            this.ship_number.TabIndex = 33;
            // 
            // shipment_number_lbl
            // 
            this.shipment_number_lbl.AutoSize = true;
            this.shipment_number_lbl.Location = new System.Drawing.Point(91, 166);
            this.shipment_number_lbl.Name = "shipment_number_lbl";
            this.shipment_number_lbl.Size = new System.Drawing.Size(85, 20);
            this.shipment_number_lbl.TabIndex = 34;
            this.shipment_number_lbl.Text = "Gönderi No:";
            // 
            // cname_lbl
            // 
            this.cname_lbl.AutoSize = true;
            this.cname_lbl.Location = new System.Drawing.Point(94, 211);
            this.cname_lbl.Name = "cname_lbl";
            this.cname_lbl.Size = new System.Drawing.Size(82, 20);
            this.cname_lbl.TabIndex = 35;
            this.cname_lbl.Text = "Müşteri Adı:";
            // 
            // shipaddress_tbx
            // 
            // 
            // 
            // 
            this.shipaddress_tbx.CustomButton.Image = null;
            this.shipaddress_tbx.CustomButton.Location = new System.Drawing.Point(84, 2);
            this.shipaddress_tbx.CustomButton.Name = "";
            this.shipaddress_tbx.CustomButton.Size = new System.Drawing.Size(113, 113);
            this.shipaddress_tbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.shipaddress_tbx.CustomButton.TabIndex = 1;
            this.shipaddress_tbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.shipaddress_tbx.CustomButton.UseSelectable = true;
            this.shipaddress_tbx.CustomButton.Visible = false;
            this.shipaddress_tbx.Lines = new string[0];
            this.shipaddress_tbx.Location = new System.Drawing.Point(213, 260);
            this.shipaddress_tbx.MaxLength = 32767;
            this.shipaddress_tbx.Multiline = true;
            this.shipaddress_tbx.Name = "shipaddress_tbx";
            this.shipaddress_tbx.PasswordChar = '\0';
            this.shipaddress_tbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.shipaddress_tbx.SelectedText = "";
            this.shipaddress_tbx.SelectionLength = 0;
            this.shipaddress_tbx.SelectionStart = 0;
            this.shipaddress_tbx.ShortcutsEnabled = true;
            this.shipaddress_tbx.Size = new System.Drawing.Size(200, 118);
            this.shipaddress_tbx.TabIndex = 36;
            this.shipaddress_tbx.UseSelectable = true;
            this.shipaddress_tbx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.shipaddress_tbx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // address_lbl
            // 
            this.address_lbl.AutoSize = true;
            this.address_lbl.Location = new System.Drawing.Point(128, 273);
            this.address_lbl.Name = "address_lbl";
            this.address_lbl.Size = new System.Drawing.Size(48, 20);
            this.address_lbl.TabIndex = 37;
            this.address_lbl.Text = "Adres:";
            // 
            // shiptype_cbx
            // 
            this.shiptype_cbx.FormattingEnabled = true;
            this.shiptype_cbx.ItemHeight = 24;
            this.shiptype_cbx.Items.AddRange(new object[] {
            "Motorlu Kurye",
            "Yaya Kurye"});
            this.shiptype_cbx.Location = new System.Drawing.Point(636, 156);
            this.shiptype_cbx.Name = "shiptype_cbx";
            this.shiptype_cbx.Size = new System.Drawing.Size(213, 30);
            this.shiptype_cbx.TabIndex = 38;
            this.shiptype_cbx.Tag = "";
            this.shiptype_cbx.UseSelectable = true;
            // 
            // personel_cbx
            // 
            this.personel_cbx.FormattingEnabled = true;
            this.personel_cbx.ItemHeight = 24;
            this.personel_cbx.Items.AddRange(new object[] {
            "Motorlu Kurye",
            "Yaya Kurye"});
            this.personel_cbx.Location = new System.Drawing.Point(636, 209);
            this.personel_cbx.Name = "personel_cbx";
            this.personel_cbx.Size = new System.Drawing.Size(213, 30);
            this.personel_cbx.TabIndex = 39;
            this.personel_cbx.UseSelectable = true;
            // 
            // ship_datetimepicker
            // 
            this.ship_datetimepicker.Location = new System.Drawing.Point(636, 257);
            this.ship_datetimepicker.MinimumSize = new System.Drawing.Size(0, 30);
            this.ship_datetimepicker.Name = "ship_datetimepicker";
            this.ship_datetimepicker.Size = new System.Drawing.Size(213, 30);
            this.ship_datetimepicker.TabIndex = 40;
            // 
            // shipdetails_tbx
            // 
            // 
            // 
            // 
            this.shipdetails_tbx.CustomButton.Image = null;
            this.shipdetails_tbx.CustomButton.Location = new System.Drawing.Point(145, 2);
            this.shipdetails_tbx.CustomButton.Name = "";
            this.shipdetails_tbx.CustomButton.Size = new System.Drawing.Size(65, 65);
            this.shipdetails_tbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.shipdetails_tbx.CustomButton.TabIndex = 1;
            this.shipdetails_tbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.shipdetails_tbx.CustomButton.UseSelectable = true;
            this.shipdetails_tbx.CustomButton.Visible = false;
            this.shipdetails_tbx.Lines = new string[0];
            this.shipdetails_tbx.Location = new System.Drawing.Point(636, 308);
            this.shipdetails_tbx.MaxLength = 32767;
            this.shipdetails_tbx.Multiline = true;
            this.shipdetails_tbx.Name = "shipdetails_tbx";
            this.shipdetails_tbx.PasswordChar = '\0';
            this.shipdetails_tbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.shipdetails_tbx.SelectedText = "";
            this.shipdetails_tbx.SelectionLength = 0;
            this.shipdetails_tbx.SelectionStart = 0;
            this.shipdetails_tbx.ShortcutsEnabled = true;
            this.shipdetails_tbx.Size = new System.Drawing.Size(213, 70);
            this.shipdetails_tbx.TabIndex = 41;
            this.shipdetails_tbx.UseSelectable = true;
            this.shipdetails_tbx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.shipdetails_tbx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // shiptype_lbl
            // 
            this.shiptype_lbl.AutoSize = true;
            this.shiptype_lbl.Location = new System.Drawing.Point(503, 159);
            this.shiptype_lbl.Name = "shiptype_lbl";
            this.shiptype_lbl.Size = new System.Drawing.Size(88, 20);
            this.shiptype_lbl.TabIndex = 42;
            this.shiptype_lbl.Text = "Gönderi Tipi:";
            // 
            // carrier_lbl
            // 
            this.carrier_lbl.AutoSize = true;
            this.carrier_lbl.Location = new System.Drawing.Point(482, 212);
            this.carrier_lbl.Name = "carrier_lbl";
            this.carrier_lbl.Size = new System.Drawing.Size(109, 20);
            this.carrier_lbl.TabIndex = 43;
            this.carrier_lbl.Text = "Kurye Personeli:";
            // 
            // shiptime_lbl
            // 
            this.shiptime_lbl.AutoSize = true;
            this.shiptime_lbl.Location = new System.Drawing.Point(479, 260);
            this.shiptime_lbl.Name = "shiptime_lbl";
            this.shiptime_lbl.Size = new System.Drawing.Size(112, 20);
            this.shiptime_lbl.TabIndex = 44;
            this.shiptime_lbl.Text = "Gönderi Zamanı:";
            // 
            // details_lbl
            // 
            this.details_lbl.AutoSize = true;
            this.details_lbl.Location = new System.Drawing.Point(524, 308);
            this.details_lbl.Name = "details_lbl";
            this.details_lbl.Size = new System.Drawing.Size(67, 20);
            this.details_lbl.TabIndex = 45;
            this.details_lbl.Text = "Açıklama:";
            // 
            // cancel_product
            // 
            this.cancel_product.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.cancel_product.Location = new System.Drawing.Point(1472, 627);
            this.cancel_product.Name = "cancel_product";
            this.cancel_product.Size = new System.Drawing.Size(269, 37);
            this.cancel_product.TabIndex = 46;
            this.cancel_product.Text = "İptal Et";
            this.cancel_product.UseSelectable = true;
            this.cancel_product.Click += new System.EventHandler(this.cancel_product_Click);
            // 
            // product_title
            // 
            this.product_title.AutoSize = true;
            this.product_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.product_title.Location = new System.Drawing.Point(976, 60);
            this.product_title.Name = "product_title";
            this.product_title.Size = new System.Drawing.Size(148, 25);
            this.product_title.TabIndex = 47;
            this.product_title.Text = "Ürün Bilgileri";
            // 
            // categorycbx_lbl
            // 
            this.categorycbx_lbl.AutoSize = true;
            this.categorycbx_lbl.Location = new System.Drawing.Point(980, 112);
            this.categorycbx_lbl.Name = "categorycbx_lbl";
            this.categorycbx_lbl.Size = new System.Drawing.Size(63, 20);
            this.categorycbx_lbl.TabIndex = 48;
            this.categorycbx_lbl.Text = "Kategori:";
            // 
            // search_product_tbx
            // 
            // 
            // 
            // 
            this.search_product_tbx.CustomButton.Image = null;
            this.search_product_tbx.CustomButton.Location = new System.Drawing.Point(312, 2);
            this.search_product_tbx.CustomButton.Name = "";
            this.search_product_tbx.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.search_product_tbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.search_product_tbx.CustomButton.TabIndex = 1;
            this.search_product_tbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.search_product_tbx.CustomButton.UseSelectable = true;
            this.search_product_tbx.CustomButton.Visible = false;
            this.search_product_tbx.Lines = new string[0];
            this.search_product_tbx.Location = new System.Drawing.Point(1401, 105);
            this.search_product_tbx.MaxLength = 32767;
            this.search_product_tbx.Multiline = true;
            this.search_product_tbx.Name = "search_product_tbx";
            this.search_product_tbx.PasswordChar = '\0';
            this.search_product_tbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.search_product_tbx.SelectedText = "";
            this.search_product_tbx.SelectionLength = 0;
            this.search_product_tbx.SelectionStart = 0;
            this.search_product_tbx.ShortcutsEnabled = true;
            this.search_product_tbx.Size = new System.Drawing.Size(340, 30);
            this.search_product_tbx.TabIndex = 49;
            this.search_product_tbx.UseSelectable = true;
            this.search_product_tbx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.search_product_tbx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.search_product_tbx.TextChanged += new System.EventHandler(this.search_product_tbx_TextChanged);
            // 
            // search_prod_lbl
            // 
            this.search_prod_lbl.AutoSize = true;
            this.search_prod_lbl.Location = new System.Drawing.Point(1343, 108);
            this.search_prod_lbl.Name = "search_prod_lbl";
            this.search_prod_lbl.Size = new System.Drawing.Size(33, 20);
            this.search_prod_lbl.TabIndex = 50;
            this.search_prod_lbl.Text = "Ara:";
            // 
            // newshipment_btn
            // 
            this.newshipment_btn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.newshipment_btn.Location = new System.Drawing.Point(1472, 862);
            this.newshipment_btn.Name = "newshipment_btn";
            this.newshipment_btn.Size = new System.Drawing.Size(269, 61);
            this.newshipment_btn.TabIndex = 51;
            this.newshipment_btn.Text = "Yeni Gönderi Oluştur";
            this.newshipment_btn.UseSelectable = true;
            this.newshipment_btn.Click += new System.EventHandler(this.newshipment_btn_Click);
            // 
            // search_customer_lbl
            // 
            this.search_customer_lbl.AutoSize = true;
            this.search_customer_lbl.Location = new System.Drawing.Point(93, 410);
            this.search_customer_lbl.Name = "search_customer_lbl";
            this.search_customer_lbl.Size = new System.Drawing.Size(83, 20);
            this.search_customer_lbl.TabIndex = 52;
            this.search_customer_lbl.Text = "Müşteri Ara:";
            // 
            // total_price_title_lbl
            // 
            this.total_price_title_lbl.AutoSize = true;
            this.total_price_title_lbl.Location = new System.Drawing.Point(1154, 782);
            this.total_price_title_lbl.Name = "total_price_title_lbl";
            this.total_price_title_lbl.Size = new System.Drawing.Size(94, 20);
            this.total_price_title_lbl.TabIndex = 53;
            this.total_price_title_lbl.Text = "Toplam Ücret:";
            // 
            // total_price_lbl
            // 
            this.total_price_lbl.AutoSize = true;
            this.total_price_lbl.Location = new System.Drawing.Point(1268, 784);
            this.total_price_lbl.Name = "total_price_lbl";
            this.total_price_lbl.Size = new System.Drawing.Size(52, 17);
            this.total_price_lbl.TabIndex = 54;
            this.total_price_lbl.Text = "0.0000";
            // 
            // OrderShipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1835, 1040);
            this.Controls.Add(this.total_price_lbl);
            this.Controls.Add(this.total_price_title_lbl);
            this.Controls.Add(this.search_customer_lbl);
            this.Controls.Add(this.newshipment_btn);
            this.Controls.Add(this.search_prod_lbl);
            this.Controls.Add(this.search_product_tbx);
            this.Controls.Add(this.categorycbx_lbl);
            this.Controls.Add(this.product_title);
            this.Controls.Add(this.cancel_product);
            this.Controls.Add(this.details_lbl);
            this.Controls.Add(this.shiptime_lbl);
            this.Controls.Add(this.carrier_lbl);
            this.Controls.Add(this.shiptype_lbl);
            this.Controls.Add(this.shipdetails_tbx);
            this.Controls.Add(this.ship_datetimepicker);
            this.Controls.Add(this.personel_cbx);
            this.Controls.Add(this.shiptype_cbx);
            this.Controls.Add(this.address_lbl);
            this.Controls.Add(this.shipaddress_tbx);
            this.Controls.Add(this.cname_lbl);
            this.Controls.Add(this.shipment_number_lbl);
            this.Controls.Add(this.ship_number);
            this.Controls.Add(this.add_product_btn);
            this.Controls.Add(this.product_list_dgw);
            this.Controls.Add(this.category_cbx);
            this.Controls.Add(this.customername_tbx);
            this.Controls.Add(this.selectall);
            this.Controls.Add(this.order_title_lbl);
            this.Controls.Add(this.shiporders_lv);
            this.Controls.Add(this.ship_title_lbl);
            this.Controls.Add(this.search_tbx);
            this.Controls.Add(this.customer_list_dgw);
            this.Name = "OrderShipment";
            this.Text = "Yeni Bir Gönderi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Shipments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customer_list_dgw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_list_dgw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customer_list_dgw;
        private System.Windows.Forms.TextBox search_tbx;
        private System.Windows.Forms.Label ship_title_lbl;
        private System.Windows.Forms.ListView shiporders_lv;
        private System.Windows.Forms.ColumnHeader product_name;
        private System.Windows.Forms.ColumnHeader product_price;
        private System.Windows.Forms.ColumnHeader product_id;
        private System.Windows.Forms.Label order_title_lbl;
        private System.Windows.Forms.CheckBox selectall;
        private MetroFramework.Controls.MetroTextBox customername_tbx;
        private MetroFramework.Controls.MetroComboBox category_cbx;
        private MetroFramework.Controls.MetroGrid product_list_dgw;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private MetroFramework.Controls.MetroButton add_product_btn;
        private System.Windows.Forms.TextBox ship_number;
        private MetroFramework.Controls.MetroLabel shipment_number_lbl;
        private MetroFramework.Controls.MetroLabel cname_lbl;
        private MetroFramework.Controls.MetroTextBox shipaddress_tbx;
        private MetroFramework.Controls.MetroLabel address_lbl;
        private MetroFramework.Controls.MetroComboBox shiptype_cbx;
        private MetroFramework.Controls.MetroComboBox personel_cbx;
        private MetroFramework.Controls.MetroDateTime ship_datetimepicker;
        private MetroFramework.Controls.MetroTextBox shipdetails_tbx;
        private MetroFramework.Controls.MetroLabel shiptype_lbl;
        private MetroFramework.Controls.MetroLabel carrier_lbl;
        private MetroFramework.Controls.MetroLabel shiptime_lbl;
        private MetroFramework.Controls.MetroLabel details_lbl;
        private MetroFramework.Controls.MetroButton cancel_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.Label product_title;
        private MetroFramework.Controls.MetroLabel categorycbx_lbl;
        private MetroFramework.Controls.MetroTextBox search_product_tbx;
        private MetroFramework.Controls.MetroLabel search_prod_lbl;
        private MetroFramework.Controls.MetroButton newshipment_btn;
        private MetroFramework.Controls.MetroLabel search_customer_lbl;
        private MetroFramework.Controls.MetroLabel total_price_title_lbl;
        private System.Windows.Forms.Label total_price_lbl;
    }
}