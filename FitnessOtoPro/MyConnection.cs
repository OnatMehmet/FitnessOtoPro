using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
namespace FitnessOtoPro
{
   public class MyConnection
    {
        public static string connectionstring;
       

        private static SqlConnection Bağlan()
        {
            connectionstring = "Data Source=.\\SQLEXPRESS;Initial Catalog=FitnessDb;Integrated Security=True";
            SqlConnection baglanti = new SqlConnection(connectionstring);
            if (baglanti.State != ConnectionState.Open)
            {
                try
                {
                    baglanti.Open();
                }
                catch
                {
                    MessageBox.Show("Bağlantı Kurulamadı", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            return baglanti;
        }

        public static bool İşlemYap(string sql)
        {
            SqlCommand kmt = new SqlCommand(sql, Bağlan());
            if (kmt.ExecuteNonQuery() == 1)
                return true;
            else
                return false;
        }

        public static object FunctionÇağır(string sql)
        {
            SqlCommand kmt = new SqlCommand(sql, Bağlan());
            return kmt.ExecuteScalar();
        }

        public static DataTable TabloSorgula(string sql)
        {
            SqlDataAdapter adap = new SqlDataAdapter(sql, Bağlan());
            DataSet data = new DataSet();
            adap.Fill(data);
            return data.Tables[0];
        }

        public static DataRow SatırSorgula(string sql)
        {
            SqlDataAdapter adap = new SqlDataAdapter(sql, Bağlan());
            DataSet data = new DataSet();
            adap.Fill(data);
            return data.Tables[0].Rows[0];
        }
    }
}
