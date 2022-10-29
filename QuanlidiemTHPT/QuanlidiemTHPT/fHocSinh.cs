using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanlidiemTHPT
{
    public partial class fHocSinh : Form
    {

        public SqlConnection conn;


        public fHocSinh()
        {
            InitializeComponent();
        }

  
        public void ketnoi()
        {
            String ketnoiDB = "Server = DESKTOP-V3GQV9Q; database = QuanLiDiem; integrated security = true";
            conn = new SqlConnection(ketnoiDB);
            conn.Open();
        }


        public void ShowData(string truyvanDB, DataGridView dg)
        {
            SqlDataAdapter dta = new SqlDataAdapter(truyvanDB, conn);
            DataSet ds = new DataSet();
            dta.Fill(ds, "HocSinh");
            dg.DataSource = ds;
            dg.DataMember = "HocSinh";
            ketnoi();
        }


        private void fHocSinh_Load(object sender, EventArgs e)
        {

            ketnoi();
            ShowData("SELECT * from HocSinh", luoidulieuhs);

            HienThiCombobox("Select * from Khoi", Tkkhoihs, "Khoi_Ten");
            HienThiCombobox("Select * from Lop", Tklophs, "Lop_Ten");

            HienThiCombobox("Select * from Lop", Lophs, "Lop_Ten");
            HienThiCombobox("Select * from HocSinh", Gtinhhs, "HS_GioiTinh");

        }

        private void luoidatahs(object sender, DataGridViewCellEventArgs e)
        {
             Mahs.Text = luoidulieuhs.Rows[e.RowIndex].Cells[0].Value.ToString();
             Tenhs.Text = luoidulieuhs.Rows[e.RowIndex].Cells[1].Value.ToString();
             Dchihs.Text = luoidulieuhs.Rows[e.RowIndex].Cells[2].Value.ToString();
             Gtinhhs.Text = luoidulieuhs.Rows[e.RowIndex].Cells[3].Value.ToString();
             Emailhs.Text = luoidulieuhs.Rows[e.RowIndex].Cells[4].Value.ToString();
             Nsinhhs.Text = luoidulieuhs.Rows[e.RowIndex].Cells[5].Value.ToString();
             Sdths.Text = luoidulieuhs.Rows[e.RowIndex].Cells[6].Value.ToString();
        }



        public void HienThiCombobox(string truyvanDB, ComboBox comb, string ten)
        {
            SqlCommand sql = new SqlCommand(truyvanDB, conn);
            SqlDataReader read = sql.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(read);
            comb.DataSource = dt;
            comb.DisplayMember = ten;
     
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            Mahs.Text = "";
            Tenhs.Text = "";
            Dchihs.Text = "";
            Gtinhhs.Text = "";
            Emailhs.Text = "";
            Nsinhhs.Text = "";
            Sdths.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            String MaHS = Mahs.Text;
            String HoTen = Tenhs.Text;
            String Dchi = Dchihs.Text;
            String Gtinh = Gtinhhs.Text;
            String Email = Emailhs.Text;
            String Ngsinh = Nsinhhs.Text;
            String Sdt= Sdths.Text;

            string luu_sql = "insert into HocSinh values ( N'" + MaHS + "', N'" + HoTen + "', N'" + Dchi + "', N'" + Gtinh + "', N'" + Email + "', N'" + DateTime.ParseExact(Ngsinh, "dd/MM/yyyy", null) + "',  N'" + Sdt + "')";
            SqlCommand luu = new SqlCommand(luu_sql, conn);
            luu.ExecuteNonQuery();
            MessageBox.Show("Lưu thành công");
            ShowData("select* from HocSinh", luoidulieuhs);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mahs = Mahs.Text;
            if (mahs == "")
            {
                MessageBox.Show("Chưa chọn học sinh");
            }
            else
            {
                string xoa_sql = "Delete from HocSinh where HS_MA = '" + mahs + "' ";
                SqlCommand comd = new SqlCommand(xoa_sql, conn);
                comd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                ShowData("select* from HocSinh", luoidulieuhs);

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            String MaHS = Mahs.Text;
            String HoTen = Tenhs.Text;
            String Dchi = Dchihs.Text;
            String Gtinh = Gtinhhs.Text;
            String Email = Emailhs.Text;
            String Ngsinh = Nsinhhs.Text;
            String Sdt = Sdths.Text;

            string sua_sql = "update HocSinh set HS_Ma = N'" + MaHS + "', HS_HoTen = N'" + HoTen + "', HS_DiaChi = N'" + Dchi + "', HS_GioiTinh = N'" + Gtinh + "', HS_Gmail = N'" + Email + "', HS_NgaySinh = N'" + DateTime.ParseExact(Ngsinh, "dd/MM/yyyy", null) + "', HS_SDT = N'" + Sdt + "'";
            SqlCommand sua = new SqlCommand(sua_sql, conn);
            sua.ExecuteNonQuery();
            MessageBox.Show("Sửa thành công");
            ShowData("select* from HocSinh", luoidulieuhs);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
