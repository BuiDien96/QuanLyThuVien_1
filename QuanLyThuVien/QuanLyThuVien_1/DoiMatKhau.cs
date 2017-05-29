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
    public partial class DoiMatKhau : Form
    {
        public static string UserName = string.Empty;
        public static string Password = string.Empty;
        public DoiMatKhau()
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(Password))
            {
                this.txtTendangnhap.Text = UserName;

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMatkhaumoi.Text == "" || txtMatkhaucu.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            Admin admin = new Admin();
            admin.name = txtTendangnhap.Text;
            admin.pass = txtMatkhaumoi.Text;

            if (MessageBox.Show(string.Format("Bạn có muốn đổi mật khẩu không?"),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateAdmin(admin) > 0 && txtNhaplaimatkhau.Text == txtMatkhaumoi.Text && this.txtMatkhaucu.Text == Password)
                {
                    MessageBox.Show("Lưu thành công!");
                }
                else
                    MessageBox.Show("Lỗi");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn hủy không?");
            Dispose();
        }
    }
}
