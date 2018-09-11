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
    public partial class Shipments : MetroFramework.Forms.MetroForm
    {
        public Shipments()
        {
            InitializeComponent();
        }

        private void Shipments_Load(object sender, EventArgs e)
        {
            show_shipments();

            datetime_start.Value = DateTime.Now.AddDays(-7);
            datetime_end.Value = DateTime.Now;

            datetime_start_ValueChanged(null, null);
        }

        DataTable shipments_dt;
        DataView dv;
        private void show_shipments()
        {
            Database.connection_control();
            shipments_dt = Database.get_data("SELECT S.shipment_id, S.shipment_number,S.shipment_time, S.shipment_address, S.shipment_details, " + 
                                             "S.shipment_type, S.shipment_status, O.order_price, C.customer_first_name, C.customer_last_name " + 
                                             "FROM Shipments S, Orders O, OrderShipment OS, Customers C, CustomerOrder CO " +
                                             "WHERE S.shipment_id = OS.shipment_id AND O.order_id = OS.order_id AND C.customer_id = CO.customer_id AND O.order_id = CO.order_id "+
                                             "ORDER BY S.shipment_time DESC");
            shipments_dgw.DataSource = shipments_dt;
            dv = new DataView(shipments_dt);

        }

        private void shipments_dgw_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (shipments_dgw.SelectedCells.Count > 0)
            {
                int selectedrowindex = shipments_dgw.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = shipments_dgw.Rows[selectedrowindex];

                int s_id = Convert.ToInt32(selectedRow.Cells["shipment_id"].Value);
                string s_number = Convert.ToString(selectedRow.Cells["shipment_number"].Value);
                string s_address = Convert.ToString(selectedRow.Cells["shipment_address"].Value);

                if (MessageBox.Show(s_number + " numaralı gönderi " + s_address + " adresine teslim edildi mi? ", "Uyarı", MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Shipments SET shipment_status='Teslim Edildi' WHERE shipment_id=@shipment_id",Database.connection);
                    cmd.Parameters.AddWithValue("@shipment_id", s_id);
                    cmd.ExecuteNonQuery();
                    show_shipments();
                }
            }
        }

        private void shipment_sarch_tbx_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = string.Format("shipment_number LIKE '%{0}%' or shipment_address LIKE '%{0}%' or customer_first_name LIKE '%{0}%' or customer_last_name LIKE '%{0}%'", shipment_sarch_tbx.Text);
            shipments_dgw.DataSource = dv;
        }

        private void datetime_start_ValueChanged(object sender, EventArgs e)
        {
            dv.RowFilter = string.Format("shipment_time > '{0}' AND shipment_time <= '{1}'", datetime_start.Value, datetime_end.Value);
            dv.Sort = "shipment_time DESC";
            shipments_dgw.DataSource = dv;
        }

        private void datetime_end_ValueChanged(object sender, EventArgs e)
        {
            datetime_start_ValueChanged(null, null);
        }
    }
}
