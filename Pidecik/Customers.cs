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
    public partial class Customers : MetroFramework.Forms.MetroForm
    {
        public Customers()
        {
            InitializeComponent();
        }
        DataTable dt;
        private void show_customers()
        {
            dt = Database.get_data("Select * From Customers");
            customers_dgw.DataSource = dt;
            customers_dgw.Columns[0].ReadOnly = true;
        }
        private void Customers_Load(object sender, EventArgs e)
        {
            show_customers();
        }

        private void customers_dgw_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Database.connection_control();
            try
            {

                string selected_id = customers_dgw.Rows[e.RowIndex].Cells[0].Value.ToString();
                string first_name = customers_dgw.Rows[e.RowIndex].Cells[1].Value.ToString();
                string last_name = customers_dgw.Rows[e.RowIndex].Cells[2].Value.ToString();
                string phone = customers_dgw.Rows[e.RowIndex].Cells[3].Value.ToString();
                string address = customers_dgw.Rows[e.RowIndex].Cells[4].Value.ToString();

                string sql = "UPDATE Customers SET customer_first_name = @first_name, customer_last_name = @last_name, " + 
                             "customer_phone=@phone, customer_address=@address WHERE customer_id=" + selected_id;
                SqlCommand cmd = new SqlCommand(sql, Database.connection);
                cmd.Parameters.AddWithValue("@first_name", first_name);
                cmd.Parameters.AddWithValue("@last_name", last_name);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@address", address);


                if (cmd.ExecuteNonQuery() == 1)
                {
                    status_lbl.Text = "Müşteri güncellendi";
                    show_customers();
                }
                else {
                    MessageBox.Show("Veri güncelleme Hatası");
                    show_customers();
                }
            }
            catch
            {
                status_lbl.Text = "Veriyi Güncellemek İçin Yeni Veriyi Girdikten Sonra ENTER Tuşuna Basınız!";
            }
        }

        private void customers_dgw_CancelRowEdit(object sender, QuestionEventArgs e)
        {
            status_lbl.Text = "Güncelleme İptal Edildi";
            show_customers();
        }

        private void customers_dgw_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            status_lbl.Text = "Değişikliği İptal Etmek için ESC basınız.";
        }

        private void customer_search_tbx_TextChanged(object sender, EventArgs e)
        {
            /*Müşteri Telefon numarasına ya da adına göre arama listeleme*/
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("customer_phone LIKE '%{0}%' or customer_first_name LIKE '%{0}%' or customer_last_name LIKE '%{0}%'", customer_search_tbx.Text);
            customers_dgw.DataSource = dv;
        }
    }
}
