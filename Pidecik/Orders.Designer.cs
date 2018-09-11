namespace Pidecik
{
    partial class Orders
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
            this.orders_dgw = new System.Windows.Forms.DataGridView();
            this.ordersearch_lbl = new MetroFramework.Controls.MetroLabel();
            this.datetime_start = new MetroFramework.Controls.MetroDateTime();
            this.datetime_end = new MetroFramework.Controls.MetroDateTime();
            this.order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_search_tbx = new MetroFramework.Controls.MetroTextBox();
            this.dt_start_lbl = new MetroFramework.Controls.MetroLabel();
            this.dt_end_lbl = new MetroFramework.Controls.MetroLabel();
            this.prod_name_lbl = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.orders_dgw)).BeginInit();
            this.SuspendLayout();
            // 
            // orders_dgw
            // 
            this.orders_dgw.AllowUserToAddRows = false;
            this.orders_dgw.AllowUserToDeleteRows = false;
            this.orders_dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orders_dgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order_id,
            this.product_name,
            this.order_price,
            this.order_time,
            this.order_type,
            this.order_status});
            this.orders_dgw.Location = new System.Drawing.Point(170, 255);
            this.orders_dgw.Name = "orders_dgw";
            this.orders_dgw.ReadOnly = true;
            this.orders_dgw.RowTemplate.Height = 24;
            this.orders_dgw.Size = new System.Drawing.Size(843, 337);
            this.orders_dgw.TabIndex = 3;
            // 
            // ordersearch_lbl
            // 
            this.ordersearch_lbl.AutoSize = true;
            this.ordersearch_lbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ordersearch_lbl.Location = new System.Drawing.Point(170, 183);
            this.ordersearch_lbl.Name = "ordersearch_lbl";
            this.ordersearch_lbl.Size = new System.Drawing.Size(98, 25);
            this.ordersearch_lbl.TabIndex = 4;
            this.ordersearch_lbl.Text = "Sipariş Ara:";
            // 
            // datetime_start
            // 
            this.datetime_start.Location = new System.Drawing.Point(535, 183);
            this.datetime_start.MinimumSize = new System.Drawing.Size(0, 30);
            this.datetime_start.Name = "datetime_start";
            this.datetime_start.Size = new System.Drawing.Size(218, 30);
            this.datetime_start.TabIndex = 5;
            this.datetime_start.Value = new System.DateTime(2018, 8, 29, 7, 6, 47, 0);
            this.datetime_start.ValueChanged += new System.EventHandler(this.datetime_start_ValueChanged);
            // 
            // datetime_end
            // 
            this.datetime_end.Location = new System.Drawing.Point(789, 183);
            this.datetime_end.MinimumSize = new System.Drawing.Size(0, 30);
            this.datetime_end.Name = "datetime_end";
            this.datetime_end.Size = new System.Drawing.Size(224, 30);
            this.datetime_end.TabIndex = 6;
            this.datetime_end.ValueChanged += new System.EventHandler(this.datetime_end_ValueChanged);
            // 
            // order_id
            // 
            this.order_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.order_id.DataPropertyName = "order_id";
            this.order_id.HeaderText = "SID";
            this.order_id.Name = "order_id";
            this.order_id.ReadOnly = true;
            this.order_id.Width = 59;
            // 
            // product_name
            // 
            this.product_name.DataPropertyName = "product_name";
            this.product_name.HeaderText = "Ürün Adı";
            this.product_name.Name = "product_name";
            this.product_name.ReadOnly = true;
            this.product_name.Width = 140;
            // 
            // order_price
            // 
            this.order_price.DataPropertyName = "order_price";
            this.order_price.HeaderText = "Ücreti";
            this.order_price.Name = "order_price";
            this.order_price.ReadOnly = true;
            this.order_price.Width = 75;
            // 
            // order_time
            // 
            this.order_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.order_time.DataPropertyName = "order_time";
            this.order_time.HeaderText = "Sipariş Zamanı";
            this.order_time.Name = "order_time";
            this.order_time.ReadOnly = true;
            this.order_time.Width = 120;
            // 
            // order_type
            // 
            this.order_type.DataPropertyName = "order_type";
            this.order_type.HeaderText = "Sipariş Tipi";
            this.order_type.Name = "order_type";
            this.order_type.ReadOnly = true;
            this.order_type.Width = 75;
            // 
            // order_status
            // 
            this.order_status.DataPropertyName = "order_status";
            this.order_status.HeaderText = "Ödeme Durumu";
            this.order_status.Name = "order_status";
            this.order_status.ReadOnly = true;
            this.order_status.Width = 135;
            // 
            // order_search_tbx
            // 
            // 
            // 
            // 
            this.order_search_tbx.CustomButton.Image = null;
            this.order_search_tbx.CustomButton.Location = new System.Drawing.Point(186, 2);
            this.order_search_tbx.CustomButton.Name = "";
            this.order_search_tbx.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.order_search_tbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.order_search_tbx.CustomButton.TabIndex = 1;
            this.order_search_tbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.order_search_tbx.CustomButton.UseSelectable = true;
            this.order_search_tbx.CustomButton.Visible = false;
            this.order_search_tbx.Lines = new string[0];
            this.order_search_tbx.Location = new System.Drawing.Point(300, 183);
            this.order_search_tbx.MaxLength = 32767;
            this.order_search_tbx.Multiline = true;
            this.order_search_tbx.Name = "order_search_tbx";
            this.order_search_tbx.PasswordChar = '\0';
            this.order_search_tbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.order_search_tbx.SelectedText = "";
            this.order_search_tbx.SelectionLength = 0;
            this.order_search_tbx.SelectionStart = 0;
            this.order_search_tbx.ShortcutsEnabled = true;
            this.order_search_tbx.Size = new System.Drawing.Size(214, 30);
            this.order_search_tbx.TabIndex = 7;
            this.order_search_tbx.UseSelectable = true;
            this.order_search_tbx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.order_search_tbx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.order_search_tbx.TextChanged += new System.EventHandler(this.order_search_tbx_TextChanged);
            // 
            // dt_start_lbl
            // 
            this.dt_start_lbl.AutoSize = true;
            this.dt_start_lbl.Location = new System.Drawing.Point(535, 147);
            this.dt_start_lbl.Name = "dt_start_lbl";
            this.dt_start_lbl.Size = new System.Drawing.Size(105, 20);
            this.dt_start_lbl.TabIndex = 8;
            this.dt_start_lbl.Text = "Başlangıç Tarihi:";
            // 
            // dt_end_lbl
            // 
            this.dt_end_lbl.AutoSize = true;
            this.dt_end_lbl.Location = new System.Drawing.Point(789, 147);
            this.dt_end_lbl.Name = "dt_end_lbl";
            this.dt_end_lbl.Size = new System.Drawing.Size(72, 20);
            this.dt_end_lbl.TabIndex = 9;
            this.dt_end_lbl.Text = "Bitiş Tarihi:";
            // 
            // prod_name_lbl
            // 
            this.prod_name_lbl.AutoSize = true;
            this.prod_name_lbl.Location = new System.Drawing.Point(300, 147);
            this.prod_name_lbl.Name = "prod_name_lbl";
            this.prod_name_lbl.Size = new System.Drawing.Size(67, 20);
            this.prod_name_lbl.TabIndex = 10;
            this.prod_name_lbl.Text = "Ürün Adı:";
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 767);
            this.Controls.Add(this.prod_name_lbl);
            this.Controls.Add(this.dt_end_lbl);
            this.Controls.Add(this.dt_start_lbl);
            this.Controls.Add(this.order_search_tbx);
            this.Controls.Add(this.datetime_end);
            this.Controls.Add(this.datetime_start);
            this.Controls.Add(this.ordersearch_lbl);
            this.Controls.Add(this.orders_dgw);
            this.Name = "Orders";
            this.Text = "Siparişler";
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orders_dgw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView orders_dgw;
        private MetroFramework.Controls.MetroLabel ordersearch_lbl;
        private MetroFramework.Controls.MetroDateTime datetime_start;
        private MetroFramework.Controls.MetroDateTime datetime_end;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_status;
        private MetroFramework.Controls.MetroTextBox order_search_tbx;
        private MetroFramework.Controls.MetroLabel dt_start_lbl;
        private MetroFramework.Controls.MetroLabel dt_end_lbl;
        private MetroFramework.Controls.MetroLabel prod_name_lbl;
    }
}