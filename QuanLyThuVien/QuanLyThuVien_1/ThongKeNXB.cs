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
    public partial class ThongKeNXB : Form
    {
        public ThongKeNXB()
        {
            InitializeComponent();
        }

        private void ThongKeNXB_Load(object sender, EventArgs e)
        {
            dgvNXB.DataSource = Bus.GetListNhaXB();
            dgvNXB.Columns["manxb"].HeaderText = "Mã nhà xuất bản";
            dgvNXB.Columns["tennxb"].HeaderText = "Tên nhà xuất bản";
            dgvNXB.Columns["diachi"].HeaderText = "Địa chỉ";
        }
    }
}
