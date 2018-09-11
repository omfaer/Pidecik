namespace Pidecik
{
    partial class Customers
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
            this.status_lbl = new System.Windows.Forms.Label();
            this.customer_search_tbx = new MetroFramework.Controls.MetroTextBox();
            this.csearch_lbl = new MetroFramework.Controls.MetroLabel();
            this.customers_dgw = new MetroFramework.Controls.MetroGrid();
            this.customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customers_dgw)).BeginInit();
            this.SuspendLayout();
            // 
            // status_lbl
            // 
            this.status_lbl.AutoSize = true;
            this.status_lbl.Location = new System.Drawing.Point(233, 235);
            this.status_lbl.Name = "status_lbl";
            this.status_lbl.Size = new System.Drawing.Size(36, 17);
            this.status_lbl.TabIndex = 8;
            this.status_lbl.Text = "       ";
            // 
            // customer_search_tbx
            // 
            // 
            // 
            // 
            this.customer_search_tbx.CustomButton.Image = null;
            this.customer_search_tbx.CustomButton.Location = new System.Drawing.Point(697, 2);
            this.customer_search_tbx.CustomButton.Name = "";
            this.customer_search_tbx.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.customer_search_tbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.customer_search_tbx.CustomButton.TabIndex = 1;
            this.customer_search_tbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.customer_search_tbx.CustomButton.UseSelectable = true;
            this.customer_search_tbx.CustomButton.Visible = false;
            this.customer_search_tbx.Lines = new string[0];
            this.customer_search_tbx.Location = new System.Drawing.Point(236, 189);
            this.customer_search_tbx.MaxLength = 32767;
            this.customer_search_tbx.Name = "customer_search_tbx";
            this.customer_search_tbx.PasswordChar = '\0';
            this.customer_search_tbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.customer_search_tbx.SelectedText = "";
            this.customer_search_tbx.SelectionLength = 0;
            this.customer_search_tbx.SelectionStart = 0;
            this.customer_search_tbx.ShortcutsEnabled = true;
            this.customer_search_tbx.Size = new System.Drawing.Size(725, 30);
            this.customer_search_tbx.TabIndex = 9;
            this.customer_search_tbx.UseSelectable = true;
            this.customer_search_tbx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.customer_search_tbx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.customer_search_tbx.TextChanged += new System.EventHandler(this.customer_search_tbx_TextChanged);
            // 
            // csearch_lbl
            // 
            this.csearch_lbl.AutoSize = true;
            this.csearch_lbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.csearch_lbl.Location = new System.Drawing.Point(84, 191);
            this.csearch_lbl.Name = "csearch_lbl";
            this.csearch_lbl.Size = new System.Drawing.Size(107, 25);
            this.csearch_lbl.TabIndex = 10;
            this.csearch_lbl.Text = "Müşteri Ara:";
            // 
            // customers_dgw
            // 
            this.customers_dgw.AllowUserToAddRows = false;
            this.customers_dgw.AllowUserToDeleteRows = false;
            this.customers_dgw.AllowUserToResizeRows = false;
            this.customers_dgw.BackgroundColor = System.Drawing.Color.White;
            this.customers_dgw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.customers_dgw.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.customers_dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customers_dgw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.customers_dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customers_dgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customer_id,
            this.customer_first_name,
            this.customer_last_name,
            this.customer_phone,
            this.customer_address});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customers_dgw.DefaultCellStyle = dataGridViewCellStyle2;
            this.customers_dgw.EnableHeadersVisualStyles = false;
            this.customers_dgw.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.customers_dgw.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.customers_dgw.Location = new System.Drawing.Point(236, 265);
            this.customers_dgw.Name = "customers_dgw";
            this.customers_dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customers_dgw.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.customers_dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.customers_dgw.RowTemplate.Height = 24;
            this.customers_dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customers_dgw.Size = new System.Drawing.Size(725, 337);
            this.customers_dgw.TabIndex = 11;
            this.customers_dgw.CancelRowEdit += new System.Windows.Forms.QuestionEventHandler(this.customers_dgw_CancelRowEdit);
            this.customers_dgw.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.customers_dgw_CellMouseDoubleClick);
            this.customers_dgw.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.customers_dgw_CellValueChanged);
            // 
            // customer_id
            // 
            this.customer_id.DataPropertyName = "customer_id";
            this.customer_id.HeaderText = "ID";
            this.customer_id.Name = "customer_id";
            // 
            // customer_first_name
            // 
            this.customer_first_name.DataPropertyName = "customer_first_name";
            this.customer_first_name.HeaderText = "Ad";
            this.customer_first_name.Name = "customer_first_name";
            // 
            // customer_last_name
            // 
            this.customer_last_name.DataPropertyName = "customer_last_name";
            this.customer_last_name.HeaderText = "Soyad";
            this.customer_last_name.Name = "customer_last_name";
            // 
            // customer_phone
            // 
            this.customer_phone.DataPropertyName = "customer_phone";
            this.customer_phone.HeaderText = "Telefon";
            this.customer_phone.Name = "customer_phone";
            // 
            // customer_address
            // 
            this.customer_address.DataPropertyName = "customer_address";
            this.customer_address.HeaderText = "Adres";
            this.customer_address.Name = "customer_address";
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 699);
            this.Controls.Add(this.customers_dgw);
            this.Controls.Add(this.csearch_lbl);
            this.Controls.Add(this.customer_search_tbx);
            this.Controls.Add(this.status_lbl);
            this.Name = "Customers";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customers_dgw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label status_lbl;
        private MetroFramework.Controls.MetroTextBox customer_search_tbx;
        private MetroFramework.Controls.MetroLabel csearch_lbl;
        private MetroFramework.Controls.MetroGrid customers_dgw;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_address;
    }
}