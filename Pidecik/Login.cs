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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }
        public static string user;
        private void login_btn_Click(object sender, EventArgs e)
        {
            if (user_name_tbx.Text == "")
            {
                MessageBox.Show("Kullanıcı Adını Giriniz!");
            }
            else if (password_tbx.Text == "")
            {
                MessageBox.Show("Şifrenizi Giriniz!");
            }
            else {
                if (Controller.user_control(user_name_tbx.Text, password_tbx.Text) == false)
                {
                    MessageBox.Show("Kullanıcı adı ve ya şifre yanlış.");
                    user_name_tbx.Clear();
                    password_tbx.Clear();
                }
                else {
                    ManagementPanel management_panel = new ManagementPanel();
                    management_panel.ShowDialog();
                    this.Close();
                }
            }
        }
        private void password_tbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_btn_Click((Object)sender, (EventArgs)e);
            }
        }
    }
}
