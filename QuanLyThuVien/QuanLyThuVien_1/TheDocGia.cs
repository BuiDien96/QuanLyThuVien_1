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
    public partial class TheDocGia : Form
    {
        public TheDocGia()
        {
            InitializeComponent();
        }

        private void TheDocGia_Load(object sender, EventArgs e)
        {
            dgvThedocgia.DataSource = Bus.GetListThedg();
            dgvThedocgia.Columns["mathe"].HeaderText = "Mã thẻ";
            dgvThedocgia.Columns["ngaylam"].HeaderText = "Ngày làm";
            dgvThedocgia.Columns["ngayhethan"].HeaderText = "Ngày hết hạn";
            dgvThedocgia.Columns["matt"].HeaderText = "Mã thủ thư";
            dgvThedocgia.Columns["madg"].HeaderText = "Mã độc giả";

            
        }

        private void txtTimkiem_Click(object sender, EventArgs e)
        {
            txtTimkiem.Text = string.Empty;
        }

        public void Hienthi(string thedg)
        {
            dgvThedocgia.DataSource = Bus.SearchThedg(thedg);
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            Hienthi("where mathe like N'%" + txtTimkiem.Text + "%'");
        }
    }
}
