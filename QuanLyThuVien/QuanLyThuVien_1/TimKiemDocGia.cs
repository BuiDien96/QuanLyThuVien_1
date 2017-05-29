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
    public partial class TimKiemDocGia : Form
    {
        public TimKiemDocGia()
        {
            InitializeComponent();
        }

        private void txtTKMadg_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void HienthiTen(string docgia)
        {
            dgvTKTenDocgia.DataSource = Bus.SearchDG(docgia);
        }


        public void HienthiMa(string docgia)
        {
            dgvTKMaDocgia.DataSource = Bus.SearchDG(docgia);
        }

        private void btnSearchMaDG_Click(object sender, EventArgs e)
        {
            HienthiMa("where madg like N'%" + txtTKMadg.Text + "%'");
        }

        private void txtTKtendg_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSearchTenDG_Click(object sender, EventArgs e)
        {
            HienthiTen("where tendg like N'%" + txtTKtendg.Text + "%'");
        }

        private void txtTKMadg_Click(object sender, EventArgs e)
        {
            txtTKMadg.Text = string.Empty;
            
        }

        private void txtTKtendg_Click(object sender, EventArgs e)
        {
            txtTKtendg.Text = string.Empty;
            
        }

        private void TimKiemDocGia_Load(object sender, EventArgs e)
        {

        }
    }
}
