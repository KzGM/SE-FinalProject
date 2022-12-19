using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DevExFinalSE
{
    public class CnClass
    {
        static SqlConnection con = new SqlConnection();

        public static void CreateConnection() 
        {
            con.ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=test_se2;Integrated Security=True";
            try
            {
                con.Open();
            } 
            catch (Exception) 
            {
                throw;
            }
        }
        public static void CloseConnection()
        {
            con.Close();
        }
        public static DataTable GetData(string query)
        {
            CreateConnection();
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query,con);
            da.Fill(tb);
            CloseConnection();  
            return tb;
        }
        public static void exQuery(string query)
        {
            CreateConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            //try
            //{
            //    cmd.ExecuteNonQuery();

            //}
            //catch (SqlException)
            //{

            //}
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
    }
}
