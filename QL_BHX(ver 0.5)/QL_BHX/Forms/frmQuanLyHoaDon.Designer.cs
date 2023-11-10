namespace QL_BHX
{
    partial class frmQuanLyHoaDon
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachHoaDon = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvCTHoaDon = new System.Windows.Forms.DataGridView();
            this.maSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoiLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnXoaHoaDon = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dTPTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dTPDenNgay = new System.Windows.Forms.DateTimePicker();
            this.btnTimTheoKhoangNgay = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThem_SP = new System.Windows.Forms.Button();
            this.btnXoa_SP = new System.Windows.Forms.Button();
            this.btnSua_SP = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHoaDon)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHoaDon)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvDanhSachHoaDon);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(26, 208);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(714, 459);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh Sách Hóa Đơn";
            // 
            // dgvDanhSachHoaDon
            // 
            this.dgvDanhSachHoaDon.AllowUserToOrderColumns = true;
            this.dgvDanhSachHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.maHD,
            this.ngayLap,
            this.nhanVien,
            this.thanhTien});
            this.dgvDanhSachHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachHoaDon.Location = new System.Drawing.Point(3, 24);
            this.dgvDanhSachHoaDon.Name = "dgvDanhSachHoaDon";
            this.dgvDanhSachHoaDon.RowHeadersWidth = 51;
            this.dgvDanhSachHoaDon.RowTemplate.Height = 24;
            this.dgvDanhSachHoaDon.Size = new System.Drawing.Size(708, 432);
            this.dgvDanhSachHoaDon.TabIndex = 2;
            this.dgvDanhSachHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachHoaDon_CellContentClick);
            this.dgvDanhSachHoaDon.SelectionChanged += new System.EventHandler(this.dgvDanhSachHoaDon_SelectionChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvCTHoaDon);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(746, 208);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(516, 402);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chi Tiết Hóa Đơn";
            // 
            // dgvCTHoaDon
            // 
            this.dgvCTHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSanPham,
            this.tenSanPham,
            this.soLuong,
            this.donGia,
            this.khoiLuong,
            this.loaiSP,
            this.giamGia});
            this.dgvCTHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTHoaDon.Location = new System.Drawing.Point(3, 24);
            this.dgvCTHoaDon.Name = "dgvCTHoaDon";
            this.dgvCTHoaDon.RowHeadersWidth = 51;
            this.dgvCTHoaDon.RowTemplate.Height = 24;
            this.dgvCTHoaDon.Size = new System.Drawing.Size(510, 375);
            this.dgvCTHoaDon.TabIndex = 0;
            this.dgvCTHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTHoaDon_CellContentClick);
            // 
            // maSanPham
            // 
            this.maSanPham.HeaderText = "Mã sản phẩm";
            this.maSanPham.MinimumWidth = 6;
            this.maSanPham.Name = "maSanPham";
            this.maSanPham.Width = 125;
            // 
            // tenSanPham
            // 
            this.tenSanPham.HeaderText = "Tên sản phẩm";
            this.tenSanPham.MinimumWidth = 6;
            this.tenSanPham.Name = "tenSanPham";
            this.tenSanPham.Width = 125;
            // 
            // soLuong
            // 
            this.soLuong.HeaderText = "Số lượng";
            this.soLuong.MinimumWidth = 6;
            this.soLuong.Name = "soLuong";
            this.soLuong.Width = 125;
            // 
            // donGia
            // 
            this.donGia.HeaderText = "Đơn giá";
            this.donGia.MinimumWidth = 6;
            this.donGia.Name = "donGia";
            this.donGia.Width = 125;
            // 
            // khoiLuong
            // 
            this.khoiLuong.HeaderText = "Khối lượng";
            this.khoiLuong.MinimumWidth = 6;
            this.khoiLuong.Name = "khoiLuong";
            this.khoiLuong.Width = 125;
            // 
            // loaiSP
            // 
            this.loaiSP.HeaderText = "Loại sản phẩm";
            this.loaiSP.MinimumWidth = 6;
            this.loaiSP.Name = "loaiSP";
            this.loaiSP.Width = 125;
            // 
            // giamGia
            // 
            this.giamGia.HeaderText = "Giảm giá (%)";
            this.giamGia.MinimumWidth = 6;
            this.giamGia.Name = "giamGia";
            this.giamGia.Width = 125;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(795, 616);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(180, 51);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "In hóa đơn";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnXoaHoaDon
            // 
            this.btnXoaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHoaDon.Location = new System.Drawing.Point(1019, 616);
            this.btnXoaHoaDon.Name = "btnXoaHoaDon";
            this.btnXoaHoaDon.Size = new System.Drawing.Size(171, 51);
            this.btnXoaHoaDon.TabIndex = 12;
            this.btnXoaHoaDon.Text = "Xóa hóa đơn";
            this.btnXoaHoaDon.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Từ: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "đến: ";
            // 
            // dTPTuNgay
            // 
            this.dTPTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPTuNgay.Location = new System.Drawing.Point(50, 45);
            this.dTPTuNgay.Name = "dTPTuNgay";
            this.dTPTuNgay.Size = new System.Drawing.Size(129, 27);
            this.dTPTuNgay.TabIndex = 14;
            // 
            // dTPDenNgay
            // 
            this.dTPDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPDenNgay.Location = new System.Drawing.Point(226, 45);
            this.dTPDenNgay.Name = "dTPDenNgay";
            this.dTPDenNgay.Size = new System.Drawing.Size(139, 27);
            this.dTPDenNgay.TabIndex = 15;
            // 
            // btnTimTheoKhoangNgay
            // 
            this.btnTimTheoKhoangNgay.Location = new System.Drawing.Point(119, 98);
            this.btnTimTheoKhoangNgay.Name = "btnTimTheoKhoangNgay";
            this.btnTimTheoKhoangNgay.Size = new System.Drawing.Size(136, 51);
            this.btnTimTheoKhoangNgay.TabIndex = 16;
            this.btnTimTheoKhoangNgay.Text = "Tìm";
            this.btnTimTheoKhoangNgay.UseVisualStyleBackColor = true;
            this.btnTimTheoKhoangNgay.Click += new System.EventHandler(this.btnTimTheoKhoangNgay_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTimTheoKhoangNgay);
            this.groupBox3.Controls.Add(this.dTPDenNgay);
            this.groupBox3.Controls.Add(this.dTPTuNgay);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(26, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(382, 175);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tra Cứu Theo Khoảng Ngày";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnThem_SP);
            this.groupBox2.Controls.Add(this.btnXoa_SP);
            this.groupBox2.Controls.Add(this.btnSua_SP);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(417, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(845, 175);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Số lượng:";
            // 
            // btnThem_SP
            // 
            this.btnThem_SP.Location = new System.Drawing.Point(68, 131);
            this.btnThem_SP.Name = "btnThem_SP";
            this.btnThem_SP.Size = new System.Drawing.Size(136, 27);
            this.btnThem_SP.TabIndex = 19;
            this.btnThem_SP.Text = "Thêm";
            this.btnThem_SP.UseVisualStyleBackColor = true;
            // 
            // btnXoa_SP
            // 
            this.btnXoa_SP.Location = new System.Drawing.Point(640, 126);
            this.btnXoa_SP.Name = "btnXoa_SP";
            this.btnXoa_SP.Size = new System.Drawing.Size(136, 32);
            this.btnXoa_SP.TabIndex = 18;
            this.btnXoa_SP.Text = "Xóa";
            this.btnXoa_SP.UseVisualStyleBackColor = true;
            // 
            // btnSua_SP
            // 
            this.btnSua_SP.Location = new System.Drawing.Point(355, 131);
            this.btnSua_SP.Name = "btnSua_SP";
            this.btnSua_SP.Size = new System.Drawing.Size(136, 27);
            this.btnSua_SP.TabIndex = 17;
            this.btnSua_SP.Text = "Sửa";
            this.btnSua_SP.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(535, 80);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(195, 27);
            this.textBox4.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(535, 23);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(195, 27);
            this.textBox3.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(427, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Thành tiền:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(134, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 27);
            this.textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 27);
            this.textBox1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Đơn giá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã sản phẩm:";
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 125;
            // 
            // maHD
            // 
            this.maHD.HeaderText = "Mã hóa đơn";
            this.maHD.MinimumWidth = 6;
            this.maHD.Name = "maHD";
            this.maHD.Width = 125;
            // 
            // ngayLap
            // 
            this.ngayLap.HeaderText = "Ngày lập";
            this.ngayLap.MinimumWidth = 6;
            this.ngayLap.Name = "ngayLap";
            this.ngayLap.Width = 125;
            // 
            // nhanVien
            // 
            this.nhanVien.HeaderText = "Nhân viên";
            this.nhanVien.MinimumWidth = 6;
            this.nhanVien.Name = "nhanVien";
            this.nhanVien.Width = 125;
            // 
            // thanhTien
            // 
            this.thanhTien.HeaderText = "Thành tiền";
            this.thanhTien.MinimumWidth = 6;
            this.thanhTien.Name = "thanhTien";
            this.thanhTien.Width = 125;
            // 
            // frmQuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1274, 686);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnXoaHoaDon);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmQuanLyHoaDon";
            this.Text = "Quản lý hóa đơn";
            this.Load += new System.EventHandler(this.frmQuanLyHoaDon_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHoaDon)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHoaDon)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnXoaHoaDon;
        private System.Windows.Forms.DataGridView dgvCTHoaDon;
        private System.Windows.Forms.DataGridView dgvDanhSachHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoiLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn giamGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dTPTuNgay;
        private System.Windows.Forms.DateTimePicker dTPDenNgay;
        private System.Windows.Forms.Button btnTimTheoKhoangNgay;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThem_SP;
        private System.Windows.Forms.Button btnXoa_SP;
        private System.Windows.Forms.Button btnSua_SP;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTien;
    }
}