namespace QL_BHX.Forms
{
    partial class frmBanHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dTPNgaySinhKH = new System.Windows.Forms.DateTimePicker();
            this.dTPNgayBan = new System.Windows.Forms.DateTimePicker();
            this.cboMaKH = new System.Windows.Forms.ComboBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnXoaHD = new System.Windows.Forms.Button();
            this.btnLuuHD = new System.Windows.Forms.Button();
            this.btnThemHD = new System.Windows.Forms.Button();
            this.cboKhuyenMai = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboMaSP = new System.Windows.Forms.ComboBox();
            this.txtThanhTienSP = new System.Windows.Forms.TextBox();
            this.txtDonGiaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtSoLuongSP = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cboMaSPTimKiem = new System.Windows.Forms.ComboBox();
            this.btnTimKiemHD = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dTPNgaySinhKH);
            this.groupBox1.Controls.Add(this.dTPNgayBan);
            this.groupBox1.Controls.Add(this.cboMaKH);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1256, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // dTPNgaySinhKH
            // 
            this.dTPNgaySinhKH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPNgaySinhKH.Location = new System.Drawing.Point(857, 199);
            this.dTPNgaySinhKH.Name = "dTPNgaySinhKH";
            this.dTPNgaySinhKH.Size = new System.Drawing.Size(320, 30);
            this.dTPNgaySinhKH.TabIndex = 15;
            // 
            // dTPNgayBan
            // 
            this.dTPNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPNgayBan.Location = new System.Drawing.Point(270, 96);
            this.dTPNgayBan.Name = "dTPNgayBan";
            this.dTPNgayBan.Size = new System.Drawing.Size(320, 30);
            this.dTPNgayBan.TabIndex = 14;
            // 
            // cboMaKH
            // 
            this.cboMaKH.FormattingEnabled = true;
            this.cboMaKH.Location = new System.Drawing.Point(857, 47);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Size = new System.Drawing.Size(320, 33);
            this.cboMaKH.TabIndex = 13;
            // 
            // txtMaNV
            // 
            this.txtMaNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaNV.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(270, 147);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(320, 33);
            this.txtMaNV.TabIndex = 12;
            // 
            // txtSDT
            // 
            this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(857, 147);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(320, 33);
            this.txtSDT.TabIndex = 11;
            // 
            // txtTenKH
            // 
            this.txtTenKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenKH.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(857, 94);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(320, 33);
            this.txtTenKH.TabIndex = 10;
            // 
            // txtTenNV
            // 
            this.txtTenNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenNV.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(270, 197);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(320, 33);
            this.txtTenNV.TabIndex = 9;
            // 
            // txtMaHD
            // 
            this.txtMaHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaHD.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(270, 45);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(320, 33);
            this.txtMaHD.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(652, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 44);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ngày sinh:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(652, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 44);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số điện thoại:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(652, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 44);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên khách hàng:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(652, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 44);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã khách hàng:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 44);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên nhân viên:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã nhân viên:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày bán:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTongTien);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.btnDong);
            this.groupBox2.Controls.Add(this.btnXoaHD);
            this.groupBox2.Controls.Add(this.btnLuuHD);
            this.groupBox2.Controls.Add(this.btnThemHD);
            this.groupBox2.Controls.Add(this.cboKhuyenMai);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.cboMaSP);
            this.groupBox2.Controls.Add(this.txtThanhTienSP);
            this.groupBox2.Controls.Add(this.txtDonGiaSP);
            this.groupBox2.Controls.Add(this.txtTenSP);
            this.groupBox2.Controls.Add(this.txtSoLuongSP);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1256, 448);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sản phẩm";
            // 
            // txtTongTien
            // 
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongTien.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(838, 399);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(320, 32);
            this.txtTongTien.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(665, 391);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(167, 40);
            this.label15.TabIndex = 32;
            this.label15.Text = "Tổng tiền: ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(518, 353);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(138, 41);
            this.btnDong.TabIndex = 31;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // btnXoaHD
            // 
            this.btnXoaHD.Location = new System.Drawing.Point(369, 353);
            this.btnXoaHD.Name = "btnXoaHD";
            this.btnXoaHD.Size = new System.Drawing.Size(138, 41);
            this.btnXoaHD.TabIndex = 30;
            this.btnXoaHD.Text = "Xóa hóa đơn";
            this.btnXoaHD.UseVisualStyleBackColor = true;
            // 
            // btnLuuHD
            // 
            this.btnLuuHD.Location = new System.Drawing.Point(219, 353);
            this.btnLuuHD.Name = "btnLuuHD";
            this.btnLuuHD.Size = new System.Drawing.Size(138, 41);
            this.btnLuuHD.TabIndex = 29;
            this.btnLuuHD.Text = "Lưu hóa đơn";
            this.btnLuuHD.UseVisualStyleBackColor = true;
            // 
            // btnThemHD
            // 
            this.btnThemHD.Location = new System.Drawing.Point(30, 353);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(170, 41);
            this.btnThemHD.TabIndex = 28;
            this.btnThemHD.Text = "Thêm hóa đơn";
            this.btnThemHD.UseVisualStyleBackColor = true;
            // 
            // cboKhuyenMai
            // 
            this.cboKhuyenMai.FormattingEnabled = true;
            this.cboKhuyenMai.Location = new System.Drawing.Point(838, 344);
            this.cboKhuyenMai.Name = "cboKhuyenMai";
            this.cboKhuyenMai.Size = new System.Drawing.Size(320, 33);
            this.cboKhuyenMai.Sorted = true;
            this.cboKhuyenMai.TabIndex = 27;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSanPham,
            this.tenSanPham,
            this.soLuong,
            this.donGia,
            this.khuyenMai,
            this.thanhTien});
            this.dataGridView1.Location = new System.Drawing.Point(25, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1215, 201);
            this.dataGridView1.TabIndex = 26;
            // 
            // maSanPham
            // 
            this.maSanPham.HeaderText = "Mã sản phẩm";
            this.maSanPham.MinimumWidth = 6;
            this.maSanPham.Name = "maSanPham";
            this.maSanPham.Width = 180;
            // 
            // tenSanPham
            // 
            this.tenSanPham.HeaderText = "Tên sản phẩm";
            this.tenSanPham.MinimumWidth = 6;
            this.tenSanPham.Name = "tenSanPham";
            this.tenSanPham.Width = 180;
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
            // khuyenMai
            // 
            this.khuyenMai.HeaderText = "Khuyến mãi";
            this.khuyenMai.MinimumWidth = 6;
            this.khuyenMai.Name = "khuyenMai";
            this.khuyenMai.Width = 125;
            // 
            // thanhTien
            // 
            this.thanhTien.HeaderText = "Thành tiền";
            this.thanhTien.MinimumWidth = 6;
            this.thanhTien.Name = "thanhTien";
            this.thanhTien.Width = 125;
            // 
            // cboMaSP
            // 
            this.cboMaSP.FormattingEnabled = true;
            this.cboMaSP.Location = new System.Drawing.Point(169, 32);
            this.cboMaSP.Name = "cboMaSP";
            this.cboMaSP.Size = new System.Drawing.Size(248, 33);
            this.cboMaSP.Sorted = true;
            this.cboMaSP.TabIndex = 16;
            // 
            // txtThanhTienSP
            // 
            this.txtThanhTienSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThanhTienSP.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTienSP.Location = new System.Drawing.Point(992, 72);
            this.txtThanhTienSP.Name = "txtThanhTienSP";
            this.txtThanhTienSP.Size = new System.Drawing.Size(248, 33);
            this.txtThanhTienSP.TabIndex = 25;
            // 
            // txtDonGiaSP
            // 
            this.txtDonGiaSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDonGiaSP.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGiaSP.Location = new System.Drawing.Point(596, 70);
            this.txtDonGiaSP.Name = "txtDonGiaSP";
            this.txtDonGiaSP.Size = new System.Drawing.Size(248, 33);
            this.txtDonGiaSP.TabIndex = 24;
            // 
            // txtTenSP
            // 
            this.txtTenSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenSP.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.Location = new System.Drawing.Point(596, 32);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(248, 33);
            this.txtTenSP.TabIndex = 22;
            // 
            // txtSoLuongSP
            // 
            this.txtSoLuongSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoLuongSP.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongSP.Location = new System.Drawing.Point(169, 72);
            this.txtSoLuongSP.Name = "txtSoLuongSP";
            this.txtSoLuongSP.Size = new System.Drawing.Size(248, 33);
            this.txtSoLuongSP.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(850, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 40);
            this.label14.TabIndex = 21;
            this.label14.Text = "Thành tiền:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(454, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 40);
            this.label13.TabIndex = 20;
            this.label13.Text = "Đơn giá:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(665, 339);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 40);
            this.label12.TabIndex = 19;
            this.label12.Text = "Khuyến mãi:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(423, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 40);
            this.label11.TabIndex = 18;
            this.label11.Text = "Tên sản phẩm:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 40);
            this.label10.TabIndex = 17;
            this.label10.Text = "Số lượng:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(0, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 40);
            this.label9.TabIndex = 16;
            this.label9.Text = "Mã sản phẩm:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 776);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(167, 40);
            this.label16.TabIndex = 33;
            this.label16.Text = "Mã hóa đơn:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboMaSPTimKiem
            // 
            this.cboMaSPTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaSPTimKiem.FormattingEnabled = true;
            this.cboMaSPTimKiem.Location = new System.Drawing.Point(175, 778);
            this.cboMaSPTimKiem.Name = "cboMaSPTimKiem";
            this.cboMaSPTimKiem.Size = new System.Drawing.Size(255, 37);
            this.cboMaSPTimKiem.Sorted = true;
            this.cboMaSPTimKiem.TabIndex = 33;
            // 
            // btnTimKiemHD
            // 
            this.btnTimKiemHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemHD.Location = new System.Drawing.Point(441, 778);
            this.btnTimKiemHD.Name = "btnTimKiemHD";
            this.btnTimKiemHD.Size = new System.Drawing.Size(138, 38);
            this.btnTimKiemHD.TabIndex = 33;
            this.btnTimKiemHD.Text = "Tìm kiếm";
            this.btnTimKiemHD.UseVisualStyleBackColor = true;
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1281, 825);
            this.Controls.Add(this.btnTimKiemHD);
            this.Controls.Add(this.cboMaSPTimKiem);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán hàng";
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dTPNgaySinhKH;
        private System.Windows.Forms.DateTimePicker dTPNgayBan;
        private System.Windows.Forms.ComboBox cboMaKH;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtSoLuongSP;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboMaSP;
        private System.Windows.Forms.TextBox txtThanhTienSP;
        private System.Windows.Forms.TextBox txtDonGiaSP;
        private System.Windows.Forms.ComboBox cboKhuyenMai;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnXoaHD;
        private System.Windows.Forms.Button btnLuuHD;
        private System.Windows.Forms.Button btnThemHD;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboMaSPTimKiem;
        private System.Windows.Forms.Button btnTimKiemHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn khuyenMai;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTien;
    }
}