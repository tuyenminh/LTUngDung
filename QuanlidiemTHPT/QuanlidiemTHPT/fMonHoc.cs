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
    public partial class fMonHoc : Form
    {
        LienKetGDMonHoc bllMH;
        private object qli;

        public fMonHoc()
        {
            InitializeComponent();
            bllMH = new LienKetGDMonHoc();
        }
        public void ShowMonHoc() {
            DataTable dataTable = bllMH.getMonHoc();
            dataGridViewMonHoc.DataSource = dataTable;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckData()) {
                MonHoc monHoc = new MonHoc();
                monHoc.MH_Ma = textMH_Ma.Text;
                monHoc.MH_Ten = textMH_Ten.Text;

                if (bllMH.InsertMonHoc(monHoc))
                    ShowMonHoc();
                else
                    MessageBox.Show("Có lỗi xảy ra, hãy thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                MonHoc monHoc = new MonHoc();
                monHoc.MH_Ma = textMH_Ma.Text;
                monHoc.MH_Ten = textMH_Ten.Text;

                if (bllMH.UpdateMonHoc(monHoc))
                    ShowMonHoc();
                else
                    MessageBox.Show("Có lỗi xảy ra, hãy thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void fMonHoc_Load(object sender, EventArgs e)
        {
            ShowMonHoc();
        }
        public bool CheckData() {
            if (string.IsNullOrEmpty(textMH_Ma.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textMH_Ma.Focus();
            return false;
            }
            if (string.IsNullOrEmpty(textMH_Ten.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textMH_Ten.Focus();
                return false;
            }
            return true;  
        }
        private void dataGridViewMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0) {
                textMH_Ma.Text =  dataGridViewMonHoc.Rows[index].Cells["MH_Ma"].Value.ToString();
                textMH_Ten.Text = dataGridViewMonHoc.Rows[index].Cells["MH_Ten"].Value.ToString();

            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không? ", "Cảnh báo !!!",MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                MonHoc monHoc = new MonHoc();
                monHoc.MH_Ma = textMH_Ma.Text;
                if (bllMH.DeleteMonHoc(monHoc))
                    ShowMonHoc();
                else
                    MessageBox.Show("Có lỗi xảy ra, hãy thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
           

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttokList_Click(object sender, EventArgs e)
        {

        }
    }
}
