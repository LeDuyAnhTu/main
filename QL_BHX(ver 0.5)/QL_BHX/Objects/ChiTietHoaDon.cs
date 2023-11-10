using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BHX
{
    public class ChiTietHoaDon
    {
        private string _TenSanPham;
        private string _MaSanPham;
        private decimal _SoLuong;
        private decimal _DonGia;
        private decimal _GiamGia;

        public ChiTietHoaDon(string tenSanPham, string maSanPham, decimal soLuong, decimal donGia, decimal giamGia)
        {
            TenSanPham = tenSanPham;
            MaSanPham = maSanPham;
            SoLuong = soLuong;
            DonGia = donGia;
            GiamGia = giamGia;
        }

        public string TenSanPham { get => _TenSanPham; set => _TenSanPham = value; }
        public string MaSanPham { get => _MaSanPham; set => _MaSanPham = value; }
        public decimal SoLuong { get => _SoLuong; set => _SoLuong = value; }
        public decimal DonGia { get => _DonGia; set => _DonGia = value; }
        public decimal GiamGia { get => _GiamGia; set => _GiamGia = value; }
    }
}
