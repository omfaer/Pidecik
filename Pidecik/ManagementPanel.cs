using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pidecik
{
    public partial class ManagementPanel : MetroFramework.Forms.MetroForm
    {
        public ManagementPanel()
        {
            InitializeComponent();
        }

        private void orders_tile_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.ShowDialog();
        }

        private void tables_tile_Click(object sender, EventArgs e)
        {
            Tables tables = new Tables();
            tables.ShowDialog();
        }

        private void customers_tile_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.ShowDialog();
        }

        private void shipments_tile_Click(object sender, EventArgs e)
        {
            Shipments shipments = new Shipments();
            shipments.ShowDialog();
        }
        private void new_shipments_tile_Click(object sender, EventArgs e)
        {
            OrderShipment newshipments = new OrderShipment();
            newshipments.ShowDialog();
        }

        private void personels_tile_Click(object sender, EventArgs e)
        {
            Personels personels = new Personels();
            personels.ShowDialog();
        }
        private static bool _exiting;

        private void log_out_lbl_Click(object sender, EventArgs e)
        {
            if (!_exiting && MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?",
                   "Pidecik",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information) == DialogResult.Yes)
            {
                _exiting = true;
                Application.Exit();
            }
        }


    }
}
