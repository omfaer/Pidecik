namespace Pidecik
{
    partial class Tables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tables));
            this.tables_lv = new System.Windows.Forms.ListView();
            this.ımageList = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolstrip_empty_table = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_reserved_table = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tables_lv
            // 
            this.tables_lv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tables_lv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tables_lv.LargeImageList = this.ımageList;
            this.tables_lv.Location = new System.Drawing.Point(20, 60);
            this.tables_lv.Name = "tables_lv";
            this.tables_lv.Size = new System.Drawing.Size(1033, 689);
            this.tables_lv.TabIndex = 0;
            this.tables_lv.UseCompatibleStateImageBehavior = false;
            this.tables_lv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tables_lv_MouseClick);
            this.tables_lv.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tables_lv_MouseDoubleClick);
            // 
            // ımageList
            // 
            this.ımageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList.ImageStream")));
            this.ımageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList.Images.SetKeyName(0, "table_green.png");
            this.ımageList.Images.SetKeyName(1, "table_red.png");
            this.ımageList.Images.SetKeyName(2, "table_yellow.png");
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstrip_empty_table,
            this.toolStrip_reserved_table});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(168, 52);
            // 
            // toolstrip_empty_table
            // 
            this.toolstrip_empty_table.Name = "toolstrip_empty_table";
            this.toolstrip_empty_table.Size = new System.Drawing.Size(167, 24);
            this.toolstrip_empty_table.Text = "Masayı Kapat";
            this.toolstrip_empty_table.Click += new System.EventHandler(this.toolstrip_empty_table_Click);
            // 
            // toolStrip_reserved_table
            // 
            this.toolStrip_reserved_table.Name = "toolStrip_reserved_table";
            this.toolStrip_reserved_table.Size = new System.Drawing.Size(167, 24);
            this.toolStrip_reserved_table.Text = "Rezerve Et";
            this.toolStrip_reserved_table.Click += new System.EventHandler(this.toolStrip_reserved_table_Click);
            // 
            // Tables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 769);
            this.Controls.Add(this.tables_lv);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Tables";
            this.Text = "Masalar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Tables_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView tables_lv;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolstrip_empty_table;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_reserved_table;
        private System.Windows.Forms.ImageList ımageList;
    }
}