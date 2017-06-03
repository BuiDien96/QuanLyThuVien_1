namespace QuanLyThuVien_1
{
    partial class DocGia
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
            this.btnHome = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.gbxDocGia = new System.Windows.Forms.GroupBox();
            this.dateNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtTendg = new System.Windows.Forms.TextBox();
            this.txtMadg = new System.Windows.Forms.TextBox();
            this.lblNgaysinh = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblTendg = new System.Windows.Forms.Label();
            this.lblMadg = new System.Windows.Forms.Label();
            this.lblgioitinh = new System.Windows.Forms.Label();
            this.txtGioitinh = new System.Windows.Forms.TextBox();
            this.dgvDocgia = new System.Windows.Forms.DataGridView();
            this.gbxDocGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocgia)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Image = global::QuanLyThuVien_1.Properties.Resources.home_icon1;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 31);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QuanLyThuVien_1.Properties.Resources.Add_icon;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(134, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 31);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QuanLyThuVien_1.Properties.Resources.edit_icon;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(281, 12);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 31);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLyThuVien_1.Properties.Resources.Delete_icon;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(409, 12);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 31);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::QuanLyThuVien_1.Properties.Resources.Save_icon;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(555, 12);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 31);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // gbxDocGia
            // 
            this.gbxDocGia.Controls.Add(this.txtGioitinh);
            this.gbxDocGia.Controls.Add(this.lblgioitinh);
            this.gbxDocGia.Controls.Add(this.dateNgaysinh);
            this.gbxDocGia.Controls.Add(this.txtDiachi);
            this.gbxDocGia.Controls.Add(this.txtTendg);
            this.gbxDocGia.Controls.Add(this.txtMadg);
            this.gbxDocGia.Controls.Add(this.lblNgaysinh);
            this.gbxDocGia.Controls.Add(this.lblDiachi);
            this.gbxDocGia.Controls.Add(this.lblTendg);
            this.gbxDocGia.Controls.Add(this.lblMadg);
            this.gbxDocGia.Location = new System.Drawing.Point(12, 79);
            this.gbxDocGia.Name = "gbxDocGia";
            this.gbxDocGia.Size = new System.Drawing.Size(670, 127);
            this.gbxDocGia.TabIndex = 7;
            this.gbxDocGia.TabStop = false;
            this.gbxDocGia.Text = "Thông tin độc giả";
            // 
            // dateNgaysinh
            // 
            this.dateNgaysinh.Location = new System.Drawing.Point(444, 24);
            this.dateNgaysinh.Name = "dateNgaysinh";
            this.dateNgaysinh.Size = new System.Drawing.Size(149, 20);
            this.dateNgaysinh.TabIndex = 8;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(444, 60);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(149, 20);
            this.txtDiachi.TabIndex = 7;
            // 
            // txtTendg
            // 
            this.txtTendg.Location = new System.Drawing.Point(99, 60);
            this.txtTendg.Name = "txtTendg";
            this.txtTendg.Size = new System.Drawing.Size(133, 20);
            this.txtTendg.TabIndex = 6;
            // 
            // txtMadg
            // 
            this.txtMadg.Location = new System.Drawing.Point(99, 27);
            this.txtMadg.Name = "txtMadg";
            this.txtMadg.Size = new System.Drawing.Size(133, 20);
            this.txtMadg.TabIndex = 4;
            // 
            // lblNgaysinh
            // 
            this.lblNgaysinh.AutoSize = true;
            this.lblNgaysinh.Location = new System.Drawing.Point(339, 27);
            this.lblNgaysinh.Name = "lblNgaysinh";
            this.lblNgaysinh.Size = new System.Drawing.Size(54, 13);
            this.lblNgaysinh.TabIndex = 3;
            this.lblNgaysinh.Text = "Ngày sinh";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Location = new System.Drawing.Point(339, 67);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(40, 13);
            this.lblDiachi.TabIndex = 2;
            this.lblDiachi.Text = "Địa chỉ";
            // 
            // lblTendg
            // 
            this.lblTendg.AutoSize = true;
            this.lblTendg.Location = new System.Drawing.Point(16, 60);
            this.lblTendg.Name = "lblTendg";
            this.lblTendg.Size = new System.Drawing.Size(65, 13);
            this.lblTendg.TabIndex = 1;
            this.lblTendg.Text = "Tên độc giả";
            // 
            // lblMadg
            // 
            this.lblMadg.AutoSize = true;
            this.lblMadg.Location = new System.Drawing.Point(16, 30);
            this.lblMadg.Name = "lblMadg";
            this.lblMadg.Size = new System.Drawing.Size(61, 13);
            this.lblMadg.TabIndex = 0;
            this.lblMadg.Text = "Mã độc giả";
            // 
            // lblgioitinh
            // 
            this.lblgioitinh.AutoSize = true;
            this.lblgioitinh.Location = new System.Drawing.Point(16, 92);
            this.lblgioitinh.Name = "lblgioitinh";
            this.lblgioitinh.Size = new System.Drawing.Size(47, 13);
            this.lblgioitinh.TabIndex = 9;
            this.lblgioitinh.Text = "Giới tính";
            // 
            // txtGioitinh
            // 
            this.txtGioitinh.Location = new System.Drawing.Point(99, 89);
            this.txtGioitinh.Name = "txtGioitinh";
            this.txtGioitinh.Size = new System.Drawing.Size(133, 20);
            this.txtGioitinh.TabIndex = 10;
            // 
            // dgvDocgia
            // 
            this.dgvDocgia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDocgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocgia.Location = new System.Drawing.Point(12, 238);
            this.dgvDocgia.Name = "dgvDocgia";
            this.dgvDocgia.Size = new System.Drawing.Size(670, 112);
            this.dgvDocgia.TabIndex = 9;
            this.dgvDocgia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocgia_CellClick);
            // 
            // DocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 427);
            this.Controls.Add(this.dgvDocgia);
            this.Controls.Add(this.gbxDocGia);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DocGia";
            this.Text = "DocGia";
            this.Load += new System.EventHandler(this.DocGia_Load);
            this.gbxDocGia.ResumeLayout(false);
            this.gbxDocGia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocgia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.GroupBox gbxDocGia;
        private System.Windows.Forms.TextBox txtGioitinh;
        private System.Windows.Forms.Label lblgioitinh;
        private System.Windows.Forms.DateTimePicker dateNgaysinh;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtTendg;
        private System.Windows.Forms.TextBox txtMadg;
        private System.Windows.Forms.Label lblNgaysinh;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblTendg;
        private System.Windows.Forms.Label lblMadg;
        private System.Windows.Forms.DataGridView dgvDocgia;
    }
}