using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlidiemTHPT
{
    public partial class fThongTinHS : Form
    {

        Connection connection;

        public fThongTinHS()
        {
            connection = new Connection();
            InitializeComponent();
        }

        

        private void fThongTinSV_Load(object sender, EventArgs e)
        {
            SqlConnection conn = connection.getSqlConnection();
            hienThiDiem();
                hienThiCombobox("Select * from NamHoc", cbNH, "NH_Ma", "NH_Ten");
                hienThiCombobox("Select * from Hocki", cbHK, "HK_Ma", "HK_Ten");
                hienThiCombobox("Select * from Khoi", cbK, "Khoi_Ma", "Khoi_Ten");
                hienThiCombobox("Select * from Lop", cbL, "Lop_Ma", "Lop_Ten"); 
            conn.Open();
        }

        public void hienThiDiem()
        {
            SqlConnection conn = connection.getSqlConnection();
            string query = "select * from ChiTietDiem";
            SqlDataAdapter dta = new SqlDataAdapter(query, conn);
            conn.Open();
            DataSet dts = new DataSet();
            dta.Fill(dts, "ChiTietDiem");
            dtgvChiTiet.DataSource = dts;
            dtgvChiTiet.DataMember = "ChiTietDiem";
            conn.Close();

        }

        public void hienThiCombobox(string query, ComboBox comb, string ma, string ten)
        {
            SqlConnection conn = connection.getSqlConnection();
            conn.Open();
            SqlCommand sql = new SqlCommand(query, conn);
            SqlDataReader read = sql.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(read);
            comb.DataSource = dt;
            comb.DisplayMember = ten;
            comb.ValueMember = ma;
            conn.Close();

        }
        

        public void hienThiLopTheoKhoi(string maKhoi, string ma, string ten)
        {
            SqlConnection conn = connection.getSqlConnection();
            string query = "select * form Lop where Khoi_Ma = N'" + maKhoi + "'"; 
            SqlCommand sql = new SqlCommand(query, conn);
            SqlDataReader read = sql.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(read);
            cbL.DataSource = dt;
            cbL.DisplayMember = ten;
            cbL.ValueMember = ma;
        }

        private void cbK_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
