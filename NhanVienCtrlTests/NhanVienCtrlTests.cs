using NUnit.Framework;
using DataCtrl;
using System.Data;
using DataLayer;
using System;
namespace NhanVienCtrlTests
{
    [TestFixture]
    public class NhanVienCtrlTests
    {
        private NhanVienCtrl nhanVienCtrl;

        [SetUp]
        public void Setup()
        {
            nhanVienCtrl = new NhanVienCtrl();
        }
        public void Cleanup()
        {
            nhanVienCtrl.Xoa("NVTEST01"); 
        }
        [Test]
        public void Test_HienThi()
        {
            var result = nhanVienCtrl.HienThi();
            Assert.IsNotNull(result, "Dữ liệu trả về không được null");
            Assert.AreEqual(typeof(DataTable), result.GetType(), "Kết quả phải là một DataTable");
            TestContext.WriteLine("Test_HienThi: Passed");
        }

        [Test]
        public void Test_TrungMa_False()
        {
            bool expected = false;
            bool actual = nhanVienCtrl.KiemTraTrungMa("KHONGTONTAI999");
            Assert.AreEqual(expected, actual, "Mã KHONGTONTAI999 không nên tồn tại");
            TestContext.WriteLine("Test_TrungMa_False: Passed");
        }

        [Test]
        public void Test_TimKiem_MaKhongTonTai()
        {
            var result = nhanVienCtrl.HienThiTimKiem("KHONGTONTAI999");
            Assert.IsNotNull(result, "Kết quả không được null");
            Assert.AreEqual(typeof(DataTable), result.GetType(), "Kết quả phải là DataTable");
            Assert.AreEqual(0, result.Rows.Count, "Phải không tìm thấy nhân viên nào với mã 'KHONGTONTAI999'");
            TestContext.WriteLine("Test_TimKiem_MaKhongTonTai: Passed");
        }

        [Test]
        public void Test_CMND_False()
        {
            bool expected = false;
            bool actual = nhanVienCtrl.CheckCMND("000000000");
            Assert.AreEqual(expected, actual, "CMND 000000000 không nên tồn tại");
            TestContext.WriteLine("Test_CMND_False: Passed");
        }
        //[Test]
        //public void Test_ThemNhanVien_HopLe()
        //{
        //    var nv = new NhanVien
        //    {
        //        MaNhanVien = "NVTEST01",
        //        TenNhanVien = "Nguyễn Văn Test",
        //        MaPhongBan = "PB01",
        //        MaChucVu = "CV01",
        //        GioiTinh = "Nam",
        //        NgaySinh = new DateTime(1990, 1, 1),
        //        DiaChi = "Hà Nội",
        //        SoCMND = "123456789",
        //        DienThoai = "0912345678",
        //        Email = "test@example.com",
        //        TrinhDo = "Đại học",
        //        NgayVaoLam = DateTime.Now,
        //        MucLuong = 10000000,
        //        HeSoLuong = 2,
        //        PhuCap = 500000,
        //        TinhTrang = true
        //    };

        //    nhanVienCtrl.Them(nv);
        //    bool tonTai = nhanVienCtrl.KiemTraTrungMa("NVTEST01");
        //    Assert.IsTrue(tonTai, "Nhân viên vừa thêm phải tồn tại trong hệ thống");
        //}

        //[Test]
        //public void Test_SuaNhanVien_HopLe()
        //{
        //    // Thêm trước
        //    var nv = new NhanVien
        //    {
        //        MaNhanVien = "NVTEST01",
        //        TenNhanVien = "Nguyễn Văn A",
        //        MaPhongBan = "PB01",
        //        MaChucVu = "CV01",
        //        GioiTinh = "Nam",
        //        NgaySinh = new DateTime(1990, 1, 1),
        //        DiaChi = "Hà Nội",
        //        SoCMND = "123456789",
        //        DienThoai = "0912345678",
        //        Email = "test@example.com",
        //        TrinhDo = "Đại học",
        //        NgayVaoLam = DateTime.Now,
        //        MucLuong = 10000000,
        //        HeSoLuong = 2,
        //        PhuCap = 500000,
        //        TinhTrang = true
        //    };
        //    nhanVienCtrl.Them(nv);

        //    // Sửa tên
        //    nv.TenNhanVien = "Nguyễn Văn B";
        //    nv.Email = "updated@example.com";
        //    nhanVienCtrl.Sua(nv);

        //    var result = nhanVienCtrl.HienThiTimKiem("Nguyễn Văn B");
        //    Assert.IsTrue(result.Rows.Count > 0, "Sau khi sửa, phải tìm được nhân viên mới");
        //    Assert.AreEqual("updated@example.com", result.Rows[0]["Email"].ToString());
        //}

        //[Test]
        //public void Test_XoaNhanVien()
        //{
        //    var nv = new NhanVien
        //    {
        //        MaNhanVien = "NVTEST01",
        //        TenNhanVien = "Nguyễn Văn C",
        //        MaPhongBan = "PB01",
        //        MaChucVu = "CV01",
        //        GioiTinh = "Nam",
        //        NgaySinh = new DateTime(1990, 1, 1),
        //        DiaChi = "Hà Nội",
        //        SoCMND = "987654321",
        //        DienThoai = "0987654321",
        //        Email = "xoa@example.com",
        //        TrinhDo = "Cao đẳng",
        //        NgayVaoLam = DateTime.Now,
        //        MucLuong = 8000000,
        //        HeSoLuong = 2,
        //        PhuCap = 300000,
        //        TinhTrang = true
        //    };
        //    nhanVienCtrl.Them(nv);
        //    nhanVienCtrl.Xoa("NVTEST01");

        //    var ds = nhanVienCtrl.LayDSChamCong(); // Chỉ lấy nhân viên TinhTrang = true
        //    bool tonTaiSauXoa = ds.Select("MaNhanVien = 'NVTEST01'").Length > 0;
        //    Assert.IsFalse(tonTaiSauXoa, "Nhân viên đã xóa không nên hiển thị trong danh sách chấm công");
        //}

    }
}
