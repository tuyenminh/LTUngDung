using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QuanlidiemTHPT
{
    public partial class fDangky : Form
    {
        public fDangky()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        public bool CheckAccount(string ac) //check mat khau va ten tai khoan
        {

            return Regex.IsMatch(ac, "^[ac-zA-Z0-9]{6,24}$");
        }
        public bool CheckEmail(string em) // check email
        {
            return Regex.IsMatch(em, @"^[ac-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
        Modify modify = new Modify();
        private void button_dangky_Click(object sender, EventArgs e)
        {
            string tentk = textBox_tentaikhoan.Text;
            string matkhau = textBox_matkhau.Text;
            string xnmatkhau = textBox_xnmatkhau.Text;
            string email = textBox_email.Text;

            if(!CheckAccount(tentk)) { MessageBox.Show("Vui lòng nhập tên tài khoản dài 6-24 ký tự, với các ký tự và số, chữ hoa và chữ thường!"); return; }
            if (!CheckAccount(matkhau)) { MessageBox.Show("Vui lòng nhập tên mật khẩu dài 6-24 ký tự, với các ký tự và số, chữ hoa và chữ thường!"); return; }
            if(xnmatkhau != matkhau) { MessageBox.Show("Vui lòng xác nhận mật khẩu chính xác!"); return; }
            if(!CheckEmail(email)) { MessageBox.Show("Vui lòng nhập đúng định dạng email!"); return; }
            if(modify.TaiKhoans("Select * from TaiKhoan where Email = '" +email+ "'").Count !=0) { MessageBox.Show("Email này đã được đăng ký, vui lòng nhập mail khác!"); return; }
            try
            {
                string query = "Insert into TaiKhoan values ('" +tentk+ "', '" +matkhau+ "','" +email+"')";
                modify.Command(query);
                if (MessageBox.Show("Đăng ký thành công! Bạn có muốn đăng nhập ngay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Tên tài khoản đã được đăng ký, vui lòng đăng kí tên tài khoản khác!");
            }
        }
    }
}
