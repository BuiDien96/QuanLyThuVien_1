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
    public partial class DocGia : Form
    {
        public DocGia()
        {
            InitializeComponent();
        }

        private void DocGia_Load(object sender, EventArgs e)
        {
            dgvDocgia.DataSource = Bus.GetListDocGia();
            //chỉnh sửa giao diện
            dgvDocgia.Columns["madg"].HeaderText = "Mã độc giả";
            dgvDocgia.Columns["tendg"].HeaderText = "Tên độc giả";
            dgvDocgia.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            dgvDocgia.Columns["gioitinh"].HeaderText = "Giới tính";
            dgvDocgia.Columns["diachi"].HeaderText = "Địa chỉ";
        }

        private void dgvDocgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMadg.Text = dgvDocgia.CurrentRow.Cells["madg"].Value.ToString();
            txtTendg.Text = dgvDocgia.CurrentRow.Cells["tendg"].Value.ToString();
            dateNgaysinh.Text = dgvDocgia.CurrentRow.Cells["ngaysinh"].Value.ToString();
            txtGioitinh.Text = dgvDocgia.CurrentRow.Cells["gioitinh"].Value.ToString();
            txtDiachi.Text = dgvDocgia.CurrentRow.Cells["diachi"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMadg.Text = string.Empty;
            txtTendg.Text = string.Empty;
            txtDiachi.Text = string.Empty;
            txtGioitinh.Text = string.Empty;
            dateNgaysinh.Value = DateTime.Now;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMadg.Text == " " || txtTendg.Text == " ")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!");
                return;
            }

            DocGia1 dg = new DocGia1();
            dg.madg = txtMadg.Text;
            dg.tendg = txtTendg.Text;
            dg.ngaysinh = dateNgaysinh.Value;
            dg.gioitinh = txtGioitinh.Text;
            dg.diachi = txtDiachi.Text;
            if (MessageBox.Show(string.Format("Bạn có muốn thêm độc giả {0} tên độc giả {1}", dg.madg, dg.tendg),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertDG(dg) > 0)
                {
                    MessageBox.Show("Thêm thành công!");
                    DocGia_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMadg.Text == " " || txtTendg.Text == " ")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!");
                return;
            }

            DocGia1 dg = new DocGia1();
            dg.madg = txtMadg.Text;
            dg.tendg = txtTendg.Text;
            dg.ngaysinh = dateNgaysinh.Value;
            dg.gioitinh = txtGioitinh.Text;
            dg.diachi = txtDiachi.Text;
            if (MessageBox.Show(string.Format("Bạn có muốn sửa độc giả {0} tên độc giả {1}", dg.madg, dg.tendg),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.Update(dg) > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                    DocGia_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMadg.Text == " " || txtTendg.Text == " ")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!");
                return;
            }

            DocGia1 dg = new DocGia1();
            dg.madg = txtMadg.Text;
            dg.tendg = txtTendg.Text;
            dg.ngaysinh = dateNgaysinh.Value;
            dg.gioitinh = txtGioitinh.Text;
            dg.diachi = txtDiachi.Text;
            if (MessageBox.Show(string.Format("Bạn có muốn xóa độc giả {0} tên độc giả {1}", dg.madg, dg.tendg),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteDG(dg) > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    DocGia_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi!");
            }
        }
    }
}
