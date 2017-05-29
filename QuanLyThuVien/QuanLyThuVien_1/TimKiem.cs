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
    public partial class TimKiem : Form
    {
        public TimKiem()
        {
            InitializeComponent();

            //tim kiem doc gia
            TimKiemDocGia tkdocgia = new TimKiemDocGia();
            tkdocgia.TopLevel = false;
            pnlDocgia.Controls.Add(tkdocgia);
            tkdocgia.Show();
            tkdocgia.Dock = DockStyle.Fill;

            //tim kiem sách
            TimKiemSach tksach = new TimKiemSach();
            tksach.TopLevel = false;
            pnlSach.Controls.Add(tksach);
            tksach.Show();
            tksach.Dock = DockStyle.Fill;

        }

        
    }
}
