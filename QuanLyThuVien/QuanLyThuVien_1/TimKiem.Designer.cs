namespace QuanLyThuVien_1
{
    partial class TimKiem
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
            this.tabTimKiem = new System.Windows.Forms.TabControl();
            this.tabTKDocgia = new System.Windows.Forms.TabPage();
            this.tabTKSach = new System.Windows.Forms.TabPage();
            this.pnlDocgia = new System.Windows.Forms.Panel();
            this.pnlSach = new System.Windows.Forms.Panel();
            this.tabTimKiem.SuspendLayout();
            this.tabTKDocgia.SuspendLayout();
            this.tabTKSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabTimKiem
            // 
            this.tabTimKiem.Controls.Add(this.tabTKDocgia);
            this.tabTimKiem.Controls.Add(this.tabTKSach);
            this.tabTimKiem.Location = new System.Drawing.Point(4, 13);
            this.tabTimKiem.Name = "tabTimKiem";
            this.tabTimKiem.SelectedIndex = 0;
            this.tabTimKiem.Size = new System.Drawing.Size(709, 400);
            this.tabTimKiem.TabIndex = 0;
            // 
            // tabTKDocgia
            // 
            this.tabTKDocgia.Controls.Add(this.pnlDocgia);
            this.tabTKDocgia.Location = new System.Drawing.Point(4, 22);
            this.tabTKDocgia.Name = "tabTKDocgia";
            this.tabTKDocgia.Padding = new System.Windows.Forms.Padding(3);
            this.tabTKDocgia.Size = new System.Drawing.Size(701, 374);
            this.tabTKDocgia.TabIndex = 0;
            this.tabTKDocgia.Text = "ĐỘC GIẢ";
            this.tabTKDocgia.UseVisualStyleBackColor = true;
            // 
            // tabTKSach
            // 
            this.tabTKSach.Controls.Add(this.pnlSach);
            this.tabTKSach.Location = new System.Drawing.Point(4, 22);
            this.tabTKSach.Name = "tabTKSach";
            this.tabTKSach.Padding = new System.Windows.Forms.Padding(3);
            this.tabTKSach.Size = new System.Drawing.Size(701, 374);
            this.tabTKSach.TabIndex = 1;
            this.tabTKSach.Text = "SÁCH";
            this.tabTKSach.UseVisualStyleBackColor = true;
            // 
            // pnlDocgia
            // 
            this.pnlDocgia.Location = new System.Drawing.Point(7, 22);
            this.pnlDocgia.Name = "pnlDocgia";
            this.pnlDocgia.Size = new System.Drawing.Size(688, 346);
            this.pnlDocgia.TabIndex = 0;
            // 
            // pnlSach
            // 
            this.pnlSach.Location = new System.Drawing.Point(7, 25);
            this.pnlSach.Name = "pnlSach";
            this.pnlSach.Size = new System.Drawing.Size(688, 343);
            this.pnlSach.TabIndex = 0;
            // 
            // TimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 425);
            this.Controls.Add(this.tabTimKiem);
            this.Name = "TimKiem";
            this.Text = "TimKiem";
            this.tabTimKiem.ResumeLayout(false);
            this.tabTKDocgia.ResumeLayout(false);
            this.tabTKSach.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabTimKiem;
        private System.Windows.Forms.TabPage tabTKDocgia;
        private System.Windows.Forms.TabPage tabTKSach;
        private System.Windows.Forms.Panel pnlDocgia;
        private System.Windows.Forms.Panel pnlSach;
    }
}