using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlidiemTHPT
{
    class QliKhoi
    {

        Connection connection;
        SqlDataAdapter sqlDataAdapter;
        SqlCommand sqlCommand;
        public QliKhoi()
        {
            connection = new Connection();
        }
        public DataTable getKhoi()
        {
            string sql = " SELECT * FROM Khoi ";
            SqlConnection con = connection.getSqlConnection();
            sqlDataAdapter = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            con.Close();
            return dataTable;
        }
        public bool InsertKhoi(Khoi k)
        {
            string sql = "INSERT INTO Khoi(Khoi_Ma, Khoi_ten) VALUES (@Khoi_Ma, @Khoi_Ten)";
            SqlConnection con = connection.getSqlConnection();
            try
            {
                sqlCommand = new SqlCommand(sql, con);
                con.Open();
                sqlCommand.Parameters.Add
                    ("@Khoi_Ma", SqlDbType.NVarChar).Value = k.Khoi_Ma;
                sqlCommand.Parameters.Add
                    ("@Khoi_Ten", SqlDbType.NVarChar).Value = k.Khoi_Ten;
                sqlCommand.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool UpdateKhoi(Khoi k)
        {
            string sql = "UPDATE Khoi SET Khoi_Ten = @Khoi_Ten WHERE Khoi_Ma = @Khoi_Ma";
            SqlConnection con = connection.getSqlConnection();
            try
            {
                sqlCommand = new SqlCommand(sql, con);
                con.Open();
                sqlCommand.Parameters.Add
                    ("@Khoi_Ma", SqlDbType.NVarChar).Value = k.Khoi_Ma;
                sqlCommand.Parameters.Add
                    ("@Khoi_Ten", SqlDbType.NVarChar).Value = k.Khoi_Ten;
                sqlCommand.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool DeleteKhoi(Khoi k)
        {
            string sql = "DELETE Khoi WHERE Khoi_Ma = @Khoi_Ma";
            SqlConnection con = connection.getSqlConnection();
            try
            {
                sqlCommand = new SqlCommand(sql, con);
                con.Open();
                sqlCommand.Parameters.Add
                    ("@Khoi_Ma", SqlDbType.NVarChar).Value = k.Khoi_Ma;
                sqlCommand.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
    }
}
