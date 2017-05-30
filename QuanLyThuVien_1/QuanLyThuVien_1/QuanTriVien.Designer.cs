namespace QuanLyThuVien_1
{
    partial class QuanTriVien
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
            this.tabQuanTriVien = new System.Windows.Forms.TabControl();
            this.tabQuanTriThuThu = new System.Windows.Forms.TabPage();
            this.tabChitietthuthu = new System.Windows.Forms.TabPage();
            this.pnlQuantrithuthu = new System.Windows.Forms.Panel();
            this.pnlChitetthuthu = new System.Windows.Forms.Panel();
            this.tabQuanTriVien.SuspendLayout();
            this.tabQuanTriThuThu.SuspendLayout();
            this.tabChitietthuthu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabQuanTriVien
            // 
            this.tabQuanTriVien.Controls.Add(this.tabQuanTriThuThu);
            this.tabQuanTriVien.Controls.Add(this.tabChitietthuthu);
            this.tabQuanTriVien.Location = new System.Drawing.Point(13, 13);
            this.tabQuanTriVien.Name = "tabQuanTriVien";
            this.tabQuanTriVien.SelectedIndex = 0;
            this.tabQuanTriVien.Size = new System.Drawing.Size(820, 536);
            this.tabQuanTriVien.TabIndex = 0;
            // 
            // tabQuanTriThuThu
            // 
            this.tabQuanTriThuThu.Controls.Add(this.pnlQuantrithuthu);
            this.tabQuanTriThuThu.Location = new System.Drawing.Point(4, 22);
            this.tabQuanTriThuThu.Name = "tabQuanTriThuThu";
            this.tabQuanTriThuThu.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuanTriThuThu.Size = new System.Drawing.Size(812, 510);
            this.tabQuanTriThuThu.TabIndex = 0;
            this.tabQuanTriThuThu.Text = "THỦ THƯ";
            this.tabQuanTriThuThu.UseVisualStyleBackColor = true;
            // 
            // tabChitietthuthu
            // 
            this.tabChitietthuthu.Controls.Add(this.pnlChitetthuthu);
            this.tabChitietthuthu.Location = new System.Drawing.Point(4, 22);
            this.tabChitietthuthu.Name = "tabChitietthuthu";
            this.tabChitietthuthu.Padding = new System.Windows.Forms.Padding(3);
            this.tabChitietthuthu.Size = new System.Drawing.Size(812, 444);
            this.tabChitietthuthu.TabIndex = 1;
            this.tabChitietthuthu.Text = "CHI TIẾT THỬ THƯ";
            this.tabChitietthuthu.UseVisualStyleBackColor = true;
            // 
            // pnlQuantrithuthu
            // 
            this.pnlQuantrithuthu.Location = new System.Drawing.Point(7, 33);
            this.pnlQuantrithuthu.Name = "pnlQuantrithuthu";
            this.pnlQuantrithuthu.Size = new System.Drawing.Size(799, 471);
            this.pnlQuantrithuthu.TabIndex = 0;
            // 
            // pnlChitetthuthu
            // 
            this.pnlChitetthuthu.Location = new System.Drawing.Point(7, 23);
            this.pnlChitetthuthu.Name = "pnlChitetthuthu";
            this.pnlChitetthuthu.Size = new System.Drawing.Size(799, 412);
            this.pnlChitetthuthu.TabIndex = 0;
            // 
            // QuanTriVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 545);
            this.Controls.Add(this.tabQuanTriVien);
            this.Name = "QuanTriVien";
            this.Text = "QuanTriVien";
            this.tabQuanTriVien.ResumeLayout(false);
            this.tabQuanTriThuThu.ResumeLayout(false);
            this.tabChitietthuthu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabQuanTriVien;
        private System.Windows.Forms.TabPage tabQuanTriThuThu;
        private System.Windows.Forms.TabPage tabChitietthuthu;
        private System.Windows.Forms.Panel pnlQuantrithuthu;
        private System.Windows.Forms.Panel pnlChitetthuthu;
    }
}