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
    public partial class TrangChu1 : Form
    {
        public TrangChu1()
        {
            InitializeComponent();
        }

        private void quảnTrịViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanTriVien quantrivien = new QuanTriVien();
            quantrivien.Show();
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLySach quanlysach = new QuanLySach();
            quanlysach.Show();
        }

        

        private void giớiThiệuPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GioiThieuPhanMem gt = new GioiThieuPhanMem();
            gt.Show();
        }

        private void tạoTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaoTaiKhoan taotk = new TaoTaiKhoan();
            taotk.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMatKhau doimk = new DoiMatKhau();
            doimk.Show();
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn đăng xuất không?");
            Dispose();
            DangNhap dangnhap = new DangNhap();
            dangnhap.Show();
        }
    }
}
