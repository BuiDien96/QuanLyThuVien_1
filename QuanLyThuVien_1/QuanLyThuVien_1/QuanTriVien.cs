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
    public partial class QuanTriVien : Form
    {
        public QuanTriVien()
        {
            InitializeComponent();
            QuanTriThuhu quantrithuthu = new QuanTriThuhu();
            //TabPage tabpage = new TabPage();
            //tabQuanTriVien.TabPages.Add(tabpage);
            quantrithuthu.TopLevel = false;
            pnlQuantrithuthu.Controls.Add(quantrithuthu);
            //quantrithuthu.Parent = tabpage;
            quantrithuthu.Show();
            quantrithuthu.Dock = DockStyle.Fill;

            ChiTietThuThu chitiet = new ChiTietThuThu();
            chitiet.TopLevel = false;
            pnlChitetthuthu.Controls.Add(chitiet);
            chitiet.Show();
            chitiet.Dock = DockStyle.Fill;
        }
    }
}
