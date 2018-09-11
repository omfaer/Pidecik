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
    public partial class OrderTable : MetroFramework.Forms.MetroForm
    {
        public OrderTable()
        {
            InitializeComponent();
        }
        private void OrderTable_Load(object sender, EventArgs e)
        {
            order_list();
            category_list_cbx();
            OrderTable.ActiveForm.Text = "Masa " + (Tables.table_id.ToString());
        }
        public void order_list()
        {
            totalpay_lbl.Text = "Hiç Sipariş Yok";
            selectedpay_lbl.Text = "Bir Sipariş Seç";
            orderlist_lv.Items.Clear();
            Database.connection_control();

            string sql = "SELECT O.order_id, P.product_name, O.order_price, O.order_time, O.order_status FROM Products P, OrderProduct OP, Orders O, Tables T, OrderTable OT "+
                         "WHERE O.order_id=OP.order_id AND P.product_id=OP.product_id AND O.order_id=OT.order_id AND T.table_id=OT.table_id AND OT.table_id = @table_id AND O.order_status='Ödenmedi'";
            SqlCommand cmd = new SqlCommand(sql, Database.connection);
            cmd.Parameters.AddWithValue("@table_id", Tables.table_id); 
            SqlDataReader read_data = cmd.ExecuteReader();
            
            while (read_data.Read())
            {
                ListViewItem item = new ListViewItem(read_data["order_id"].ToString());
                item.SubItems.Add(read_data["product_name"].ToString());
                item.SubItems.Add(read_data["order_price"].ToString());
                item.SubItems.Add(read_data["order_time"].ToString());
                item.SubItems.Add(read_data["order_status"].ToString());
                orderlist_lv.Items.Add(item);
           }
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
            orderlist_lv.Items.OfType<ListViewItem>().ToList().ForEach(item => item.Checked = check);
        }

        private void pay_btn_Click(object sender, EventArgs e)
        {
            Database.connection_control();

            for (int i = 0; i < orderlist_lv.Items.Count; i++)
                if (orderlist_lv.Items[i].Checked) // i değişken değeri kadar seçili checkbox için yapılacak işlem
                {
                    string update_order_status = ("UPDATE Orders SET order_status='Ödendi' WHERE order_id=@order_id");
                    SqlCommand cmd = new SqlCommand(update_order_status, Database.connection);
                    cmd.Parameters.AddWithValue("@order_id", orderlist_lv.Items[i].SubItems[0].Text); //Subitems ile seçili öğen dizisindeki ilk parametre olan order_id çek
                    cmd.ExecuteNonQuery();
                }                
            order_list();
        }

        public void category_list_cbx()
        {
            DataTable dt = Database.get_data("SELECT * FROM Categories");
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
        public void products_list_dgw()
        {
            using (DataTable products_dt = Helpers.show_product_list(category_cbx.SelectedValue))
            {
                product_list_dgw.DataSource = products_dt;
            }             
        }


        private void orderlist_lv_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            decimal spay = 0;
            decimal tpay = 0;
            selectedpay_lbl.Text = "Bir Sipariş Seç";
            for (int i = 0; i < orderlist_lv.Items.Count; i++) { 
                if (orderlist_lv.Items[i].Checked) // i değişken değeri kadar seçili check için yapılacak işlem
                {
                    spay = spay + Convert.ToDecimal(orderlist_lv.Items[i].SubItems[2].Text);
                    selectedpay_lbl.Text = Convert.ToString(spay);
                }
                tpay = tpay + Convert.ToDecimal(orderlist_lv.Items[i].SubItems[2].Text);
            }
            totalpay_lbl.Text = Convert.ToString(tpay);
        }

        private void neworder_btn_Click(object sender, EventArgs e)
        {

            Database.connection_control();
            int p_id = (int)product_list_dgw.Rows[product_list_dgw.CurrentRow.Index].Cells[0].Value;
            string p_price_sql = "SELECT product_price FROM Products WHERE product_id=@product_id";
            SqlCommand pp_cmd = new SqlCommand(p_price_sql, Database.connection);
            pp_cmd.Parameters.AddWithValue("@product_id", p_id );
            var p_price = (decimal)pp_cmd.ExecuteScalar();
            int oa = 1;
            if (oamount_tbx.Text !=""){
                oa = Convert.ToInt32(oamount_tbx.Text);
            }
            for (int i = 0; i < oa; i++) {
                Helpers.add_order_on_table(Tables.table_id, p_price,p_id);
            }
            order_list();
        }

        private void cancelorder_btn_Click(object sender, EventArgs e)
        {
            Database.connection_control();
            if (MessageBox.Show("Seçili Sipariş İptal Edilecek \nDevam etmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                for (int i = 0; i < orderlist_lv.Items.Count; i++)
                {
                    if (orderlist_lv.Items[i].Checked) // i değişken değeri kadar seçili checkbox için yapılacak işlem
                    {
                        string update_order_status = ("UPDATE Orders SET order_status='İptal Edildi' WHERE order_id=@order_id");
                        SqlCommand cmd = new SqlCommand(update_order_status, Database.connection);
                        cmd.Parameters.AddWithValue("@order_id", orderlist_lv.Items[i].SubItems[0].Text); //Subitems ile seçili öğen dizisindeki ilk parametre olan order_id çek
                        cmd.ExecuteNonQuery();
                    }
                }                 
            }
            order_list();
        }
    }

}
