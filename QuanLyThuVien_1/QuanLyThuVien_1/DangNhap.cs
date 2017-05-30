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

namespace QuanLyThuVien_1
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
            txtPassword.MaxLength = 10;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Server=DESKTOP-KBSLCQ1\SQLEXPRESS;Database=QuanLyThuVien;Trusted_Connection=true");
            SqlDataAdapter da = new SqlDataAdapter("select count(*) from admin  where name = '" + txtTendangnhap.Text + "' and  pass ='" + txtPassword.Text + "'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                TrangChu1 trangchu = new TrangChu1();
                trangchu.Show();
                DoiMatKhau.UserName = txtTendangnhap.Text;
                DoiMatKhau.Password = txtPassword.Text;
            }
            else
            {
                MessageBox.Show("sai mật khẩu hoặc tên đăng nhập ");

            }
            txtTendangnhap.Clear();
            txtPassword.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ckbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
