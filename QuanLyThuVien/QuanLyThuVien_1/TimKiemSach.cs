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
    public partial class TimKiemSach : Form
    {
        public TimKiemSach()
        {
            InitializeComponent();
        }

        private void txtTimkiem_Click(object sender, EventArgs e)
        {
            txtTimkiem.Text = string.Empty;
        }


        public void Hienthi(string sach)
        {
            dgvSearchSach.DataSource = Bus.SearchSach(sach);
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            Hienthi("where tensach like N'%" + txtTimkiem.Text + "%'");
        }
    }
}
