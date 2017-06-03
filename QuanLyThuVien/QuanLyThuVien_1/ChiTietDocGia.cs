using QuanLyThuVien_1.BusinessLogicLayer;
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
    public partial class ChiTietDocGia : Form
    {
        public ChiTietDocGia()
        {
            InitializeComponent();

        }

        private void ChiTietDocGia_Load(object sender, EventArgs e)
        {
            dgvDocgia.DataSource = Bus.GetListDocGia();
            //chỉnh sửa giao diện
            dgvDocgia.Columns["madg"].HeaderText = "Mã độc giả";
            dgvDocgia.Columns["tendg"].HeaderText = "Tên độc giả";
            dgvDocgia.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            dgvDocgia.Columns["gioitinh"].HeaderText = "Giới tính";
            dgvDocgia.Columns["diachi"].HeaderText = "Địa chỉ";
        }
    }
}
