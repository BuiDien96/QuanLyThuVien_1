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
    public partial class PhieuMuonTra : Form
    {
        public PhieuMuonTra()
        {
            InitializeComponent();
        }



        private void PhieuMuonTra_Load(object sender, EventArgs e)
        {
            dgvPhieumuontra.DataSource = Bus.GetListPhieumuontra();
            dgvPhieumuontra.Columns["maphieu"].HeaderText = "Mã phiếu";
            dgvPhieumuontra.Columns["ngaymuon"].HeaderText = "Ngày mượn";
            dgvPhieumuontra.Columns["ngaytra"].HeaderText = "Ngày trả";
            dgvPhieumuontra.Columns["ngayhentra"].HeaderText = "Ngày hẹn trả";
            dgvPhieumuontra.Columns["matt"].HeaderText = "Mã thủ thư";
            dgvPhieumuontra.Columns["madg"].HeaderText = "Mã độc giả";
        }

        private void txtTimkiem_Click(object sender, EventArgs e)
        {
            txtTimkiem.Text = string.Empty;
        }

        public void Hienthi(string phieumt)
        {
            dgvPhieumuontra.DataSource = Bus.SearchPhieumuontra(phieumt);
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            Hienthi("where maphieu like N'%" + txtTimkiem.Text + "%'");
        }
    }
}
