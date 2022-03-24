using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Assembly
{
    class SqlCRUD
    {
        private static SqlConnection sqlCon;
        private SqlCommand cmd;

        public SqlCRUD(string query)
        {
            try
            {
                sqlCon = new SqlConnection("Data Source=PC-ALEX;Initial Catalog=School;Integrated Security=True");

                cmd = new SqlCommand(query, sqlCon);

                sqlCon.Open();
                cmd.ExecuteNonQuery();
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "IT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                sqlCon.Close();
            }
        }

        public static DataTable SqlTable(string SearchQuery)
        {
            SqlConnection sqlCon_2 = new SqlConnection();

            try
            {
                sqlCon_2.ConnectionString = $"Data Source=PC-ALEX;Initial Catalog=School;Integrated Security=True";

                SqlCommand cmdd = new SqlCommand(SearchQuery, sqlCon_2);
                SqlDataAdapter da = new SqlDataAdapter(cmdd);
                DataTable table = new DataTable();
                da.Fill(table);

                return table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "IT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return null;
            }
        }

        
    }
}
