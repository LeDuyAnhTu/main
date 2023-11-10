using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BHX
{
    public class Bill
    {
        private string _MaHoaDon;
        private DateTime _NgayBan;
        private string _TenNhanVien;
        private string _ThanhTien;

        

        public string MaHoaDon { get => _MaHoaDon; set => _MaHoaDon = value; }
        public DateTime NgayBan { get => _NgayBan; set => _NgayBan = value; }
        public string TenNhanVien { get => _TenNhanVien; set => _TenNhanVien = value; }
        public string ThanhTien { get => _ThanhTien; set => _ThanhTien = value; }



        public Bill(string maHoaDon, DateTime ngayBan, string tenNhanVien, string thanhTien)
        {
            MaHoaDon = maHoaDon;
            NgayBan = ngayBan;
            TenNhanVien = tenNhanVien;
            ThanhTien = thanhTien;
        }

    }
}
