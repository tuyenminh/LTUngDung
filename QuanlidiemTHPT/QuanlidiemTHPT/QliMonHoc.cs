using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlidiemTHPT
{
    class QliMonHoc
    {
        Connection connection;
        SqlDataAdapter sqlDataAdapter;
        SqlCommand sqlCommand;
        public QliMonHoc() {
            connection = new Connection();
        }
        public DataTable getMonHoc() {
            string sql = " SELECT * FROM MonHoc ";
            SqlConnection con = connection.getSqlConnection();
            sqlDataAdapter = new SqlDataAdapter(sql,con);
            con.Open();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            con.Close();
            return dataTable;
        }
        public bool InsertMonHoc(MonHoc mh) {
            string sql = "INSERT INTO MonHoc(MH_Ma, MH_ten) VALUES (@MH_Ma, @MH_Ten)";
            SqlConnection con = connection.getSqlConnection();
            try
            {
                sqlCommand = new SqlCommand(sql, con);
                con.Open();
                sqlCommand.Parameters.Add
                    ("@MH_Ma", SqlDbType.NVarChar).Value = mh.MH_Ma;
                sqlCommand.Parameters.Add
                    ("@MH_Ten", SqlDbType.NVarChar).Value = mh.MH_Ten;
                sqlCommand.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e) {
                return false;
            }
            return true;
        }
        public bool UpdateMonHoc(MonHoc mh) {
            string sql = "UPDATE MonHoc SET MH_Ten = @MH_Ten WHERE MH_Ma = @MH_Ma";
            SqlConnection con = connection.getSqlConnection();
            try
            {
                sqlCommand = new SqlCommand(sql, con);
                con.Open();
                sqlCommand.Parameters.Add
                    ("@MH_Ma", SqlDbType.NVarChar).Value = mh.MH_Ma;
                sqlCommand.Parameters.Add
                    ("@MH_Ten", SqlDbType.NVarChar).Value = mh.MH_Ten;
                sqlCommand.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool DeleteMonHoc(MonHoc mh) {
            string sql = "DELETE MonHoc WHERE MH_Ma = @MH_Ma";
            SqlConnection con = connection.getSqlConnection();
            try
            {
                sqlCommand = new SqlCommand(sql, con);
                con.Open();
                sqlCommand.Parameters.Add
                    ("@MH_Ma", SqlDbType.NVarChar).Value = mh.MH_Ma;
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
