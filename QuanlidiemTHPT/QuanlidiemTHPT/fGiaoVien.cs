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
    public partial class fGiaoVien : Form
    {

        public SqlConnection conn;

        public fGiaoVien()
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
            dta.Fill(ds, "GiaoVien");
            dg.DataSource = ds;
            dg.DataMember = "GiaoVien";
            ketnoi();
        }

        private void fGiaoVien_Load(object sender, EventArgs e)
        {
            ketnoi();

            ShowData("SELECT * from GiaoVien", luoidulieugv);

            HienThiCombobox("Select * from ChucVu", Cvugv, "CV_Ten");
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

        private void luoidatagv(object sender, DataGridViewCellEventArgs e)
        {
            Magv.Text = luoidulieugv.Rows[e.RowIndex].Cells[0].Value.ToString();
            Tengv.Text = luoidulieugv.Rows[e.RowIndex].Cells[1].Value.ToString();
            Tendngv.Text = luoidulieugv.Rows[e.RowIndex].Cells[2].Value.ToString();
            mkgv.Text = luoidulieugv.Rows[e.RowIndex].Cells[3].Value.ToString();
            Gtinhgv.Text = luoidulieugv.Rows[e.RowIndex].Cells[4].Value.ToString();
            Dchigv.Text = luoidulieugv.Rows[e.RowIndex].Cells[5].Value.ToString();
            Nsinhgv.Text = luoidulieugv.Rows[e.RowIndex].Cells[6].Value.ToString();
            Emailgv.Text = luoidulieugv.Rows[e.RowIndex].Cells[7].Value.ToString();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            Magv.Text = "";
            Tengv.Text = "";
            Tendngv.Text = "";
            mkgv.Text = "";
            Gtinhgv.Text = "";
            Dchigv.Text = "";
            Nsinhgv.Text = "";
            Emailgv.Text = "";
        
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
        
                String MaGV = Magv.Text;
                String HoTen = Tengv.Text;
                String TenDN = Dchigv.Text;
                String MK = mkgv.Text;
                String Gtinh = Gtinhgv.Text;
                String Dchi = Dchigv.Text;
                String Ngsinh = Nsinhgv.Text;
                String Email = Emailgv.Text;
                
         
                string luu_sql = "insert into GiaoVien values ( N'" + MaGV + "', N'" + HoTen + "', N'" + TenDN + "', N'" + MK + "', N'" + Gtinh + "', N'" + Dchi + "', N'" + DateTime.ParseExact(Ngsinh, "dd/MM/yyyy", null) + "',  N'" + Email + "')";
                SqlCommand luu = new SqlCommand(luu_sql, conn);
                luu.ExecuteNonQuery();
                MessageBox.Show("Lưu thành công");
                ShowData("select* from GiaoVien", luoidulieugv);

            
        }
    }
}
