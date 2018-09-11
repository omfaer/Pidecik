using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Pidecik.Class;


namespace Pidecik
{
    class Helpers
    {
        
        static DateTime dtime = DateTime.Now;
        /* TODO: You can change  SmallDateTime data type on SQL Server 
            INFO: SQL Server smalldatetime data type result
            datetimenow             inserted data
            --------------------  ----------------------
            2011-12-13 12:00:29     2011-12-13 12:00:00
            2011-12-13 12:00:30     2011-12-13 12:01:00

        */

        public static void add_order_on_table(int t_number, decimal p_price, int p_id)
        {
            string o_type = "table";
            string o_status = "Ödenmedi";
            Database.connection_control();
            SqlCommand cmd = new SqlCommand("insertOrderOrderTable", Database.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@table_number", t_number);
            cmd.Parameters.AddWithValue("@order_type", o_type);
            cmd.Parameters.AddWithValue("@order_time", dtime);
            cmd.Parameters.AddWithValue("@order_price", p_price);
            cmd.Parameters.AddWithValue("@order_status", o_status);
            cmd.Parameters.AddWithValue("@product_id", p_id);
            int rowAffected = cmd.ExecuteNonQuery();
        }

        public void add_order_on_shipment(string s_number, string s_type, string s_address, string s_details, string s_status, decimal o_price, int c_id, int per_id)
        {
            string o_type = "shipment";
            string o_status = "Ödenmedi";
            Database.connection_control();
            SqlCommand cmd = new SqlCommand("insertOrderOrderShipment", Database.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@shipment_number", s_number);
            cmd.Parameters.AddWithValue("@shipment_type", s_type);
            cmd.Parameters.AddWithValue("@shipment_time", dtime);
            cmd.Parameters.AddWithValue("@shipment_address", s_address);
            cmd.Parameters.AddWithValue("@shipment_details", s_details);
            cmd.Parameters.AddWithValue("@shipment_status", s_status);
            cmd.Parameters.AddWithValue("@order_type", o_type);
            cmd.Parameters.AddWithValue("@order_time", dtime);
            cmd.Parameters.AddWithValue("@order_status", o_status);
            cmd.Parameters.AddWithValue("@order_price", o_price);
            cmd.Parameters.AddWithValue("@customer_id", c_id);
            cmd.Parameters.AddWithValue("@personel_id", per_id);
            int rowAffected = cmd.ExecuteNonQuery();
        }

        public void add_shipment_order_product(string s_number, int p_id)
        {
            Database.connection_control();
            SqlCommand cmd = new SqlCommand("insertShipmentProducts", Database.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@shipment_number", s_number);
            cmd.Parameters.AddWithValue("@product_id", p_id);
            int rowAffected = cmd.ExecuteNonQuery();
        }
        
        public static void table_status_change(string t_status, int t_id)
        {
            Database.connection_control();
            string sql = "UPDATE Tables SET table_status = @table_status WHERE table_id=@table_id";
            SqlCommand cmd = new SqlCommand(sql, Database.connection);
            cmd.Parameters.AddWithValue("@table_status", t_status);
            cmd.Parameters.AddWithValue("@table_id", t_id);
            cmd.ExecuteNonQuery();
        }

        public static bool is_there_unpaid_order(int table_id){
            Database.connection_control();
            string sql = "SELECT O.order_id FROM Tables T, Orders O, OrderTable OT WHERE O.order_id = OT.order_id AND T.table_id = OT.table_id AND T.table_id = @table_id AND O.order_status = 'Ödenmedi'";
            SqlCommand cmd = new SqlCommand(sql, Database.connection);
            cmd.Parameters.AddWithValue("@table_id",table_id);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static DataTable show_product_list(object category_sel_val)
        {
            DataTable dt = new DataTable();
            dt = Database.get_data("SELECT P.product_id, P.product_name, P.product_price, P.product_description FROM Products P, Categories C, CategoryProduct CP " +
                                   "WHERE P.product_id = CP.product_id AND C.category_id=CP.category_id AND CP.category_id =" + category_sel_val);
            return dt;   
        }
    }

}
