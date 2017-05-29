namespace QuanLyThuVien_1
{
    partial class TimKiemDocGia
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
            this.gbxTimKiemDG = new System.Windows.Forms.GroupBox();
            this.txtTKMadg = new System.Windows.Forms.TextBox();
            this.lblTimkiem = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTKtendg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTKTenDocgia = new System.Windows.Forms.DataGridView();
            this.btnSearchTenDG = new System.Windows.Forms.Button();
            this.btnSearchMaDG = new System.Windows.Forms.Button();
            this.dgvTKMaDocgia = new System.Windows.Forms.DataGridView();
            this.gbxTimKiemDG.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKTenDocgia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKMaDocgia)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxTimKiemDG
            // 
            this.gbxTimKiemDG.Controls.Add(this.txtTKMadg);
            this.gbxTimKiemDG.Controls.Add(this.lblTimkiem);
            this.gbxTimKiemDG.Controls.Add(this.btnSearchMaDG);
            this.gbxTimKiemDG.Location = new System.Drawing.Point(12, 12);
            this.gbxTimKiemDG.Name = "gbxTimKiemDG";
            this.gbxTimKiemDG.Size = new System.Drawing.Size(658, 57);
            this.gbxTimKiemDG.TabIndex = 8;
            this.gbxTimKiemDG.TabStop = false;
            this.gbxTimKiemDG.Text = "Tìm kiếm thông tin";
            // 
            // txtTKMadg
            // 
            this.txtTKMadg.Location = new System.Drawing.Point(154, 19);
            this.txtTKMadg.Name = "txtTKMadg";
            this.txtTKMadg.Size = new System.Drawing.Size(176, 20);
            this.txtTKMadg.TabIndex = 8;
            this.txtTKMadg.Text = "Nhập thông tin cần tìm kiếm";
            this.txtTKMadg.Click += new System.EventHandler(this.txtTKMadg_Click);
            this.txtTKMadg.TextChanged += new System.EventHandler(this.txtTKMadg_TextChanged);
            // 
            // lblTimkiem
            // 
            this.lblTimkiem.AutoSize = true;
            this.lblTimkiem.Location = new System.Drawing.Point(21, 25);
            this.lblTimkiem.Name = "lblTimkiem";
            this.lblTimkiem.Size = new System.Drawing.Size(105, 13);
            this.lblTimkiem.TabIndex = 4;
            this.lblTimkiem.Text = "Tìm kiếm mã độc giả";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTKtendg);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSearchTenDG);
            this.groupBox1.Location = new System.Drawing.Point(5, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 62);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm thông tin";
            // 
            // txtTKtendg
            // 
            this.txtTKtendg.Location = new System.Drawing.Point(139, 23);
            this.txtTKtendg.Name = "txtTKtendg";
            this.txtTKtendg.Size = new System.Drawing.Size(176, 20);
            this.txtTKtendg.TabIndex = 8;
            this.txtTKtendg.Text = "Nhập thông tin cần tìm kiếm";
            this.txtTKtendg.Click += new System.EventHandler(this.txtTKtendg_Click);
            this.txtTKtendg.TextChanged += new System.EventHandler(this.txtTKtendg_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tìm kiếm tên độc giả";
            // 
            // dgvTKTenDocgia
            // 
            this.dgvTKTenDocgia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTKTenDocgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKTenDocgia.Location = new System.Drawing.Point(5, 282);
            this.dgvTKTenDocgia.Name = "dgvTKTenDocgia";
            this.dgvTKTenDocgia.Size = new System.Drawing.Size(665, 95);
            this.dgvTKTenDocgia.TabIndex = 10;
            // 
            // btnSearchTenDG
            // 
            this.btnSearchTenDG.Image = global::QuanLyThuVien_1.Properties.Resources.Search_icon11;
            this.btnSearchTenDG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchTenDG.Location = new System.Drawing.Point(514, 21);
            this.btnSearchTenDG.Name = "btnSearchTenDG";
            this.btnSearchTenDG.Size = new System.Drawing.Size(75, 23);
            this.btnSearchTenDG.TabIndex = 5;
            this.btnSearchTenDG.Text = "Tìm kiếm";
            this.btnSearchTenDG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchTenDG.UseVisualStyleBackColor = true;
            this.btnSearchTenDG.Click += new System.EventHandler(this.btnSearchTenDG_Click);
            // 
            // btnSearchMaDG
            // 
            this.btnSearchMaDG.Image = global::QuanLyThuVien_1.Properties.Resources.Search_icon11;
            this.btnSearchMaDG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchMaDG.Location = new System.Drawing.Point(507, 17);
            this.btnSearchMaDG.Name = "btnSearchMaDG";
            this.btnSearchMaDG.Size = new System.Drawing.Size(75, 23);
            this.btnSearchMaDG.TabIndex = 5;
            this.btnSearchMaDG.Text = "Tìm kiếm";
            this.btnSearchMaDG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchMaDG.UseVisualStyleBackColor = true;
            this.btnSearchMaDG.Click += new System.EventHandler(this.btnSearchMaDG_Click);
            // 
            // dgvTKMaDocgia
            // 
            this.dgvTKMaDocgia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTKMaDocgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKMaDocgia.Location = new System.Drawing.Point(5, 75);
            this.dgvTKMaDocgia.Name = "dgvTKMaDocgia";
            this.dgvTKMaDocgia.Size = new System.Drawing.Size(658, 104);
            this.dgvTKMaDocgia.TabIndex = 11;
            // 
            // TimKiemDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 412);
            this.Controls.Add(this.dgvTKMaDocgia);
            this.Controls.Add(this.dgvTKTenDocgia);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxTimKiemDG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimKiemDocGia";
            this.Text = "TimKiemDocGia";
            this.Load += new System.EventHandler(this.TimKiemDocGia_Load);
            this.gbxTimKiemDG.ResumeLayout(false);
            this.gbxTimKiemDG.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKTenDocgia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKMaDocgia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxTimKiemDG;
        private System.Windows.Forms.TextBox txtTKMadg;
        private System.Windows.Forms.Label lblTimkiem;
        private System.Windows.Forms.Button btnSearchMaDG;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTKtendg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchTenDG;
        private System.Windows.Forms.DataGridView dgvTKTenDocgia;
        private System.Windows.Forms.DataGridView dgvTKMaDocgia;
    }
}