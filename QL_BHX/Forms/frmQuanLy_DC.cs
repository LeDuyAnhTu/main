using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BHX
{
    public partial class frmQuanLy_DC : Form
    {
        public frmQuanLy_DC()
        {
            InitializeComponent();
            // Điền ComboBox cho địa chỉ
            cboDiaChiChiNhanh.Items.Add("53 Trần Não, Khu Phố 2, An Khánh, Quận 2, Thành phố Hồ Chí Minh");
            cboDiaChiChiNhanh.Items.Add("53 Điện Biên Phủ, Đa Kao, Quận 1, Thành phố Hồ Chí Minh");
            cboDiaChiChiNhanh.Items.Add("53 Hai Bà Trưng, Bến Nghé, Quận 1, Thành phố Hồ Chí Minh");
        }

        private void btnThemChiNhanh_Click(object sender, EventArgs e)
        {
            string maChiNhanhMoi = txtMaChiNhanh.Text;

            // Kiểm tra xem mã chi nhánh đã tồn tại trong DataGridView hay chưa
            bool trungLap = false;
            foreach (DataGridViewRow row in dgvDanhSachChiNhanh.Rows)
            {
                if (row.Cells["colMaChiNhanh"].Value != null && row.Cells["colMaChiNhanh"].Value.ToString() == maChiNhanhMoi)
                {
                    trungLap = true;
                    break;
                }
            }

            if (trungLap)
            {
                MessageBox.Show("Mã chi nhánh đã tồn tại. Vui lòng chọn mã khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Lấy thông tin từ các TextBox
                string maChiNhanh = txtMaChiNhanh.Text;
                string diaChi = cboDiaChiChiNhanh.SelectedItem.ToString();
                string tenChiNhanh = txtTenChiNhanh.Text;

                // Thêm thông tin vào DataGridView
                dgvDanhSachChiNhanh.Rows.Add(maChiNhanh, diaChi, tenChiNhanh);

                // Xóa dữ liệu đã nhập từ TextBox
                txtMaChiNhanh.Clear();
                cboDiaChiChiNhanh.SelectedIndex = -1;
                txtTenChiNhanh.Clear();
                txtMaChiNhanh.Focus();
            }
           
        }

        private void txtTenChiNhanh_TextChanged(object sender, EventArgs e)
        {
            string tenChiNhanh = txtTenChiNhanh.Text;
            bool kiemTra = false;

            foreach (char c in tenChiNhanh)
            {
                if (char.IsDigit(c) || char.IsSymbol(c))
                {
                    kiemTra = true;
                    break;
                }
            }

            if (kiemTra)
            {
                // Nếu có ký tự đặc biệt hoặc số, hiển thị thông báo lỗi
                MessageBox.Show("Tên chi nhánh không được chứa ký tự đặc biệt hoặc số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Xóa chuỗi vừa nhập
                txtTenChiNhanh.Text = "";
                txtTenChiNhanh.Focus();
            }
                
        }

        private void txtMaChiNhanh_TextChanged(object sender, EventArgs e)
        {
            string maChiNhanh = txtMaChiNhanh.Text;
            bool kiemTra = false;
            bool khoangTrang = maChiNhanh.Contains(" ");

            foreach (char c in maChiNhanh)
            {
                if (char.IsSymbol(c))
                {
                    kiemTra = true;
                    break;
                }
            }

            if (kiemTra || khoangTrang)
            {
                // Nếu có ký tự đặc biệt hoặc số, hiển thị thông báo lỗi
                MessageBox.Show("Mã chi nhánh không được chứa ký tự đặc biệt và khoảng trắng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Xóa chuỗi vừa nhập
                txtMaChiNhanh.Text = "";
                txtMaChiNhanh.Focus();
            }
            /*string maChiNhanh = txtMaChiNhanh.Text;

            // Kiểm tra chuỗi mã chi nhánh sử dụng biểu thức chính quy
            if (System.Text.RegularExpressions.Regex.IsMatch(maChiNhanh, "[^a-zA-Z0-9]"))
            {
                // Nếu có ký tự đặc biệt, hiển thị thông báo lỗi
                MessageBox.Show("Mã chi nhánh không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Xóa chuỗi vừa nhập
                txtMaChiNhanh.Text = "";
                txtMaChiNhanh.Focus();
            }*/
        }

        private void btnXoaChiNhanh_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn trong DataGridView
            if (dgvDanhSachChiNhanh.SelectedRows.Count > 0)
            {
                // Hỏi người dùng xác nhận trước khi xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Lấy dòng đang được chọn
                    DataGridViewRow selectedRow = dgvDanhSachChiNhanh.SelectedRows[0];

                    // Xóa dòng đã chọn khỏi DataGridView
                    dgvDanhSachChiNhanh.Rows.Remove(selectedRow);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            //làm mới lại tất cả các ô dữ liệu 
            txtMaChiNhanh.Text = "";
            cboDiaChiChiNhanh.SelectedIndex = -1;
            txtTenChiNhanh.Text = "";
            txtMaChiNhanh.Focus();
        }

        private void btnSuaChiNhanh_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn trong DataGridView
            if (dgvDanhSachChiNhanh.SelectedRows.Count > 0)
            {
                // Hỏi người dùng có chắc là muốn sửa không
                DialogResult sua = MessageBox.Show("Bạn có chắc là muốn sửa nó không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sua == DialogResult.Yes)
                {
                    // Lấy dòng đang được chọn
                    DataGridViewRow selectedRow = dgvDanhSachChiNhanh.SelectedRows[0];

                    // Lấy các giá trị từ các ô dữ liệu của dòng đã chọn
                    string maChiNhanh = selectedRow.Cells["colMaChiNhanh"].Value.ToString();
                    string diaChi = selectedRow.Cells["colDiaChi"].Value.ToString();
                    string tenChiNhanh = selectedRow.Cells["colTenChiNhanh"].Value.ToString();

                    // Cập nhật thông tin chi nhánh với thông tin mới (ví dụ: từ các TextBox và ComboBox)
                    selectedRow.Cells["colMaChiNhanh"].Value = txtMaChiNhanh.Text;
                    selectedRow.Cells["colDiaChi"].Value = cboDiaChiChiNhanh.SelectedItem.ToString();
                    selectedRow.Cells["colTenChiNhanh"].Value = txtTenChiNhanh.Text;

                    // Cập nhật lại DataGridView để hiển thị dữ liệu đã sửa
                    dgvDanhSachChiNhanh.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
