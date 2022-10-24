using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlidiemTHPT
{
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }

        private void fDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel_quenmatkhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fQuenMatKhau quenMatKhau = new fQuenMatKhau();
            quenMatKhau.ShowDialog();
        }

        private void linkLabel_dangky_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fDangky dangky = new fDangky();
            dangky.ShowDialog();
        }
        Modify modify = new Modify();
        private void button1_Click(object sender, EventArgs e)
        {
            string tentk = textBox_tentaikhoan.Text;
            string matkhau = textBox_matkhau.Text;
            if (tentk.Trim() == "") { MessageBox.Show("Vui lòng nhập tên tài khoản!");  }
            else if(matkhau.Trim() == "") { MessageBox.Show("Vui lòng nhập mật khẩu!"); }

            else
            {
                string query = "Select * from TaiKhoan where TenTaiKhoan ='"+tentk+"' and MatKhau = '"+matkhau+"'";
                if(modify.TaiKhoans(query).Count!=0)
                {
                    MessageBox.Show("Đăng nhập thành công!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    fMain fmain = new fMain();
                    fmain.ShowDialog();
                    this.Close();
                   
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
