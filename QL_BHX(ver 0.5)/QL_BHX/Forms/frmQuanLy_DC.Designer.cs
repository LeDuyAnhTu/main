namespace QL_BHX
{
    partial class frmQuanLy_DC
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThemChiNhanh = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSuaChiNhanh = new System.Windows.Forms.Button();
            this.btnXoaChiNhanh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachChiNhanh = new System.Windows.Forms.DataGridView();
            this.colMaChiNhanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenChiNhanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboDiaChiChiNhanh = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTenChiNhanh = new System.Windows.Forms.TextBox();
            this.txtMaChiNhanh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachChiNhanh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnThemChiNhanh);
            this.groupBox3.Controls.Add(this.btnLamMoi);
            this.groupBox3.Controls.Add(this.btnSuaChiNhanh);
            this.groupBox3.Controls.Add(this.btnXoaChiNhanh);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(221, 439);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(764, 91);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btnThemChiNhanh
            // 
            this.btnThemChiNhanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemChiNhanh.Location = new System.Drawing.Point(180, 37);
            this.btnThemChiNhanh.Name = "btnThemChiNhanh";
            this.btnThemChiNhanh.Size = new System.Drawing.Size(182, 42);
            this.btnThemChiNhanh.TabIndex = 11;
            this.btnThemChiNhanh.Text = "Thêm chi nhánh";
            this.btnThemChiNhanh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemChiNhanh.UseVisualStyleBackColor = true;
            this.btnThemChiNhanh.Click += new System.EventHandler(this.btnThemChiNhanh_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(17, 37);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(146, 42);
            this.btnLamMoi.TabIndex = 10;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSuaChiNhanh
            // 
            this.btnSuaChiNhanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaChiNhanh.Location = new System.Drawing.Point(567, 37);
            this.btnSuaChiNhanh.Name = "btnSuaChiNhanh";
            this.btnSuaChiNhanh.Size = new System.Drawing.Size(174, 42);
            this.btnSuaChiNhanh.TabIndex = 7;
            this.btnSuaChiNhanh.Text = "Sửa chi nhánh";
            this.btnSuaChiNhanh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaChiNhanh.UseVisualStyleBackColor = true;
            this.btnSuaChiNhanh.Click += new System.EventHandler(this.btnSuaChiNhanh_Click);
            // 
            // btnXoaChiNhanh
            // 
            this.btnXoaChiNhanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaChiNhanh.Location = new System.Drawing.Point(381, 37);
            this.btnXoaChiNhanh.Name = "btnXoaChiNhanh";
            this.btnXoaChiNhanh.Size = new System.Drawing.Size(171, 42);
            this.btnXoaChiNhanh.TabIndex = 6;
            this.btnXoaChiNhanh.Text = "Xóa chi nhánh";
            this.btnXoaChiNhanh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaChiNhanh.UseVisualStyleBackColor = true;
            this.btnXoaChiNhanh.Click += new System.EventHandler(this.btnXoaChiNhanh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvDanhSachChiNhanh);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(411, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(753, 368);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách chi nhánh";
            // 
            // dgvDanhSachChiNhanh
            // 
            this.dgvDanhSachChiNhanh.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvDanhSachChiNhanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachChiNhanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaChiNhanh,
            this.colDiaChi,
            this.colTenChiNhanh});
            this.dgvDanhSachChiNhanh.Location = new System.Drawing.Point(6, 26);
            this.dgvDanhSachChiNhanh.Name = "dgvDanhSachChiNhanh";
            this.dgvDanhSachChiNhanh.RowHeadersWidth = 51;
            this.dgvDanhSachChiNhanh.RowTemplate.Height = 24;
            this.dgvDanhSachChiNhanh.Size = new System.Drawing.Size(741, 332);
            this.dgvDanhSachChiNhanh.TabIndex = 0;
            // 
            // colMaChiNhanh
            // 
            this.colMaChiNhanh.HeaderText = "Mã chi nhánh";
            this.colMaChiNhanh.MinimumWidth = 6;
            this.colMaChiNhanh.Name = "colMaChiNhanh";
            this.colMaChiNhanh.Width = 150;
            // 
            // colDiaChi
            // 
            this.colDiaChi.HeaderText = "Địa chỉ";
            this.colDiaChi.MinimumWidth = 6;
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Width = 250;
            // 
            // colTenChiNhanh
            // 
            this.colTenChiNhanh.HeaderText = "Tên chi nhánh";
            this.colTenChiNhanh.MinimumWidth = 6;
            this.colTenChiNhanh.Name = "colTenChiNhanh";
            this.colTenChiNhanh.Width = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cboDiaChiChiNhanh);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtTenChiNhanh);
            this.groupBox1.Controls.Add(this.txtMaChiNhanh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 368);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi nhánh";
            // 
            // cboDiaChiChiNhanh
            // 
            this.cboDiaChiChiNhanh.FormattingEnabled = true;
            this.cboDiaChiChiNhanh.Location = new System.Drawing.Point(149, 107);
            this.cboDiaChiChiNhanh.Name = "cboDiaChiChiNhanh";
            this.cboDiaChiChiNhanh.Size = new System.Drawing.Size(250, 28);
            this.cboDiaChiChiNhanh.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(92, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtTenChiNhanh
            // 
            this.txtTenChiNhanh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenChiNhanh.Location = new System.Drawing.Point(149, 152);
            this.txtTenChiNhanh.Name = "txtTenChiNhanh";
            this.txtTenChiNhanh.Size = new System.Drawing.Size(250, 27);
            this.txtTenChiNhanh.TabIndex = 5;
            this.txtTenChiNhanh.TextChanged += new System.EventHandler(this.txtTenChiNhanh_TextChanged);
            // 
            // txtMaChiNhanh
            // 
            this.txtMaChiNhanh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaChiNhanh.Location = new System.Drawing.Point(149, 57);
            this.txtMaChiNhanh.Name = "txtMaChiNhanh";
            this.txtMaChiNhanh.Size = new System.Drawing.Size(250, 27);
            this.txtMaChiNhanh.TabIndex = 3;
            this.txtMaChiNhanh.TextChanged += new System.EventHandler(this.txtMaChiNhanh_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên chi nhánh: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa chỉ: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã chi nhánh: ";
            // 
            // frmQuanLy_DC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1196, 595);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQuanLy_DC";
            this.Text = "Quản lý chi nhánh";
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachChiNhanh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSuaChiNhanh;
        private System.Windows.Forms.Button btnXoaChiNhanh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDanhSachChiNhanh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboDiaChiChiNhanh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTenChiNhanh;
        private System.Windows.Forms.TextBox txtMaChiNhanh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemChiNhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaChiNhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenChiNhanh;
    }
}