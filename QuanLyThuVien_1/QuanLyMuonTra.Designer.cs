namespace QuanLyThuVien_1
{
    partial class QuanLyMuonTra
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
            this.tabQuanLyMuonTra = new System.Windows.Forms.TabControl();
            this.tabPhieuMuonTra = new System.Windows.Forms.TabPage();
            this.tabChitietphieumuon = new System.Windows.Forms.TabPage();
            this.pnPhieuMuonTra = new System.Windows.Forms.Panel();
            this.pnlChitietphieumuon = new System.Windows.Forms.Panel();
            this.tabQuanLyMuonTra.SuspendLayout();
            this.tabPhieuMuonTra.SuspendLayout();
            this.tabChitietphieumuon.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabQuanLyMuonTra
            // 
            this.tabQuanLyMuonTra.Controls.Add(this.tabPhieuMuonTra);
            this.tabQuanLyMuonTra.Controls.Add(this.tabChitietphieumuon);
            this.tabQuanLyMuonTra.Location = new System.Drawing.Point(13, 13);
            this.tabQuanLyMuonTra.Name = "tabQuanLyMuonTra";
            this.tabQuanLyMuonTra.SelectedIndex = 0;
            this.tabQuanLyMuonTra.Size = new System.Drawing.Size(723, 424);
            this.tabQuanLyMuonTra.TabIndex = 0;
            // 
            // tabPhieuMuonTra
            // 
            this.tabPhieuMuonTra.Controls.Add(this.pnPhieuMuonTra);
            this.tabPhieuMuonTra.Location = new System.Drawing.Point(4, 22);
            this.tabPhieuMuonTra.Name = "tabPhieuMuonTra";
            this.tabPhieuMuonTra.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhieuMuonTra.Size = new System.Drawing.Size(715, 398);
            this.tabPhieuMuonTra.TabIndex = 0;
            this.tabPhieuMuonTra.Text = "PHIẾU MƯỢN TRẢ";
            this.tabPhieuMuonTra.UseVisualStyleBackColor = true;
            // 
            // tabChitietphieumuon
            // 
            this.tabChitietphieumuon.Controls.Add(this.pnlChitietphieumuon);
            this.tabChitietphieumuon.Location = new System.Drawing.Point(4, 22);
            this.tabChitietphieumuon.Name = "tabChitietphieumuon";
            this.tabChitietphieumuon.Padding = new System.Windows.Forms.Padding(3);
            this.tabChitietphieumuon.Size = new System.Drawing.Size(715, 398);
            this.tabChitietphieumuon.TabIndex = 1;
            this.tabChitietphieumuon.Text = "CHI TIẾT PHIẾU MƯỢN";
            this.tabChitietphieumuon.UseVisualStyleBackColor = true;
            // 
            // pnPhieuMuonTra
            // 
            this.pnPhieuMuonTra.Location = new System.Drawing.Point(7, 28);
            this.pnPhieuMuonTra.Name = "pnPhieuMuonTra";
            this.pnPhieuMuonTra.Size = new System.Drawing.Size(702, 364);
            this.pnPhieuMuonTra.TabIndex = 0;
            // 
            // pnlChitietphieumuon
            // 
            this.pnlChitietphieumuon.Location = new System.Drawing.Point(7, 22);
            this.pnlChitietphieumuon.Name = "pnlChitietphieumuon";
            this.pnlChitietphieumuon.Size = new System.Drawing.Size(702, 370);
            this.pnlChitietphieumuon.TabIndex = 0;
            // 
            // QuanLyMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 449);
            this.Controls.Add(this.tabQuanLyMuonTra);
            this.Name = "QuanLyMuonTra";
            this.Text = "QuanLyMuonTra";
            this.tabQuanLyMuonTra.ResumeLayout(false);
            this.tabPhieuMuonTra.ResumeLayout(false);
            this.tabChitietphieumuon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabQuanLyMuonTra;
        private System.Windows.Forms.TabPage tabPhieuMuonTra;
        private System.Windows.Forms.TabPage tabChitietphieumuon;
        private System.Windows.Forms.Panel pnPhieuMuonTra;
        private System.Windows.Forms.Panel pnlChitietphieumuon;
    }
}