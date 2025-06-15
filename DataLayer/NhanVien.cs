using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class NhanVien
    {
        public string MaNhanVien {  get; set; }

        public string TenNhanVien{  get; set; }


        public string MaPhongBan { get; set; }
        public string MaChucVu { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh {  get; set; }
        public string DiaChi { get; set; }
        public string SoCMND { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public string TrinhDo { get; set; }
        public DateTime NgayVaoLam {  get; set; }
        public double MucLuong {  get; set; }   
        public int HeSoLuong{  get; set; }
        public double PhuCap { get; set; }
        public bool TinhTrang {get; set; }
    }
}
