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
    public partial class QuanLyMuonTra : Form
    {
        public QuanLyMuonTra()
        {
            InitializeComponent();

            PhieuMuonTra phieumuontra = new PhieuMuonTra();
            phieumuontra.TopLevel = false;
            pnPhieuMuonTra.Controls.Add(phieumuontra);
            phieumuontra.Show();
            phieumuontra.Dock = DockStyle.Fill;

            ChiTietPhieuMuon chititetphieumun = new ChiTietPhieuMuon();
            chititetphieumun.TopLevel = false;
            pnlChitietphieumuon.Controls.Add(chititetphieumun);
            chititetphieumun.Show();
            chititetphieumun.Dock = DockStyle.Fill;
        }
    }
}
