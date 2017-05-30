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
    public partial class QuanLySach : Form
    {
        public QuanLySach()
        {
            InitializeComponent();
            ThongTinSach thongtinsach = new ThongTinSach();
            thongtinsach.TopLevel = false;
            pnlThongTin.Controls.Add(thongtinsach);
            thongtinsach.Show();
            thongtinsach.Dock = DockStyle.Fill;

            ChiTietSach chitietsach = new ChiTietSach();
            chitietsach.TopLevel = false;
            pnlChiTiet.Controls.Add(chitietsach);
            chitietsach.Show();
            chitietsach.Dock = DockStyle.Fill;
        }
    }
}
