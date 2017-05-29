using QuanLyThuVien_1.BusinessLogicLayer;
using QuanLyThuVien_1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien_1
{
    public partial class TaoTaiKhoan : Form
    {
        public TaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtHoten.Text == "" || txtMatkhau.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            Admin admin = new Admin();
            admin.name = txtHoten.Text;
            admin.pass = txtMatkhau.Text;
            admin.diachi = txtDiachi.Text;
            admin.ngaysinh = dateNgaysinh.Value;
            admin.email = txtEmail.Text;
            admin.sdt = txtPhone.Text;

            if (MessageBox.Show(string.Format("Bạn có muốn tạo tài khoản thủ thư {0}", admin.name),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertAdmin(admin) > 0)
                {
                    MessageBox.Show("Lưu thành công!");
                }
                else
                    MessageBox.Show("Lỗi");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn hủy bỏ không?");
            Dispose();
        }
    }
}
