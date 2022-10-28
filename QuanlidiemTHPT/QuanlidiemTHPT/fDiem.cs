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
    public partial class fDiem : Form
    {
        SqlConnection conn;

        public fDiem()
        {
            InitializeComponent();
        }

        private void fDiem_Load(object sender, EventArgs e)
        {
            hienThiDtgv(dtgvDiem);
            hienThiCombobox("Select * from NamHoc", cbNamHoc, "NH_Ma", "NH_Ten");
            hienThiCombobox("Select * from Hocki", cbHocKi, "HK_Ma", "HK_Ten");
            hienThiCombobox("Select * from Khoi", cbKhoi, "Khoi_Ma", "Khoi_Ten");
            hienThiCombobox("Select * from Lop", cbLop, "Lop_Ma", "Lop_Ten");
        }

        public void ketnoi()
        {
            String ketnoi = "Server= KHANN\\ADMIN; Database= QuanLiDiem;integrated security=true";
            conn = new SqlConnection(ketnoi);
            conn.Open();
        }

        public void hienThiDtgv(DataGridView dtgv)
        {
            ketnoi();
            string query = "select * from ChiTietDiem";
            SqlDataAdapter dt = new SqlDataAdapter(query, conn);
            DataSet dts = new DataSet();
            dt.Fill(dts, "ChiTietDiem");
            dtgv.DataSource = dts;
            dtgv.DataMember = "ChiTietDiem";

        }

        public void hienThiCombobox(string query, ComboBox comb, string ma, string ten)
        {
            SqlCommand sql = new SqlCommand(query, conn);
            SqlDataReader read = sql.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(read);
            comb.DataSource = dt;
            comb.DisplayMember = ten;
            comb.ValueMember = ma;

        }

    

        public void hienThiLopTheoKhoi()
        {

        }

    }
}
