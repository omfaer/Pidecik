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
    public partial class Orders : MetroFramework.Forms.MetroForm
    {
        public Orders()
        {
            InitializeComponent();
        }
        DataTable orders_dt;
        DataView dv;
        private void show_orders()
        {
            Database.connection_control();
            orders_dt = Database.get_data("SELECT O.order_id, product_name, order_price, order_time, order_type, order_status " +
                                            "FROM Orders O, Products P, OrderProduct OP WHERE O.order_id = OP.order_id AND P.product_id = OP.product_id");
            orders_dgw.DataSource = orders_dt;
            dv = new DataView(orders_dt);

        }
        private void Orders_Load(object sender, EventArgs e)
        {
            show_orders();

            datetime_start.Value = DateTime.Now.AddDays(-1);
            datetime_end.Value = DateTime.Now;

            datetime_start_ValueChanged(null, null);
        }

        private void order_search_tbx_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = string.Format("product_name LIKE '%{0}%'", order_search_tbx.Text);
            orders_dgw.DataSource = dv;
        }

        private void datetime_start_ValueChanged(object sender, EventArgs e)
        {
            dv.RowFilter = string.Format("order_time > '{0}' AND order_time <= '{1}'", datetime_start.Value, datetime_end.Value);
            dv.Sort = "order_time DESC";
            orders_dgw.DataSource = dv;
        }

        private void datetime_end_ValueChanged(object sender, EventArgs e)
        {
            datetime_start_ValueChanged(null, null);
        }
    }
}
