using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Pidecik.Class;

namespace Pidecik
{
    public partial class Tables : MetroFramework.Forms.MetroForm
    {
        public Tables()
        {
            InitializeComponent();
        }

        public static int table_id;
        static string table_status;

        private void Tables_Load(object sender, EventArgs e)
        {
            show_tables();
        }

        public void show_tables()
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Tables", Database.connection);
            int total_table = Convert.ToInt32(cmd.ExecuteScalar());
            for (int i = 0; i < total_table; i++)
            {   
                tables_lv.Items.Add("Masa " + (i + 1));
                if (Controller.is_there_data("SELECT * FROM Tables WHERE table_number=" + (i + 1) + " AND table_status='Boş'"))
                {
                    tables_lv.Items[i].ImageKey = "table_green.png";
                }
                else if (Controller.is_there_data("SELECT * FROM Tables WHERE table_number=" + (i + 1) + " AND table_status='Dolu'"))
                {
                    tables_lv.Items[i].ImageKey = "table_red.png";
                }
                else
                {
                    tables_lv.Items[i].ImageKey = "table_yellow.png";
                }
            }
        }

        private void tables_lv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                table_id = (int.Parse(tables_lv.SelectedIndices[0].ToString()) + 1);
                table_status = "Dolu";
                this.tables_lv.SelectedItems[0].ImageKey = "table_red.png";
                Helpers.table_status_change(table_status, table_id);

                OrderTable otable = new OrderTable();
                otable.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Bir hata oluştu. Lütfen tekrar deneyin.");
            }
        }

        private void tables_lv_MouseClick(object sender, MouseEventArgs e)
        {
            table_id = (int.Parse(tables_lv.SelectedIndices[0].ToString()) + 1);
            if (e.Button == MouseButtons.Right)
            {
                if (tables_lv.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    contextMenuStrip.Show(Cursor.Position);
                }
            }
        }

        private void toolstrip_empty_table_Click(object sender, EventArgs e)
        {
            if (Helpers.is_there_unpaid_order(table_id) == true)
            {
                MessageBox.Show("Ödenmemiş Hesap varken masayı kapatamazsın!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                if (tables_lv.SelectedItems.Count > 0 && tables_lv.SelectedItems[0].ImageKey == "table_red.png" || tables_lv.SelectedItems[0].ImageKey == "table_yellow.png")
                {

                    if (MessageBox.Show("Masa Kapatlıacak \nDevam etmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {

                        tables_lv.SelectedItems[0].ImageKey = "table_green.png";
                        table_id = Convert.ToInt32(tables_lv.SelectedIndices[0]) + 1;
                        table_status = "Boş";
                        Helpers.table_status_change(table_status,table_id);
                    }
                }
                else {
                    MessageBox.Show("Masa Zaten Boş", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void toolStrip_reserved_table_Click(object sender, EventArgs e)
        {
            if (tables_lv.SelectedItems.Count > 0 && tables_lv.SelectedItems[0].ImageKey == "table_green.png")
            {
                if (MessageBox.Show("Masa Rezerve Edilecek \nDevam etmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    tables_lv.SelectedItems[0].ImageKey = "table_yellow.png";
                    table_id = Convert.ToInt32(tables_lv.SelectedIndices[0]) + 1;
                    table_status = "Rezerve";
                    Helpers.table_status_change(table_status, table_id);
                }
            }
            else
            {
                MessageBox.Show("Rezerve Edebilmek için Masa Kapalı(Boş) Olmalı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
