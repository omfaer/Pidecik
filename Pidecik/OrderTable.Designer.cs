namespace Pidecik
{
    partial class OrderTable
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.selectall = new System.Windows.Forms.CheckBox();
            this.allorders_lbl = new System.Windows.Forms.Label();
            this.tpay_lbl = new System.Windows.Forms.Label();
            this.totalpay_lbl = new System.Windows.Forms.Label();
            this.selectedpay_lbl = new System.Windows.Forms.Label();
            this.spay_lbl = new System.Windows.Forms.Label();
            this.category_cbx = new MetroFramework.Controls.MetroComboBox();
            this.product_list_dgw = new MetroFramework.Controls.MetroGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.neworder_btn = new MetroFramework.Controls.MetroButton();
            this.oamount_tbx = new MetroFramework.Controls.MetroTextBox();
            this.oamount_lbl = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.category_lbl = new MetroFramework.Controls.MetroLabel();
            this.productsearch_lbl = new MetroFramework.Controls.MetroLabel();
            this.orderlist_lv = new System.Windows.Forms.ListView();
            this.order_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.product_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.order_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.order_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.order_status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pay_btn = new MetroFramework.Controls.MetroButton();
            this.cancelorder_btn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.product_list_dgw)).BeginInit();
            this.SuspendLayout();
            // 
            // selectall
            // 
            this.selectall.AutoSize = true;
            this.selectall.Location = new System.Drawing.Point(1078, 524);
            this.selectall.Name = "selectall";
            this.selectall.Size = new System.Drawing.Size(110, 21);
            this.selectall.TabIndex = 1;
            this.selectall.Text = "Tümünü Seç";
            this.selectall.UseVisualStyleBackColor = true;
            this.selectall.CheckedChanged += new System.EventHandler(this.selectall_CheckedChanged);
            // 
            // allorders_lbl
            // 
            this.allorders_lbl.AutoSize = true;
            this.allorders_lbl.Location = new System.Drawing.Point(1085, 150);
            this.allorders_lbl.Name = "allorders_lbl";
            this.allorders_lbl.Size = new System.Drawing.Size(99, 17);
            this.allorders_lbl.TabIndex = 3;
            this.allorders_lbl.Text = "Tüm Siparişler";
            // 
            // tpay_lbl
            // 
            this.tpay_lbl.AutoSize = true;
            this.tpay_lbl.Location = new System.Drawing.Point(1602, 528);
            this.tpay_lbl.Name = "tpay_lbl";
            this.tpay_lbl.Size = new System.Drawing.Size(141, 17);
            this.tpay_lbl.TabIndex = 11;
            this.tpay_lbl.Text = "Kalan Toplam Ücret: ";
            // 
            // totalpay_lbl
            // 
            this.totalpay_lbl.AutoSize = true;
            this.totalpay_lbl.Location = new System.Drawing.Point(1752, 528);
            this.totalpay_lbl.Name = "totalpay_lbl";
            this.totalpay_lbl.Size = new System.Drawing.Size(103, 17);
            this.totalpay_lbl.TabIndex = 12;
            this.totalpay_lbl.Text = "Hiç Sipariş Yok";
            // 
            // selectedpay_lbl
            // 
            this.selectedpay_lbl.AutoSize = true;
            this.selectedpay_lbl.Location = new System.Drawing.Point(1752, 554);
            this.selectedpay_lbl.Name = "selectedpay_lbl";
            this.selectedpay_lbl.Size = new System.Drawing.Size(100, 17);
            this.selectedpay_lbl.TabIndex = 13;
            this.selectedpay_lbl.Text = "Bir Sipariş Seç";
            // 
            // spay_lbl
            // 
            this.spay_lbl.AutoSize = true;
            this.spay_lbl.Location = new System.Drawing.Point(1643, 554);
            this.spay_lbl.Name = "spay_lbl";
            this.spay_lbl.Size = new System.Drawing.Size(100, 17);
            this.spay_lbl.TabIndex = 14;
            this.spay_lbl.Text = "Seçilen Ücret: ";
            // 
            // category_cbx
            // 
            this.category_cbx.FormattingEnabled = true;
            this.category_cbx.ItemHeight = 24;
            this.category_cbx.Location = new System.Drawing.Point(196, 136);
            this.category_cbx.Name = "category_cbx";
            this.category_cbx.Size = new System.Drawing.Size(149, 30);
            this.category_cbx.TabIndex = 18;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.product_list_dgw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.product_list_dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_list_dgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name,
            this.price,
            this.description});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.product_list_dgw.DefaultCellStyle = dataGridViewCellStyle5;
            this.product_list_dgw.EnableHeadersVisualStyles = false;
            this.product_list_dgw.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.product_list_dgw.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.product_list_dgw.Location = new System.Drawing.Point(80, 199);
            this.product_list_dgw.Margin = new System.Windows.Forms.Padding(0);
            this.product_list_dgw.Name = "product_list_dgw";
            this.product_list_dgw.ReadOnly = true;
            this.product_list_dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.product_list_dgw.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.product_list_dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.product_list_dgw.RowTemplate.Height = 24;
            this.product_list_dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.product_list_dgw.Size = new System.Drawing.Size(760, 292);
            this.product_list_dgw.TabIndex = 19;
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
            // neworder_btn
            // 
            this.neworder_btn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.neworder_btn.Location = new System.Drawing.Point(658, 596);
            this.neworder_btn.Name = "neworder_btn";
            this.neworder_btn.Size = new System.Drawing.Size(182, 45);
            this.neworder_btn.TabIndex = 20;
            this.neworder_btn.Text = "Yeni Sipariş Ekle";
            this.neworder_btn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.neworder_btn.UseSelectable = true;
            this.neworder_btn.Click += new System.EventHandler(this.neworder_btn_Click);
            // 
            // oamount_tbx
            // 
            // 
            // 
            // 
            this.oamount_tbx.CustomButton.Image = null;
            this.oamount_tbx.CustomButton.Location = new System.Drawing.Point(154, 2);
            this.oamount_tbx.CustomButton.Name = "";
            this.oamount_tbx.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.oamount_tbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.oamount_tbx.CustomButton.TabIndex = 1;
            this.oamount_tbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.oamount_tbx.CustomButton.UseSelectable = true;
            this.oamount_tbx.CustomButton.Visible = false;
            this.oamount_tbx.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.oamount_tbx.Lines = new string[0];
            this.oamount_tbx.Location = new System.Drawing.Point(658, 525);
            this.oamount_tbx.MaxLength = 32767;
            this.oamount_tbx.Name = "oamount_tbx";
            this.oamount_tbx.PasswordChar = '\0';
            this.oamount_tbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.oamount_tbx.SelectedText = "";
            this.oamount_tbx.SelectionLength = 0;
            this.oamount_tbx.SelectionStart = 0;
            this.oamount_tbx.ShortcutsEnabled = true;
            this.oamount_tbx.Size = new System.Drawing.Size(182, 30);
            this.oamount_tbx.TabIndex = 21;
            this.oamount_tbx.UseSelectable = true;
            this.oamount_tbx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.oamount_tbx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // oamount_lbl
            // 
            this.oamount_lbl.AutoSize = true;
            this.oamount_lbl.Location = new System.Drawing.Point(530, 529);
            this.oamount_lbl.Name = "oamount_lbl";
            this.oamount_lbl.Size = new System.Drawing.Size(96, 20);
            this.oamount_lbl.TabIndex = 22;
            this.oamount_lbl.Text = "Sipariş Miktarı:";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(348, 2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(464, 137);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(376, 30);
            this.metroTextBox1.TabIndex = 23;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // category_lbl
            // 
            this.category_lbl.AutoSize = true;
            this.category_lbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.category_lbl.Location = new System.Drawing.Point(78, 137);
            this.category_lbl.Name = "category_lbl";
            this.category_lbl.Size = new System.Drawing.Size(83, 25);
            this.category_lbl.TabIndex = 24;
            this.category_lbl.Text = "Kategori:";
            // 
            // productsearch_lbl
            // 
            this.productsearch_lbl.AutoSize = true;
            this.productsearch_lbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.productsearch_lbl.Location = new System.Drawing.Point(387, 137);
            this.productsearch_lbl.Name = "productsearch_lbl";
            this.productsearch_lbl.Size = new System.Drawing.Size(43, 25);
            this.productsearch_lbl.TabIndex = 25;
            this.productsearch_lbl.Text = "Ara:";
            // 
            // orderlist_lv
            // 
            this.orderlist_lv.CheckBoxes = true;
            this.orderlist_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.order_id,
            this.product_name,
            this.order_price,
            this.order_time,
            this.order_status});
            this.orderlist_lv.Location = new System.Drawing.Point(1078, 199);
            this.orderlist_lv.Name = "orderlist_lv";
            this.orderlist_lv.Size = new System.Drawing.Size(758, 292);
            this.orderlist_lv.TabIndex = 28;
            this.orderlist_lv.UseCompatibleStateImageBehavior = false;
            this.orderlist_lv.View = System.Windows.Forms.View.Details;
            this.orderlist_lv.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.orderlist_lv_ItemChecked);
            // 
            // order_id
            // 
            this.order_id.Text = "ID";
            // 
            // product_name
            // 
            this.product_name.Text = "Ürün Adı";
            this.product_name.Width = 130;
            // 
            // order_price
            // 
            this.order_price.Text = "Ücreti";
            this.order_price.Width = 100;
            // 
            // order_time
            // 
            this.order_time.Text = "Sipariş Zamanı";
            this.order_time.Width = 150;
            // 
            // order_status
            // 
            this.order_status.Text = "Ödeme Durumu";
            this.order_status.Width = 120;
            // 
            // pay_btn
            // 
            this.pay_btn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.pay_btn.Location = new System.Drawing.Point(1654, 596);
            this.pay_btn.Name = "pay_btn";
            this.pay_btn.Size = new System.Drawing.Size(182, 45);
            this.pay_btn.TabIndex = 29;
            this.pay_btn.Text = "Ödeme Yap";
            this.pay_btn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pay_btn.UseSelectable = true;
            this.pay_btn.Click += new System.EventHandler(this.pay_btn_Click);
            // 
            // cancelorder_btn
            // 
            this.cancelorder_btn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.cancelorder_btn.Location = new System.Drawing.Point(1078, 596);
            this.cancelorder_btn.Name = "cancelorder_btn";
            this.cancelorder_btn.Size = new System.Drawing.Size(194, 45);
            this.cancelorder_btn.TabIndex = 30;
            this.cancelorder_btn.Text = "Siparişi İptal Et";
            this.cancelorder_btn.UseSelectable = true;
            this.cancelorder_btn.Click += new System.EventHandler(this.cancelorder_btn_Click);
            // 
            // OrderTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 768);
            this.Controls.Add(this.cancelorder_btn);
            this.Controls.Add(this.pay_btn);
            this.Controls.Add(this.orderlist_lv);
            this.Controls.Add(this.productsearch_lbl);
            this.Controls.Add(this.category_lbl);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.oamount_lbl);
            this.Controls.Add(this.oamount_tbx);
            this.Controls.Add(this.neworder_btn);
            this.Controls.Add(this.product_list_dgw);
            this.Controls.Add(this.category_cbx);
            this.Controls.Add(this.spay_lbl);
            this.Controls.Add(this.selectedpay_lbl);
            this.Controls.Add(this.totalpay_lbl);
            this.Controls.Add(this.tpay_lbl);
            this.Controls.Add(this.allorders_lbl);
            this.Controls.Add(this.selectall);
            this.Name = "OrderTable";
            this.Resizable = false;
            this.Text = "OrderTable";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OrderTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.product_list_dgw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox selectall;
        private System.Windows.Forms.Label allorders_lbl;
        private System.Windows.Forms.Label tpay_lbl;
        private System.Windows.Forms.Label totalpay_lbl;
        private System.Windows.Forms.Label selectedpay_lbl;
        private System.Windows.Forms.Label spay_lbl;
        private MetroFramework.Controls.MetroComboBox category_cbx;
        private MetroFramework.Controls.MetroGrid product_list_dgw;
        private MetroFramework.Controls.MetroButton neworder_btn;
        private MetroFramework.Controls.MetroTextBox oamount_tbx;
        private MetroFramework.Controls.MetroLabel oamount_lbl;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel category_lbl;
        private MetroFramework.Controls.MetroLabel productsearch_lbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.ListView orderlist_lv;
        private System.Windows.Forms.ColumnHeader order_id;
        private System.Windows.Forms.ColumnHeader product_name;
        private System.Windows.Forms.ColumnHeader order_price;
        private System.Windows.Forms.ColumnHeader order_time;
        private System.Windows.Forms.ColumnHeader order_status;
        private MetroFramework.Controls.MetroButton pay_btn;
        private MetroFramework.Controls.MetroButton cancelorder_btn;
    }
}