namespace QuanLyThuVien_1
{
    partial class QuanLyBanDoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabTheDocGia = new System.Windows.Forms.TabPage();
            this.pnlTheDocGia = new System.Windows.Forms.Panel();
            this.tabChiTietDocGia = new System.Windows.Forms.TabPage();
            this.pnlChitietdocgia = new System.Windows.Forms.Panel();
            this.tabDocGia = new System.Windows.Forms.TabPage();
            this.pnlDocGia = new System.Windows.Forms.Panel();
            this.tabQuanLyBanDoc = new System.Windows.Forms.TabControl();
            this.tabTheDocGia.SuspendLayout();
            this.tabChiTietDocGia.SuspendLayout();
            this.tabDocGia.SuspendLayout();
            this.tabQuanLyBanDoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabTheDocGia
            // 
            this.tabTheDocGia.Controls.Add(this.pnlTheDocGia);
            this.tabTheDocGia.Location = new System.Drawing.Point(4, 22);
            this.tabTheDocGia.Name = "tabTheDocGia";
            this.tabTheDocGia.Padding = new System.Windows.Forms.Padding(3);
            this.tabTheDocGia.Size = new System.Drawing.Size(797, 435);
            this.tabTheDocGia.TabIndex = 2;
            this.tabTheDocGia.Text = "THẺ ĐỘC GIẢ";
            this.tabTheDocGia.UseVisualStyleBackColor = true;
            // 
            // pnlTheDocGia
            // 
            this.pnlTheDocGia.Location = new System.Drawing.Point(4, 26);
            this.pnlTheDocGia.Name = "pnlTheDocGia";
            this.pnlTheDocGia.Size = new System.Drawing.Size(787, 403);
            this.pnlTheDocGia.TabIndex = 0;
            // 
            // tabChiTietDocGia
            // 
            this.tabChiTietDocGia.Controls.Add(this.pnlChitietdocgia);
            this.tabChiTietDocGia.Location = new System.Drawing.Point(4, 22);
            this.tabChiTietDocGia.Name = "tabChiTietDocGia";
            this.tabChiTietDocGia.Padding = new System.Windows.Forms.Padding(3);
            this.tabChiTietDocGia.Size = new System.Drawing.Size(797, 435);
            this.tabChiTietDocGia.TabIndex = 1;
            this.tabChiTietDocGia.Text = "CHI TIẾT ĐỘC GIẢ";
            this.tabChiTietDocGia.UseVisualStyleBackColor = true;
            // 
            // pnlChitietdocgia
            // 
            this.pnlChitietdocgia.Location = new System.Drawing.Point(3, 30);
            this.pnlChitietdocgia.Name = "pnlChitietdocgia";
            this.pnlChitietdocgia.Size = new System.Drawing.Size(788, 399);
            this.pnlChitietdocgia.TabIndex = 0;
            // 
            // tabDocGia
            // 
            this.tabDocGia.Controls.Add(this.pnlDocGia);
            this.tabDocGia.Location = new System.Drawing.Point(4, 22);
            this.tabDocGia.Name = "tabDocGia";
            this.tabDocGia.Padding = new System.Windows.Forms.Padding(3);
            this.tabDocGia.Size = new System.Drawing.Size(797, 435);
            this.tabDocGia.TabIndex = 0;
            this.tabDocGia.Text = "ĐỘC GIẢ";
            this.tabDocGia.UseVisualStyleBackColor = true;
            // 
            // pnlDocGia
            // 
            this.pnlDocGia.Location = new System.Drawing.Point(4, 34);
            this.pnlDocGia.Name = "pnlDocGia";
            this.pnlDocGia.Size = new System.Drawing.Size(787, 395);
            this.pnlDocGia.TabIndex = 0;
            // 
            // tabQuanLyBanDoc
            // 
            this.tabQuanLyBanDoc.Controls.Add(this.tabDocGia);
            this.tabQuanLyBanDoc.Controls.Add(this.tabChiTietDocGia);
            this.tabQuanLyBanDoc.Controls.Add(this.tabTheDocGia);
            this.tabQuanLyBanDoc.Location = new System.Drawing.Point(13, 13);
            this.tabQuanLyBanDoc.Name = "tabQuanLyBanDoc";
            this.tabQuanLyBanDoc.SelectedIndex = 0;
            this.tabQuanLyBanDoc.Size = new System.Drawing.Size(805, 461);
            this.tabQuanLyBanDoc.TabIndex = 0;
            // 
            // QuanLyBanDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 486);
            this.Controls.Add(this.tabQuanLyBanDoc);
            this.Name = "QuanLyBanDoc";
            this.Text = "QuanLyBanDoc";
            this.tabTheDocGia.ResumeLayout(false);
            this.tabChiTietDocGia.ResumeLayout(false);
            this.tabDocGia.ResumeLayout(false);
            this.tabQuanLyBanDoc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabTheDocGia;
        private System.Windows.Forms.Panel pnlTheDocGia;
        private System.Windows.Forms.TabPage tabChiTietDocGia;
        private System.Windows.Forms.Panel pnlChitietdocgia;
        private System.Windows.Forms.TabPage tabDocGia;
        private System.Windows.Forms.Panel pnlDocGia;
        private System.Windows.Forms.TabControl tabQuanLyBanDoc;
    }
}