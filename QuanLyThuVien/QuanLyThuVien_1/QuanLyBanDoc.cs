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
    public partial class QuanLyBanDoc : Form
    {
        public QuanLyBanDoc()
        {
            InitializeComponent();
            DocGia docgia = new DocGia();
            docgia.TopLevel = false;
            pnlDocGia.Controls.Add(docgia);
            docgia.Show();
            docgia.Dock = DockStyle.Fill;


            //chi tiet doc gia
            ChiTietDocGia chitietdocgia = new ChiTietDocGia();
            chitietdocgia.TopLevel = false;
            pnlChitietdocgia.Controls.Add(chitietdocgia);
            chitietdocgia.Show();
            chitietdocgia.Dock = DockStyle.Fill;

            //the doc gia
            TheDocGia thedocgia = new TheDocGia();
            thedocgia.TopLevel = false;
            pnlTheDocGia.Controls.Add(thedocgia);
            thedocgia.Show();
            thedocgia.Dock = DockStyle.Fill;
        }
    }
}
