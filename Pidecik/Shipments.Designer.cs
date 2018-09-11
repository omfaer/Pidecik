namespace Pidecik
{
    partial class Shipments
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
            this.shipments_dgw = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.shipment_sarch_tbx = new MetroFramework.Controls.MetroTextBox();
            this.dt_end_lbl = new MetroFramework.Controls.MetroLabel();
            this.dt_start_lbl = new MetroFramework.Controls.MetroLabel();
            this.datetime_end = new MetroFramework.Controls.MetroDateTime();
            this.datetime_start = new MetroFramework.Controls.MetroDateTime();
            this.shipment_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipment_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipment_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipment_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipment_details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipment_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipment_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.shipments_dgw)).BeginInit();
            this.SuspendLayout();
            // 
            // shipments_dgw
            // 
            this.shipments_dgw.AllowUserToAddRows = false;
            this.shipments_dgw.AllowUserToDeleteRows = false;
            this.shipments_dgw.AllowUserToResizeRows = false;
            this.shipments_dgw.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.shipments_dgw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shipments_dgw.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.shipments_dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.shipments_dgw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.shipments_dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shipments_dgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shipment_id,
            this.shipment_number,
            this.shipment_time,
            this.customer_first_name,
            this.customer_last_name,
            this.shipment_address,
            this.shipment_details,
            this.shipment_type,
            this.shipment_status,
            this.order_price});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.shipments_dgw.DefaultCellStyle = dataGridViewCellStyle2;
            this.shipments_dgw.EnableHeadersVisualStyles = false;
            this.shipments_dgw.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.shipments_dgw.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.shipments_dgw.Location = new System.Drawing.Point(23, 151);
            this.shipments_dgw.Name = "shipments_dgw";
            this.shipments_dgw.ReadOnly = true;
            this.shipments_dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.shipments_dgw.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.shipments_dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.shipments_dgw.RowTemplate.Height = 24;
            this.shipments_dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.shipments_dgw.Size = new System.Drawing.Size(1525, 708);
            this.shipments_dgw.TabIndex = 0;
            this.shipments_dgw.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.shipments_dgw_MouseDoubleClick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 102);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(33, 20);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Ara:";
            // 
            // shipment_sarch_tbx
            // 
            // 
            // 
            // 
            this.shipment_sarch_tbx.CustomButton.Image = null;
            this.shipment_sarch_tbx.CustomButton.Location = new System.Drawing.Point(827, 2);
            this.shipment_sarch_tbx.CustomButton.Name = "";
            this.shipment_sarch_tbx.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.shipment_sarch_tbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.shipment_sarch_tbx.CustomButton.TabIndex = 1;
            this.shipment_sarch_tbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.shipment_sarch_tbx.CustomButton.UseSelectable = true;
            this.shipment_sarch_tbx.CustomButton.Visible = false;
            this.shipment_sarch_tbx.Lines = new string[0];
            this.shipment_sarch_tbx.Location = new System.Drawing.Point(104, 97);
            this.shipment_sarch_tbx.MaxLength = 32767;
            this.shipment_sarch_tbx.Multiline = true;
            this.shipment_sarch_tbx.Name = "shipment_sarch_tbx";
            this.shipment_sarch_tbx.PasswordChar = '\0';
            this.shipment_sarch_tbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.shipment_sarch_tbx.SelectedText = "";
            this.shipment_sarch_tbx.SelectionLength = 0;
            this.shipment_sarch_tbx.SelectionStart = 0;
            this.shipment_sarch_tbx.ShortcutsEnabled = true;
            this.shipment_sarch_tbx.Size = new System.Drawing.Size(855, 30);
            this.shipment_sarch_tbx.TabIndex = 1;
            this.shipment_sarch_tbx.UseSelectable = true;
            this.shipment_sarch_tbx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.shipment_sarch_tbx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.shipment_sarch_tbx.TextChanged += new System.EventHandler(this.shipment_sarch_tbx_TextChanged);
            // 
            // dt_end_lbl
            // 
            this.dt_end_lbl.AutoSize = true;
            this.dt_end_lbl.Location = new System.Drawing.Point(1296, 58);
            this.dt_end_lbl.Name = "dt_end_lbl";
            this.dt_end_lbl.Size = new System.Drawing.Size(72, 20);
            this.dt_end_lbl.TabIndex = 13;
            this.dt_end_lbl.Text = "Bitiş Tarihi:";
            // 
            // dt_start_lbl
            // 
            this.dt_start_lbl.AutoSize = true;
            this.dt_start_lbl.Location = new System.Drawing.Point(1028, 58);
            this.dt_start_lbl.Name = "dt_start_lbl";
            this.dt_start_lbl.Size = new System.Drawing.Size(105, 20);
            this.dt_start_lbl.TabIndex = 12;
            this.dt_start_lbl.Text = "Başlangıç Tarihi:";
            // 
            // datetime_end
            // 
            this.datetime_end.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.datetime_end.Location = new System.Drawing.Point(1296, 95);
            this.datetime_end.MinimumSize = new System.Drawing.Size(0, 27);
            this.datetime_end.Name = "datetime_end";
            this.datetime_end.Size = new System.Drawing.Size(252, 27);
            this.datetime_end.TabIndex = 11;
            this.datetime_end.ValueChanged += new System.EventHandler(this.datetime_end_ValueChanged);
            // 
            // datetime_start
            // 
            this.datetime_start.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.datetime_start.Location = new System.Drawing.Point(1028, 95);
            this.datetime_start.MinimumSize = new System.Drawing.Size(0, 27);
            this.datetime_start.Name = "datetime_start";
            this.datetime_start.Size = new System.Drawing.Size(246, 27);
            this.datetime_start.TabIndex = 10;
            this.datetime_start.Value = new System.DateTime(2018, 8, 29, 7, 6, 47, 0);
            this.datetime_start.ValueChanged += new System.EventHandler(this.datetime_start_ValueChanged);
            // 
            // shipment_id
            // 
            this.shipment_id.DataPropertyName = "shipment_id";
            this.shipment_id.HeaderText = "ID";
            this.shipment_id.Name = "shipment_id";
            this.shipment_id.ReadOnly = true;
            this.shipment_id.Width = 50;
            // 
            // shipment_number
            // 
            this.shipment_number.DataPropertyName = "shipment_number";
            this.shipment_number.HeaderText = "Gönderi No";
            this.shipment_number.Name = "shipment_number";
            this.shipment_number.ReadOnly = true;
            // 
            // shipment_time
            // 
            this.shipment_time.DataPropertyName = "shipment_time";
            this.shipment_time.HeaderText = "Gönderi Zamanı";
            this.shipment_time.Name = "shipment_time";
            this.shipment_time.ReadOnly = true;
            // 
            // customer_first_name
            // 
            this.customer_first_name.DataPropertyName = "customer_first_name";
            this.customer_first_name.HeaderText = "Müşteri Adı";
            this.customer_first_name.Name = "customer_first_name";
            this.customer_first_name.ReadOnly = true;
            // 
            // customer_last_name
            // 
            this.customer_last_name.DataPropertyName = "customer_last_name";
            this.customer_last_name.HeaderText = "Müşteri Soyadı";
            this.customer_last_name.Name = "customer_last_name";
            this.customer_last_name.ReadOnly = true;
            // 
            // shipment_address
            // 
            this.shipment_address.DataPropertyName = "shipment_address";
            this.shipment_address.HeaderText = "Adres";
            this.shipment_address.Name = "shipment_address";
            this.shipment_address.ReadOnly = true;
            this.shipment_address.Width = 235;
            // 
            // shipment_details
            // 
            this.shipment_details.DataPropertyName = "shipment_details";
            this.shipment_details.HeaderText = "Açıklama";
            this.shipment_details.Name = "shipment_details";
            this.shipment_details.ReadOnly = true;
            this.shipment_details.Width = 120;
            // 
            // shipment_type
            // 
            this.shipment_type.DataPropertyName = "shipment_type";
            this.shipment_type.HeaderText = "Gönderi Tipi";
            this.shipment_type.Name = "shipment_type";
            this.shipment_type.ReadOnly = true;
            // 
            // shipment_status
            // 
            this.shipment_status.DataPropertyName = "shipment_status";
            this.shipment_status.HeaderText = "Gönderi Durumu";
            this.shipment_status.Name = "shipment_status";
            this.shipment_status.ReadOnly = true;
            // 
            // order_price
            // 
            this.order_price.DataPropertyName = "order_price";
            this.order_price.HeaderText = "Sipariş Ücreti";
            this.order_price.Name = "order_price";
            this.order_price.ReadOnly = true;
            // 
            // Shipments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1777, 902);
            this.Controls.Add(this.dt_end_lbl);
            this.Controls.Add(this.dt_start_lbl);
            this.Controls.Add(this.datetime_end);
            this.Controls.Add(this.datetime_start);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.shipment_sarch_tbx);
            this.Controls.Add(this.shipments_dgw);
            this.Name = "Shipments";
            this.Resizable = false;
            this.Text = "Gönderiler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Shipments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shipments_dgw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid shipments_dgw;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox shipment_sarch_tbx;
        private MetroFramework.Controls.MetroLabel dt_end_lbl;
        private MetroFramework.Controls.MetroLabel dt_start_lbl;
        private MetroFramework.Controls.MetroDateTime datetime_end;
        private MetroFramework.Controls.MetroDateTime datetime_start;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipment_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipment_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipment_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipment_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipment_details;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipment_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipment_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_price;
    }
}