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
    public partial class ChiTietSach : Form
    {
        public ChiTietSach()
        {
            InitializeComponent();
        }

        private void ChiTietSach_Load(object sender, EventArgs e)
        {
            dgvSach.DataSource = Bus.GetListSach();
            dgvSach.Columns["masach"].HeaderText = "Mã sách";
            dgvSach.Columns["tensach"].HeaderText = "Tên sách";
            dgvSach.Columns["tinhtrang"].HeaderText = "Tình trạng";
            dgvSach.Columns["matt"].HeaderText = "Mã thủ thư";
            dgvSach.Columns["manxb"].HeaderText = "Mã NXB";
            dgvSach.Columns["matheloai"].HeaderText = "Mã thể loại";
            //hien thi cbx
            
        }
    }
}
