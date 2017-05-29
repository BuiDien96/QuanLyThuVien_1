﻿using QuanLyThuVien_1.BusinessLogicLayer;
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
    public partial class ThongKeTheLoai : Form
    {
        public ThongKeTheLoai()
        {
            InitializeComponent();
        }

        private void ThongKeTheLoai_Load(object sender, EventArgs e)
        {
            dgvTheloai.DataSource = Bus.GetListTheLoai();
            dgvTheloai.Columns["matheloai"].HeaderText = "Mã thể loại";
            dgvTheloai.Columns["tentheloai"].HeaderText = "Tên thể loại";
        }
    }
}
