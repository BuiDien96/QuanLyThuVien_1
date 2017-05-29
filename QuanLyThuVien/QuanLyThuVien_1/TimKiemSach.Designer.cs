namespace QuanLyThuVien_1
{
    partial class TimKiemSach
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
            this.gbxTimkiemsach = new System.Windows.Forms.GroupBox();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.lblTimkiem = new System.Windows.Forms.Label();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.dgvSearchSach = new System.Windows.Forms.DataGridView();
            this.gbxTimkiemsach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchSach)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxTimkiemsach
            // 
            this.gbxTimkiemsach.Controls.Add(this.txtTimkiem);
            this.gbxTimkiemsach.Controls.Add(this.lblTimkiem);
            this.gbxTimkiemsach.Controls.Add(this.btnTimkiem);
            this.gbxTimkiemsach.Location = new System.Drawing.Point(2, 12);
            this.gbxTimkiemsach.Name = "gbxTimkiemsach";
            this.gbxTimkiemsach.Size = new System.Drawing.Size(672, 71);
            this.gbxTimkiemsach.TabIndex = 9;
            this.gbxTimkiemsach.TabStop = false;
            this.gbxTimkiemsach.Text = "Tìm kiếm thông tin";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(135, 29);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(279, 20);
            this.txtTimkiem.TabIndex = 14;
            this.txtTimkiem.Text = "Nhập thông tin cần tìm kiếm";
            this.txtTimkiem.Click += new System.EventHandler(this.txtTimkiem_Click);
            // 
            // lblTimkiem
            // 
            this.lblTimkiem.AutoSize = true;
            this.lblTimkiem.Location = new System.Drawing.Point(9, 29);
            this.lblTimkiem.Name = "lblTimkiem";
            this.lblTimkiem.Size = new System.Drawing.Size(93, 13);
            this.lblTimkiem.TabIndex = 13;
            this.lblTimkiem.Text = "Tìm kiếm tên sách";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Image = global::QuanLyThuVien_1.Properties.Resources.Search_icon11;
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.Location = new System.Drawing.Point(508, 29);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiem.TabIndex = 5;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // dgvSearchSach
            // 
            this.dgvSearchSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearchSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchSach.Location = new System.Drawing.Point(14, 108);
            this.dgvSearchSach.Name = "dgvSearchSach";
            this.dgvSearchSach.Size = new System.Drawing.Size(658, 150);
            this.dgvSearchSach.TabIndex = 10;
            // 
            // TimKiemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 261);
            this.Controls.Add(this.dgvSearchSach);
            this.Controls.Add(this.gbxTimkiemsach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimKiemSach";
            this.Text = "TimKiemSach";
            this.gbxTimkiemsach.ResumeLayout(false);
            this.gbxTimkiemsach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxTimkiemsach;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Label lblTimkiem;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.DataGridView dgvSearchSach;
    }
}