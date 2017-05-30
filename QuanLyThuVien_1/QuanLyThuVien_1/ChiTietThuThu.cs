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
    public partial class ChiTietThuThu : Form
    {
        public ChiTietThuThu()
        {
            InitializeComponent();
        }

        private void ChiTietThuThu_Load(object sender, EventArgs e)
        {
            dgvThuthu.DataSource = Bus.GetListThuthu();
            //chỉnh sửa giao diện
            dgvThuthu.Columns["matt"].HeaderText = "Mã thủ thư";
            dgvThuthu.Columns["tentt"].HeaderText = "Tên thủ thư";
            dgvThuthu.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            dgvThuthu.Columns["diachi"].HeaderText = "Địa chỉ";
            dgvThuthu.Columns["sdt"].HeaderText = "Số điện thoại";
        }
    }
}
