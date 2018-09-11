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
    public partial class Personels : MetroFramework.Forms.MetroForm
    {
        public Personels()
        {
            InitializeComponent();
        }
        DataTable dt;
        private void Personels_Load(object sender, EventArgs e)
        {
            show_personels();
        }

        private void show_personels()
        {
            dt = Database.get_data("SELECT * FROM Personels");
            personels_dgw.DataSource = dt;
        }

        private void personel_search_tbx_TextChanged(object sender, EventArgs e)
        {
            /*Personeli Telefon numarası ad ya da soyada göre arama listeleme*/
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("personel_id_number LIKE '%{0}%' or personel_first_name LIKE '%{0}%' or personel_last_name LIKE '%{0}%'", personel_search_tbx.Text);
            personels_dgw.DataSource = dv;
        }

        private void personels_dgw_MouseClick(object sender, MouseEventArgs e)
        {
            string id_number = (string)personels_dgw.Rows[personels_dgw.CurrentRow.Index].Cells[1].Value;
            string first_name = (string)personels_dgw.Rows[personels_dgw.CurrentRow.Index].Cells[2].Value;
            string last_name = (string)personels_dgw.Rows[personels_dgw.CurrentRow.Index].Cells[3].Value;
            string age = personels_dgw.Rows[personels_dgw.CurrentRow.Index].Cells[4].Value.ToString();
            string gender = (string)personels_dgw.Rows[personels_dgw.CurrentRow.Index].Cells[5].Value;
            string phone = (string)personels_dgw.Rows[personels_dgw.CurrentRow.Index].Cells[6].Value;
            string address = (string)personels_dgw.Rows[personels_dgw.CurrentRow.Index].Cells[7].Value;
            string role = (string)personels_dgw.Rows[personels_dgw.CurrentRow.Index].Cells[8].Value;
            string start_date = personels_dgw.Rows[personels_dgw.CurrentRow.Index].Cells[9].Value.ToString();
            string end_date = (string)personels_dgw.Rows[personels_dgw.CurrentRow.Index].Cells[10].Value.ToString();
            
            id_number_tbx.Text = id_number;
            first_name_tbx.Text = first_name;
            last_name_tbx.Text = last_name;
            age_tbx.Text = age;
            gender_cbx.Text = gender;
            phone_tbx.Text = phone;
            address_tbx.Text = address;
            role_tbx.Text = role;
            startdate_dtp.Text = start_date;

            if (end_date != "") { 
                enddate_dtp.Text = end_date;
                enddate_cbx.Checked = false;
            } else {
                enddate_dtp.Text = DateTime.Now.ToString();
                enddate_cbx.Checked = true;
            }
        }

        private void update_personel_btn_Click(object sender, EventArgs e)
        {
            int personel_id = (int)personels_dgw.Rows[personels_dgw.CurrentRow.Index].Cells[0].Value;
            Database.connection_control();
            string sql = "UPDATE Personels SET personel_id_number = @personel_id_number,"+
                         "personel_first_name = @personel_first_name, personel_last_name = @personel_last_name, personel_age = @personel_age,"+
                         "personel_gender = @personel_gender, personel_phone = @personel_phone, personel_address = @personel_address,"+
                         "personel_role = @personel_role, start_date = @start_date, end_date = @end_date WHERE personel_id=" + personel_id;
            SqlCommand cmd = new SqlCommand(sql, Database.connection);
            cmd.Parameters.AddWithValue("@personel_id_number", id_number_tbx.Text);
            cmd.Parameters.AddWithValue("@personel_first_name", first_name_tbx.Text);
            cmd.Parameters.AddWithValue("@personel_last_name", last_name_tbx.Text);
            cmd.Parameters.AddWithValue("@personel_age", age_tbx.Text);
            cmd.Parameters.AddWithValue("@personel_gender", gender_cbx.Text);
            cmd.Parameters.AddWithValue("@personel_phone", phone_tbx.Text);
            cmd.Parameters.AddWithValue("@personel_address", address_tbx.Text);
            cmd.Parameters.AddWithValue("@personel_role", role_tbx.Text);
            cmd.Parameters.AddWithValue("@start_date", startdate_dtp.Value.Date);
            if (enddate_cbx.Checked == true) {
                cmd.Parameters.AddWithValue("@end_date", DBNull.Value);
            } else {
                cmd.Parameters.AddWithValue("@end_date", enddate_dtp.Value.Date);
            }

            cmd.ExecuteNonQuery();
            MessageBox.Show("Personel Bilgileri Güncellendi!");
            show_personels();
        }

        private void enddate_cbx_CheckedChanged(object sender, EventArgs e)
        {
           if (enddate_cbx.Checked == true)
            {
                enddate_dtp.Enabled = false;
            } else {
                enddate_dtp.Enabled = true;
            }
        }
    }
}
