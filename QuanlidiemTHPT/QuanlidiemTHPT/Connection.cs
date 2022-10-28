using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanlidiemTHPT
{
    class Connection
    {
       private static string stringConnection= (@"Data Source=DUCVO; Initial Catalog= QuanLiDiem;Integrated Security= true");
      //  private static string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\LapTrinhUngDung\LTUngDung\QuanlidiemTHPT\QuanlidiemTHPT\Database1.mdf;Integrated Security=True";
        //  private static string stringConnection = "Server = KHANN\\ADMIN; database = QuanLiDiem; integrated security = true"; //Khangg
    //    private static string stringConnection = "Data Source=DESKTOP-SDUMHO6\\MSSQLSERVER03; Initial Catalog= QuanLiDiem;Integrated Security= true"; 

        public SqlConnection getSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
        

    }

}
