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
    public partial class frmQuanLyHoaDon : Form
    {
        private LinkedList<Bill> data_HoaDon;
        private LinkedList<ChiTietHoaDon> data_ChiTietHoaDon;
        bool isEdit = false;
        public frmQuanLyHoaDon()
        {
            InitializeComponent();
        }

        private void frmQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            //Thêm danh sách hóa đơn
            data_HoaDon = new LinkedList<Bill>();
            Bill hd1 = new Bill("BHX101001", new DateTime(2023, 4, 24), "Lê Ngọc Cảnh", "1010003" );
            Bill hd2 = new Bill("BHX101002", new DateTime(2023, 5, 4), "Nguyễn Quang Đại", "1010002");
            Bill hd3 = new Bill("BHX101003", new DateTime(2023, 5, 1), "Trần Đức Tín", "1010001");
            Bill hd4 = new Bill("BHX101004", new DateTime(2023, 6, 25), "Nguyễn Hữu Nguyện", "1010004");
            Bill hd5 = new Bill("BHX101005", new DateTime(2023, 6, 26), "Nguyễn Quang Đại", "1010002");
            Bill hd6 = new Bill("BHX101006", new DateTime(2023, 7, 25), "Lê Ngọc Cảnh", "1010003");
            Bill hd7 = new Bill("BHX101007", new DateTime(2023, 7, 25), "Nguyễn Hữu Nguyện", "1010004");
            Bill hd8 = new Bill("BHX101008", new DateTime(2023, 8, 25), "Trần Đức Tín", "1010001");
            Bill hd9 = new Bill("BHX101009", new DateTime(2023, 8, 21), "Lê Ngọc Cảnh", "1010003");
            Bill hd10 = new Bill("BHX1010010", new DateTime(2023, 9, 25), "Nguyễn Hữu Nguyện", "1010004");
            Bill hd11 = new Bill("BHX1010011", new DateTime(2023, 9, 19), "Nguyễn Quang Đại", "1010002");
            Bill hd12 = new Bill("BHX1010012", new DateTime(2023, 9, 25), "Trần Đức Tín", "1010001");
            Bill hd13 = new Bill("BHX1010013", new DateTime(2023, 9, 25), "Nguyễn Hữu Nguyện", "1010004");
            Bill hd14 = new Bill("BHX1010014", new DateTime(2023, 10, 22), "Nguyễn Quang Đại", "1010002");
            Bill hd15 = new Bill("BHX1010015", new DateTime(2023, 10, 23), "Lê Ngọc Cảnh", "1010003");
            Bill hd16 = new Bill("BHX1010016", new DateTime(2023, 10, 25), "Trần Đức Tín", "1010001");
            data_HoaDon.AddLast(hd1);
            data_HoaDon.AddLast(hd2);
            data_HoaDon.AddLast(hd3);
            data_HoaDon.AddLast(hd4);
            data_HoaDon.AddLast(hd5);
            data_HoaDon.AddLast(hd6);
            data_HoaDon.AddLast(hd7);
            data_HoaDon.AddLast(hd8);
            data_HoaDon.AddLast(hd9);
            data_HoaDon.AddLast(hd10);
            data_HoaDon.AddLast(hd11);
            data_HoaDon.AddLast(hd12);
            data_HoaDon.AddLast(hd13);
            data_HoaDon.AddLast(hd14);
            data_HoaDon.AddLast(hd15);
            data_HoaDon.AddLast(hd16);

            // Thêm thông tin chi tiết hóa đơn vào danh sách
            data_ChiTietHoaDon = new LinkedList<ChiTietHoaDon>();

            ChiTietHoaDon chiTiet1 = new ChiTietHoaDon("KHOAI LAN MẬT", "RCQ101001", 1.602m, 29.000m, 20);
            ChiTietHoaDon chiTiet2 = new ChiTietHoaDon("SẮN VÒI", "RCQ101002", 2.345m, 25.500m, 15);
            ChiTietHoaDon chiTiet3 = new ChiTietHoaDon("BANH DORAYAKI", "C101003", 3, 18.750m, 10);
            ChiTietHoaDon chiTiet4 = new ChiTietHoaDon("HỒNG", "FRQ101004", 0.850m, 16.200m, 5);
            ChiTietHoaDon chiTiet5 = new ChiTietHoaDon("XOÀI", "FR101005", 4.123m, 22.750m, 12);
            data_ChiTietHoaDon.AddLast(chiTiet1);
            data_ChiTietHoaDon.AddLast(chiTiet2);
            data_ChiTietHoaDon.AddLast (chiTiet3);
            data_ChiTietHoaDon.AddLast(chiTiet4);
            data_ChiTietHoaDon.AddLast(chiTiet5);

        }
       
        /// <summary>
        /// khi người dùng click nút tìm theo khoảng ngày
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTimTheoKhoangNgay_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ DateTimePicker Ngày Bắt đầu và Ngày Kết thúc
            DateTime startDate = dTPTuNgay.Value;
            DateTime endDate = dTPDenNgay.Value;

            // Lọc dữ liệu từ danh sách data_HoaDon và hiển thị trong DataGridView
            var danhSachTrongKhoang = data_HoaDon.Where(h => h.NgayBan.Date >= startDate.Date && h.NgayBan.Date <= endDate.Date).ToList();
            dgvDanhSachHoaDon.DataSource = danhSachTrongKhoang;
        }


        private List<ChiTietHoaDon> LayChiTietHoaDonTheoMa(string maHoaDon)
        {
            List<ChiTietHoaDon> chiTietHoaDonList = new List<ChiTietHoaDon>();

           /* foreach (DataGridViewRow row in dgvCTHoaDon.Rows)
            {
                // Check if the current row has the expected maHoaDon value
                if (row.Cells["MaHoaDon"].Value != null && row.Cells["MaHoaDon"].Value.ToString() == maHoaDon)
                {
                    // Extract the data from the row and create a ChiTietHoaDon object
                    string maSanPham = row.Cells["maSanPham"].Value.ToString();
                    string tenSanPham = row.Cells["tenSanPham"].Value.ToString();
                    decimal soLuong = decimal.Parse(row.Cells["soLuong"].Value.ToString());
                    decimal donGia = decimal.Parse(row.Cells["donGia"].Value.ToString());
                    decimal giamGiaPhanTram = decimal.Parse(row.Cells["giamGia"].Value.ToString());

                    ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon(maSanPham, tenSanPham, soLuong, donGia, giamGiaPhanTram);

                    // Add the ChiTietHoaDon object to the list
                    chiTietHoaDonList.Add(chiTietHoaDon);
                }
            }*/

            return chiTietHoaDonList;
        }

        private void dgvDanhSachHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            // Lấy thông tin hóa đơn được chọn
            DataGridViewRow selectedRow = dgvDanhSachHoaDon.CurrentRow;
            if (selectedRow != null)
            {
                string maHoaDon = selectedRow.Cells["MaHoaDon"].Value.ToString(); // Make sure "maHoaDon" matches the actual column name

                // Lọc danh sách chi tiết hóa đơn dựa trên mã hóa đơn
                var chiTietHoaDon = LayChiTietHoaDonTheoMa(maHoaDon);

                // Hiển thị danh sách chi tiết hóa đơn trong dgvCTHoaDon
                dgvCTHoaDon.DataSource = chiTietHoaDon; // Set the DataSource to chiTietHoaDon
            }
        }

        private void dgvDanhSachHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void dgvCTHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void showList(string name)
        {
            int count = 1;
            foreach (ChiTietHoaDon item in data_ChiTietHoaDon)
            {
                item.
            }    
        }
       
    }
}
