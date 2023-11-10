using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QL_BHX.Forms
{
    public partial class frmProduct : Form
    {
        string filePath_Product = "Product.txt";

        //Data chứa danh sách dữ liệu
        private LinkedList<Product> data_Product = new LinkedList<Product>();

        //Số thứ tự 
        private int soThuTu = 1;


        public frmProduct()
        {
            InitializeComponent();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {

            // Kiểm tra ràng buộc cho TextBox và ComboBox
            if (string.IsNullOrWhiteSpace(txtMaSP.Text) || string.IsNullOrWhiteSpace(txtTenSP.Text) 
                || string.IsNullOrWhiteSpace(txtGia.Text) || string.IsNullOrWhiteSpace(txtSoLuong.Text)
                || string.IsNullOrWhiteSpace(txtKhoiLuong.Text) || cboLoaiSP.SelectedItem == null)
            {
                Ultilities.popUpError("Vui lòng điền đầy đủ thông tin vào các trường!");
                return; // Dừng việc thêm khi dữ liệu không hợp lệ
            }



            string ma = txtMaSP.Text;
            string ten = txtTenSP.Text;
            DateTime ngaySanXuat = dTPNSX.Value;
            decimal donGia = Convert.ToDecimal( txtGia.Text);
            int soLuong = Convert.ToInt32(txtSoLuong.Text);
            float khoiLuong = (float)Convert.ToDouble(txtKhoiLuong.Text);
            string loai = cboLoaiSP.SelectedIndex.ToString();

            data_Product.AddLast(new Product(ma, ten, ngaySanXuat, donGia, soLuong, khoiLuong, loai));
            showList();
            // Xóa dữ liệu khỏi các TextBox sau khi thêm
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtGia.Clear();
            txtSoLuong.Clear();
            txtKhoiLuong.Clear();
            txtMaSP.Focus();    

        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            //focus mã sản phẩm
            txtMaSP.Focus();
            ThemLoaiSanPhamVaoComboBox();
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if (Ultilities.popUpQuestion("Bạn có muốn xóa sản phẩm không?", 0) == DialogResult.Yes)
            {
                // Xóa hàng được chọn trong DataGridView
                foreach(Product product in data_Product)
                {
                    if (dgvDanhSach.SelectedRows[0].Cells[1].Value.ToString() == product.MaSP)
                    {
                        data_Product.Remove(product);
                        Ultilities.popUpInformation("Xóa thành công!");
                        break;
                    }
                }
                showList();
            }
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {    
            if (dgvDanhSach.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvDanhSach.SelectedRows[0].Index;

                // Lấy dữ liệu đã chỉnh sửa từ các TextBox
                soThuTu--;
                string ma = txtMaSP.Text;
                string ten = txtTenSP.Text;
                string ngaySanXuat = dTPNSX.Text;
                string donGia = txtGia.Text;
                string soLuong = txtSoLuong.Text;
                string khoiLuong = txtKhoiLuong.Text;
                string loai = cboLoaiSP.Text;

                // Cập nhật lại hàng trong DataGridView
                dgvDanhSach.Rows[soThuTu - 1].Cells[0].Value = soThuTu;
                dgvDanhSach.Rows[soThuTu - 1].Cells[1].Value = ma;
                dgvDanhSach.Rows[soThuTu - 1].Cells[2].Value = ten;
                dgvDanhSach.Rows[soThuTu - 1].Cells[3].Value = ngaySanXuat;
                dgvDanhSach.Rows[soThuTu - 1].Cells[4].Value = donGia;
                dgvDanhSach.Rows[soThuTu - 1].Cells[5].Value = soLuong;
                dgvDanhSach.Rows[soThuTu - 1].Cells[6].Value = khoiLuong;
                dgvDanhSach.Rows[soThuTu - 1].Cells[7].Value = loai;


                // Xóa dữ liệu khỏi các TextBox sau khi cập nhật
                txtMaSP.Clear();
                txtTenSP.Clear();
                txtGia.Clear();
                txtSoLuong.Clear();
                txtKhoiLuong.Clear();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.SelectedRows.Count > 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dgvDanhSach.SelectedRows[0];

                // Lấy dữ liệu từ các ô của hàng
                string soThuTu = selectedRow.Cells[0].Value.ToString();
                string ma = selectedRow.Cells[1].Value.ToString();
                string ten = selectedRow.Cells[2].Value.ToString();
                string ngaySanXuat = selectedRow.Cells[3].Value.ToString();
                string donGia = selectedRow.Cells[4].Value.ToString();
                string soLuong = selectedRow.Cells[5].Value.ToString();
                string khoiLuong = selectedRow.Cells[6].Value.ToString();
                string loai = selectedRow.Cells[7].Value.ToString();


                // Hiển thị dữ liệu trong các TextBox để cho phép người dùng chỉnh sửa
                txtMaSP.Text = ma;
                txtTenSP.Text = ten;
                dTPNSX.Text = ngaySanXuat;
                txtGia.Text = donGia;
                txtSoLuong.Text = soLuong;
                txtKhoiLuong.Text = khoiLuong;
                cboLoaiSP.Text = loai;

            }

        }

        private void cboLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Thêm các loại sản phẩm vào ComboBox từ danh sách có sẵn
        /// </summary>
        private void ThemLoaiSanPhamVaoComboBox()
        {
            // Tạo một danh sách loại sản phẩm
            List<string> danhSachLoaiSanPham = new List<string>
            {
                "Rau củ quả",
                "Thịt",
                "Hải sản",
                "Trái cây"
            };

            // Gán danh sách loại sản phẩm làm nguồn dữ liệu cho ComboBox
            cboLoaiSP.DataSource = danhSachLoaiSanPham;
        }

        private void frmProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = Ultilities.popUpQuestion("Bạn có muốn lưu thông tin trước khi thoát ?", 1);
            if (res == DialogResult.Yes)
            {
                //Lưu thông tin đã thay đổi và thoát form này
                try
                {
                    //---------------------Ghi dữ liệu vào file---------------------
                    //Dữ liệu 
                    using (StreamWriter sw = new StreamWriter(filePath_Product))
                    {
                        foreach (Product product in data_Product)
                        {
                            sw.WriteLine(product.toFile());
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    Ultilities.popUpError(ex.Message);
                }
            }
            else if (res == DialogResult.No)
            {
                //Thoát form mà không lưu thông tin
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       private void showList()
       {
            dgvDanhSach.Rows.Clear();
            if (data_Product != null) 
            { 
                if (data_Product.Count > 0)
                {
                    int count = 1;
                    foreach (Product product in data_Product)
                    {
                        DataGridViewRow row = new DataGridViewRow();

                        row.Cells.Add(new DataGridViewTextBoxCell { Value = count });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = product.MaSP });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = product.TenSP });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = product.NgaySanXuat });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = product.DonGia });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = product.SoLuong });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = product.KhoiLuong });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = product.LoaiSP });


                        // Thêm hàng vào DataGridView
                        dgvDanhSach.Rows.Add(row);
                        count++;
                    }
                }
            }
           
       }
    }
}
