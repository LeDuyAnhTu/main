using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QL_BHX
{
    public class Product
    {

        //fields
        private string _MaSP;
        private string _TenSP;
        private DateTime _NgaySanXuat;
        private decimal _DonGia;
        private int _SoLuong;
        private float _KhoiLuong;
        private string _LoaiSP;

        //constructor
        public Product(string maSP, string tenSP, DateTime ngaySX, decimal donGia, int soLuong, float khoiLuong, string loaiSP)
        {
            MaSP = maSP;
            TenSP = tenSP;
            NgaySanXuat = ngaySX;
            DonGia = donGia;
            SoLuong = soLuong;
            KhoiLuong = khoiLuong;
            LoaiSP = loaiSP;
            
        }


        //properties
        public string MaSP { get => _MaSP; set => _MaSP = value; }
        public string TenSP { get => _TenSP; set => _TenSP = value; }
        public string LoaiSP { get => _LoaiSP; set => _LoaiSP = value; }
        public DateTime NgaySanXuat { get => _NgaySanXuat; set => _NgaySanXuat = value; }
        public decimal DonGia { get => _DonGia; set => _DonGia = value; }
        public int SoLuong { get => _SoLuong; set => _SoLuong = value; }
        public float KhoiLuong { get => _KhoiLuong; set => _KhoiLuong = value; }

       public string toFile()
       {
            return MaSP + "#"+TenSP + "#" +NgaySanXuat + "#"+ DonGia + "#"+ SoLuong + "#"+ KhoiLuong;
       }
    }


}
