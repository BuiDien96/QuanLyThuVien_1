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
    public partial class QuanTriThuhu : Form
    {
        public QuanTriThuhu()
        {
            InitializeComponent();
            
        }

        public void QuanTriThuhu_Load(object sender, EventArgs e)
        {
            dgvThuthu.DataSource = Bus.GetListThuthu();
            //chỉnh sửa giao diện
            dgvThuthu.Columns["matt"].HeaderText = "Mã thủ thư";
            dgvThuthu.Columns["tentt"].HeaderText = "Tên thủ thư";
            dgvThuthu.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            dgvThuthu.Columns["diachi"].HeaderText = "Địa chỉ";
            dgvThuthu.Columns["sdt"].HeaderText = "Số điện thoại";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMatt.Text = string.Empty;
            txtTentt.Text = string.Empty;
            txtDiachi.Text = string.Empty;
            dateNgaySinhtt.Value = DateTime.Now;
            txtSdt.Text = string.Empty;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMatt.Text == " " || txtTentt.Text == " ")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!");
                return;
            }

            ThuThu1 tt = new ThuThu1();
            tt.matt = txtMatt.Text;
            tt.tentt = txtTentt.Text;
            tt.ngaysinh = dateNgaySinhtt.Value;
            tt.diachi = txtDiachi.Text;
            tt.sdt = txtSdt.Text;
            if (MessageBox.Show(string.Format("Bạn có muốn thêm thủ thư {0} tên thủ thư {1}", tt.matt, tt.tentt),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.Insert(tt) > 0)
                {
                    MessageBox.Show("Thêm thành công!");
                    QuanTriThuhu_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi!");
            }
        }

        private void dgvThuthu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMatt.Text = dgvThuthu.CurrentRow.Cells["matt"].Value.ToString();
            txtTentt.Text = dgvThuthu.CurrentRow.Cells["tentt"].Value.ToString();
            dateNgaySinhtt.Text = dgvThuthu.CurrentRow.Cells["ngaysinh"].Value.ToString();
            txtDiachi.Text = dgvThuthu.CurrentRow.Cells["diachi"].Value.ToString();
            txtSdt.Text = dgvThuthu.CurrentRow.Cells["sdt"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMatt.Text == " " || txtTentt.Text == " ")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!");
                return;
            }

            ThuThu1 tt = new ThuThu1();
            tt.matt = txtMatt.Text;
            tt.tentt = txtTentt.Text;
            tt.ngaysinh = dateNgaySinhtt.Value;
            tt.diachi = txtDiachi.Text;
            tt.sdt = txtSdt.Text;
            if (MessageBox.Show(string.Format("Bạn có muốn sửa thủ thư {0} tên thủ thư {1}", tt.matt, tt.tentt),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.Update(tt) > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                    QuanTriThuhu_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMatt.Text == " " || txtTentt.Text == " ")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!");
                return;
            }

            ThuThu1 tt = new ThuThu1();
            tt.matt = txtMatt.Text;
            tt.tentt = txtTentt.Text;
            tt.ngaysinh = dateNgaySinhtt.Value;
            tt.diachi = txtDiachi.Text;
            tt.sdt = txtSdt.Text;
            if (MessageBox.Show(string.Format("Bạn có muốn xóa thủ thư {0} tên thủ thư {1}", tt.matt, tt.tentt),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.Delete(tt) > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    QuanTriThuhu_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi!");
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            
        }
    }
}
