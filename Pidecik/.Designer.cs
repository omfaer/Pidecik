namespace Pidecik
{
    partial class ManagementPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementPanel));
            this.ımageList = new System.Windows.Forms.ImageList(this.components);
            this.customers_tile = new MetroFramework.Controls.MetroTile();
            this.shipments_tile = new MetroFramework.Controls.MetroTile();
            this.personels_tile = new MetroFramework.Controls.MetroTile();
            this.tables_tile = new MetroFramework.Controls.MetroTile();
            this.orders_tile = new MetroFramework.Controls.MetroTile();
            this.log_out_lbl = new MetroFramework.Controls.MetroLink();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // ımageList
            // 
            this.ımageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList.ImageStream")));
            this.ımageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList.Images.SetKeyName(0, "table_icon.png");
            this.ımageList.Images.SetKeyName(1, "customer_icon.png");
            this.ımageList.Images.SetKeyName(2, "shipment_icon.png");
            this.ımageList.Images.SetKeyName(3, "personel_icon.png");
            this.ımageList.Images.SetKeyName(4, "order_icon.png");
            // 
            // customers_tile
            // 
            this.customers_tile.ActiveControl = null;
            this.customers_tile.BackColor = System.Drawing.Color.SteelBlue;
            this.customers_tile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.customers_tile.Location = new System.Drawing.Point(438, 436);
            this.customers_tile.Name = "customers_tile";
            this.customers_tile.Size = new System.Drawing.Size(250, 250);
            this.customers_tile.TabIndex = 5;
            this.customers_tile.Text = "Müşteriler";
            this.customers_tile.TileImage = global::Pidecik.Properties.Resources.customer;
            this.customers_tile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customers_tile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.customers_tile.UseCustomBackColor = true;
            this.customers_tile.UseMnemonic = false;
            this.customers_tile.UseSelectable = true;
            this.customers_tile.UseTileImage = true;
            this.customers_tile.Click += new System.EventHandler(this.customers_tile_Click);
            // 
            // shipments_tile
            // 
            this.shipments_tile.ActiveControl = null;
            this.shipments_tile.BackColor = System.Drawing.Color.MediumPurple;
            this.shipments_tile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.shipments_tile.Location = new System.Drawing.Point(182, 436);
            this.shipments_tile.Name = "shipments_tile";
            this.shipments_tile.Size = new System.Drawing.Size(250, 250);
            this.shipments_tile.TabIndex = 6;
            this.shipments_tile.Text = "Yeni Gönderi";
            this.shipments_tile.TileImage = global::Pidecik.Properties.Resources.ship;
            this.shipments_tile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.shipments_tile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.shipments_tile.UseCustomBackColor = true;
            this.shipments_tile.UseMnemonic = false;
            this.shipments_tile.UseSelectable = true;
            this.shipments_tile.UseTileImage = true;
            this.shipments_tile.Click += new System.EventHandler(this.new_shipments_tile_Click);
            // 
            // personels_tile
            // 
            this.personels_tile.ActiveControl = null;
            this.personels_tile.BackColor = System.Drawing.Color.DarkOrange;
            this.personels_tile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.personels_tile.Location = new System.Drawing.Point(694, 436);
            this.personels_tile.Name = "personels_tile";
            this.personels_tile.Size = new System.Drawing.Size(250, 250);
            this.personels_tile.TabIndex = 7;
            this.personels_tile.Text = "Personeller";
            this.personels_tile.TileImage = global::Pidecik.Properties.Resources.personel;
            this.personels_tile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.personels_tile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.personels_tile.UseCustomBackColor = true;
            this.personels_tile.UseMnemonic = false;
            this.personels_tile.UseSelectable = true;
            this.personels_tile.UseTileImage = true;
            this.personels_tile.Click += new System.EventHandler(this.personels_tile_Click);
            // 
            // tables_tile
            // 
            this.tables_tile.ActiveControl = null;
            this.tables_tile.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tables_tile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tables_tile.Location = new System.Drawing.Point(182, 180);
            this.tables_tile.Name = "tables_tile";
            this.tables_tile.Size = new System.Drawing.Size(250, 250);
            this.tables_tile.TabIndex = 8;
            this.tables_tile.Text = "Masalar";
            this.tables_tile.TileImage = global::Pidecik.Properties.Resources.table;
            this.tables_tile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tables_tile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tables_tile.UseCustomBackColor = true;
            this.tables_tile.UseMnemonic = false;
            this.tables_tile.UseSelectable = true;
            this.tables_tile.UseTileImage = true;
            this.tables_tile.Click += new System.EventHandler(this.tables_tile_Click);
            // 
            // orders_tile
            // 
            this.orders_tile.ActiveControl = null;
            this.orders_tile.BackColor = System.Drawing.Color.SeaGreen;
            this.orders_tile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.orders_tile.Location = new System.Drawing.Point(438, 180);
            this.orders_tile.Name = "orders_tile";
            this.orders_tile.Size = new System.Drawing.Size(250, 250);
            this.orders_tile.TabIndex = 9;
            this.orders_tile.Text = "Siparişler";
            this.orders_tile.TileImage = global::Pidecik.Properties.Resources.order;
            this.orders_tile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.orders_tile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.orders_tile.UseCustomBackColor = true;
            this.orders_tile.UseMnemonic = false;
            this.orders_tile.UseSelectable = true;
            this.orders_tile.UseTileImage = true;
            this.orders_tile.Click += new System.EventHandler(this.orders_tile_Click);
            // 
            // log_out_lbl
            // 
            this.log_out_lbl.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.log_out_lbl.Location = new System.Drawing.Point(1022, 819);
            this.log_out_lbl.Name = "log_out_lbl";
            this.log_out_lbl.Size = new System.Drawing.Size(127, 30);
            this.log_out_lbl.TabIndex = 10;
            this.log_out_lbl.Text = "Çıkış Yap";
            this.log_out_lbl.UseSelectable = true;
            this.log_out_lbl.Click += new System.EventHandler(this.log_out_lbl_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.Crimson;
            this.metroTile1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroTile1.Location = new System.Drawing.Point(694, 180);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(250, 250);
            this.metroTile1.TabIndex = 11;
            this.metroTile1.Text = "Gönderiler";
            this.metroTile1.TileImage = global::Pidecik.Properties.Resources.ship;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseMnemonic = false;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.shipments_tile_Click);
            // 
            // ManagementPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 872);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.log_out_lbl);
            this.Controls.Add(this.orders_tile);
            this.Controls.Add(this.tables_tile);
            this.Controls.Add(this.personels_tile);
            this.Controls.Add(this.shipments_tile);
            this.Controls.Add(this.customers_tile);
            this.Name = "ManagementPanel";
            this.Text = "Yönetim Paneli";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList ımageList;
        private MetroFramework.Controls.MetroTile customers_tile;
        private MetroFramework.Controls.MetroTile shipments_tile;
        private MetroFramework.Controls.MetroTile personels_tile;
        private MetroFramework.Controls.MetroTile tables_tile;
        private MetroFramework.Controls.MetroTile orders_tile;
        private MetroFramework.Controls.MetroLink log_out_lbl;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}