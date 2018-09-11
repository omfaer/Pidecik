using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace Pidecik.Class
{
    class Database
    {
        #region Variables
        public static SqlConnection connection = new SqlConnection("Data Source = YOUR_SERVER_NAME; Initial Catalog = Pidecik; Integrated Security=SSPI; MultipleActiveResultSets=True");
        #endregion
        public static void connection_control()
        {
            if (connection.State == ConnectionState.Closed)
            {
                try
                {
                    connection.Open();
                }
                catch
                {
                    MessageBox.Show("Veri Tabanı Bağlantısı Yapılamadı");
                    Application.Exit();
                }
            }
        }

        public static DataTable get_data(string sql) //Tüm işlemler için
        {
            connection_control();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            return dt;
        }

    }
}
