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
    public partial class ChiTietPhieuMuon : Form
    {
        public ChiTietPhieuMuon()
        {
            InitializeComponent();
        }

        private void ChiTietPhieuMuon_Load(object sender, EventArgs e)
        {
            dgvChitietphieumuon.DataSource = Bus.GetListChiTietPM();
            dgvChitietphieumuon.Columns["masach"].HeaderText = "Mã sách";
            dgvChitietphieumuon.Columns["maphieu"].HeaderText = "Mã phiếu";
            dgvChitietphieumuon.Columns["tinhtrangtruoc"].HeaderText = "Tình trạng trước";
            dgvChitietphieumuon.Columns["tinhtrangsau"].HeaderText = "Tình trạng sau";
        }
    }
}
