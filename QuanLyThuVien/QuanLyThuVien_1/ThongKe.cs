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
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
            //thong ke doc gia
            ChiTietDocGia chitietdocgia = new ChiTietDocGia();
            chitietdocgia.TopLevel = false;
            pnlDocgia.Controls.Add(chitietdocgia);
            chitietdocgia.Show();
            chitietdocgia.Dock = DockStyle.Fill;

            //thong ke sach
            ChiTietSach chitietsach = new ChiTietSach();
            chitietsach.TopLevel = false;
            pnlSach.Controls.Add(chitietsach);
            chitietsach.Show();
            chitietsach.Dock = DockStyle.Fill;

            //thong ke nxb
            ThongKeNXB nxb = new ThongKeNXB();
            nxb.TopLevel = false;
            pnlNXB.Controls.Add(nxb);
            nxb.Show();
            nxb.Dock = DockStyle.Fill;

            //thong ke the loai
            ThongKeTheLoai theloai = new ThongKeTheLoai();
            theloai.TopLevel = false;
            pnlTheloai.Controls.Add(theloai);
            theloai.Show();
            theloai.Dock = DockStyle.Fill;
        }
    }
}
