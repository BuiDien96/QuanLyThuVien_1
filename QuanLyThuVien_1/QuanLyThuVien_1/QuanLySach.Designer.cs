namespace QuanLyThuVien_1
{
    partial class QuanLySach
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
            this.tabQuanLySach = new System.Windows.Forms.TabControl();
            this.tabQuanTriSach = new System.Windows.Forms.TabPage();
            this.tabChiTiet = new System.Windows.Forms.TabPage();
            this.pnlChiTiet = new System.Windows.Forms.Panel();
            this.pnlThongTin = new System.Windows.Forms.Panel();
            this.tabQuanLySach.SuspendLayout();
            this.tabQuanTriSach.SuspendLayout();
            this.tabChiTiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabQuanLySach
            // 
            this.tabQuanLySach.Controls.Add(this.tabQuanTriSach);
            this.tabQuanLySach.Controls.Add(this.tabChiTiet);
            this.tabQuanLySach.Location = new System.Drawing.Point(3, 13);
            this.tabQuanLySach.Name = "tabQuanLySach";
            this.tabQuanLySach.SelectedIndex = 0;
            this.tabQuanLySach.Size = new System.Drawing.Size(777, 453);
            this.tabQuanLySach.TabIndex = 0;
            // 
            // tabQuanTriSach
            // 
            this.tabQuanTriSach.Controls.Add(this.pnlThongTin);
            this.tabQuanTriSach.Location = new System.Drawing.Point(4, 22);
            this.tabQuanTriSach.Name = "tabQuanTriSach";
            this.tabQuanTriSach.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuanTriSach.Size = new System.Drawing.Size(769, 427);
            this.tabQuanTriSach.TabIndex = 0;
            this.tabQuanTriSach.Text = "Thông Tin Sách";
            this.tabQuanTriSach.UseVisualStyleBackColor = true;
            // 
            // tabChiTiet
            // 
            this.tabChiTiet.Controls.Add(this.pnlChiTiet);
            this.tabChiTiet.Location = new System.Drawing.Point(4, 22);
            this.tabChiTiet.Name = "tabChiTiet";
            this.tabChiTiet.Padding = new System.Windows.Forms.Padding(3);
            this.tabChiTiet.Size = new System.Drawing.Size(769, 427);
            this.tabChiTiet.TabIndex = 1;
            this.tabChiTiet.Text = "Thông Tin Chi tiết";
            this.tabChiTiet.UseVisualStyleBackColor = true;
            // 
            // pnlChiTiet
            // 
            this.pnlChiTiet.Location = new System.Drawing.Point(4, 29);
            this.pnlChiTiet.Name = "pnlChiTiet";
            this.pnlChiTiet.Size = new System.Drawing.Size(759, 392);
            this.pnlChiTiet.TabIndex = 0;
            // 
            // pnlThongTin
            // 
            this.pnlThongTin.Location = new System.Drawing.Point(6, 29);
            this.pnlThongTin.Name = "pnlThongTin";
            this.pnlThongTin.Size = new System.Drawing.Size(757, 392);
            this.pnlThongTin.TabIndex = 0;
            // 
            // QuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 478);
            this.Controls.Add(this.tabQuanLySach);
            this.Name = "QuanLySach";
            this.Text = "QuanLySach";
            this.tabQuanLySach.ResumeLayout(false);
            this.tabQuanTriSach.ResumeLayout(false);
            this.tabChiTiet.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabQuanLySach;
        private System.Windows.Forms.TabPage tabQuanTriSach;
        private System.Windows.Forms.TabPage tabChiTiet;
        private System.Windows.Forms.Panel pnlThongTin;
        private System.Windows.Forms.Panel pnlChiTiet;
    }
}