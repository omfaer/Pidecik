using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Pidecik.Class;

namespace Pidecik.Class
{
    class Controller
    {
        public static bool user_control(string username, string password)
        {
            Database.connection_control();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE user_name=@username AND user_password=@password", Database.connection);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return true;
            } else
            {
                return false;
            }
        }
        public static bool is_there_data(string sql)
        {
            Database.connection_control();
            SqlCommand cmd = new SqlCommand(sql, Database.connection);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
