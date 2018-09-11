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
    public partial class OrderShipment : MetroFramework.Forms.MetroForm
    {
        public OrderShipment()
        {
            InitializeComponent();
        }

        Helpers helper = new Helpers();
        DataTable dt;
        DataTable customers_dt;
        DataTable products_dt;
        static int c_id;
        static int p_id;
        static string s_number;
        static decimal total_price;
        private void Shipments_Load(object sender, EventArgs e)
        {
            show_customers();
            category_list_cbx();
            addpersonel_list_cbx();
            products_list_dgw();
            s_number = GetShipNumber();
            ship_number.Text = s_number;
            shiptype_cbx.Text = "Motorlu Kurye";
        }

        private void show_customers()
        {
            Database.connection_control();
            customers_dt = Database.get_data("select * from Customers");
            customer_list_dgw.DataSource = customers_dt;
        }

        public void products_list_dgw()
        {
            using (products_dt = Helpers.show_product_list(category_cbx.SelectedValue))
            {
                product_list_dgw.DataSource = products_dt;
            }

        }

        static private int _InternalCounter = 0;

        static public string GetShipNumber()
        {
            var now = DateTime.Now;
            var days = (int)(now - new DateTime(2000, 1, 1)).TotalDays;
            var seconds = (int)(now - DateTime.Today).TotalSeconds;
            var counter = _InternalCounter++ % 100;

            return days.ToString("00000") + seconds.ToString("00000") + counter.ToString("00");
        }
        
        private void newshipment_btn_Click(object sender, EventArgs e)
        {
            if (shiporders_lv != null)
            {
                try
                {
                    Database.connection_control();
                    string s_type = shiptype_cbx.Text;
                    string s_address = shipaddress_tbx.Text;
                    string s_details = shipdetails_tbx.Text;
                    string s_status = "Teslimata Çıktı";
                    int per_id = Convert.ToInt32(personel_cbx.SelectedValue);
                    helper.add_order_on_shipment(s_number, s_type, s_address, s_details, s_status, total_price, c_id, per_id);

                    foreach (ListViewItem item in shiporders_lv.Items)
                    {
                        int p_id = Convert.ToInt32(item.SubItems[0].Text);
                        helper.add_shipment_order_product(s_number, p_id);
                    }
                    MessageBox.Show(s_number + " Numaralı Gönderi Oluşturuldu","Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }catch{
                    MessageBox.Show("Eksik ya da yanlış bilgi girdiniz. Lütfen kontrol edip tekrar deneyiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void customer_list_dgw_MouseClick(object sender, MouseEventArgs e)
        {
            string fullname = (string)customer_list_dgw.Rows[customer_list_dgw.CurrentRow.Index].Cells[1].Value + " " +(string)customer_list_dgw.Rows[customer_list_dgw.CurrentRow.Index].Cells[2].Value;
            string address = (string)customer_list_dgw.Rows[customer_list_dgw.CurrentRow.Index].Cells[4].Value;
            OrderShipment.c_id = (int)customer_list_dgw.Rows[customer_list_dgw.CurrentRow.Index].Cells[0].Value;
            shipaddress_tbx.Text = address;
            customername_tbx.Text = fullname;
        }

        private void customersearch_tbx_TextChanged(object sender, EventArgs e)
        {
            /*Müşteri Telefon numarasına ya da adına göre arama listeleme*/
            DataView dv = new DataView(customers_dt);
            dv.RowFilter = string.Format("customer_phone LIKE '%{0}%' or customer_first_name LIKE '%{0}%' or customer_last_name LIKE '%{0}%'", search_tbx.Text);
            customer_list_dgw.DataSource = dv;
        }

        public void category_list_cbx()
        {
            Database.connection_control();
            dt = Database.get_data("SELECT * FROM Categories");
            category_cbx.ValueMember = "category_id";
            category_cbx.DisplayMember = "category_name";
            category_cbx.DataSource = dt;
        }
        private void category_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (category_cbx.SelectedIndex != -1)
            {
                products_list_dgw();
            }
        }

        public void addpersonel_list_cbx()
        {
            /*FULLNAME Trick*/
            dt = Database.get_data("SELECT personel_id, personel_id_number, (personel_first_name + ' ' + personel_last_name) AS FULLNAME FROM Personels WHERE personel_role='Carrier'");
            personel_cbx.ValueMember = "personel_id";
            personel_cbx.DisplayMember = "FULLNAME";
            personel_cbx.DataSource = dt;
        }

        public Boolean check;
        private void selectall_CheckedChanged(object sender, EventArgs e)
        {
            //Tümünü seç butonu davranışı
            if (selectall.Checked){
                check = true;
            } else {
                check = false;
            }
            shiporders_lv.Items.OfType<ListViewItem>().ToList().ForEach(item => item.Checked = check);
        }


        private void add_product_btn_Click(object sender, EventArgs e)
        {
            /* listview ya da bir datatable a birden fazla sipariş ekleyip o verileri kullanarak neworder butonu tetiklensin */
            p_id = (int)product_list_dgw.Rows[product_list_dgw.CurrentRow.Index].Cells[0].Value;

            Database.connection_control();
            string sql = "SELECT product_id, product_name, product_price FROM Products WHERE product_id=@product_id";
            SqlCommand cmd = new SqlCommand(sql, Database.connection);
            cmd.Parameters.AddWithValue("@product_id", p_id);
            SqlDataReader read_data = cmd.ExecuteReader();
            while (read_data.Read())
            {
                ListViewItem item = new ListViewItem(read_data["product_id"].ToString());
                item.SubItems.Add(read_data["product_name"].ToString());
                item.SubItems.Add(read_data["product_price"].ToString());
                shiporders_lv.Items.Add(item);
                total_price = total_price + Convert.ToDecimal(read_data["product_price"].ToString());
            }
            total_price_lbl.Text = total_price.ToString();
        }
        private void cancel_product_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem eachItem in shiporders_lv.CheckedItems)
                {
                    shiporders_lv.Items.Remove(eachItem);
                    total_price = total_price - Convert.ToDecimal(eachItem.SubItems[2].Text);
                }
                total_price_lbl.Text = total_price.ToString();
            }
            catch
            {
                MessageBox.Show("İptal etmek istediğiniz ürünü işaretleyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void search_product_tbx_TextChanged(object sender, EventArgs e)
        {
            /*Ürün adı ya da açıklamasına göre arama listeleme*/
            DataView dv = new DataView(products_dt);
            dv.RowFilter = string.Format("product_name LIKE '%{0}%' or product_description LIKE '%{0}%'", search_product_tbx.Text);
            product_list_dgw.DataSource = dv;
        }
    }
}
