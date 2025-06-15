using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace DataCtrl
{
    public class NhanVienCtrl
    {
        public NhanVienCtrl() { }
        Connecstring Connecstring = new Connecstring();
        public DataTable HienThi()
        {
            DataTable dt = new DataTable();
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "SELECT * FROM NhanVien";
            Connecstring.SqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(query, Connecstring.Connection);

            Connecstring.SqlDataAdapter.Fill(dt);
            Connecstring.Connection.Close();

            return dt;
        }
        public DataTable LayDSChamCong()
        {
            DataTable dt = new DataTable();
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            //string query = "select * from NhanVien Where TinhTrang='True'";
            //string query = "SELECT MaNhanVien, TenNhanVien, TinhTrang FROM NhanVien WHERE TinhTrang = 1";
            string query = "SELECT * FROM NhanVien WHERE TinhTrang = 1";
            Connecstring.SqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(query, Connecstring.Connection);

            Connecstring.SqlDataAdapter.Fill(dt);
            Connecstring.Connection.Close();

            return dt;
        }
        public DataTable LayDSChamCongPhongBan(string phongban)
        {
            DataTable dt = new DataTable();
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            //string query = "select * from NhanVien Where TinhTrang='True'";
            string query = "SELECT MaNhanVien, TenNhanVien, TinhTrang FROM NhanVien " +
                "inner join PhongBan on NhanVien.MaPhongBan=PhongBan.MaPhongBan" +
                "  WHERE NhanVien.MaPhongBan=@MaPhongBan and TinhTrang = 1";
            Connecstring.SqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(query, Connecstring.Connection);
            Connecstring.SqlDataAdapter.SelectCommand.Parameters.AddWithValue("@MaPhongBan", phongban);
            Connecstring.SqlDataAdapter.Fill(dt);
            Connecstring.Connection.Close();

            return dt;
        }
        public NhanVien LayNhanVienTheoMa(string maNhanVien)
        {
            NhanVien nv = null;
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(Connecstring.str_Connect))
            {
                try
                {
                    conn.Open();
                   
                    string query = "SELECT MaNhanVien, TenNhanVien, MaPhongBan, MaChucVu, GioiTinh, NgaySinh, DiaChi, SoCMND, DienThoai, Email, TrinhDo, NgayVaoLam, MucLuong, HeSoLuong, PhuCap, TinhTrang FROM NhanVien WHERE MaNhanVien = @MaNhanVien";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                        da.Fill(dt);
                    }

                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];
                        nv = new NhanVien
                        {
                            MaNhanVien = row["MaNhanVien"].ToString(),
                            TenNhanVien = row["TenNhanVien"].ToString(),
                            MaPhongBan = row["MaPhongBan"].ToString(),
                            MaChucVu = row["MaChucVu"].ToString(),
                            GioiTinh = row["GioiTinh"].ToString(),
                            NgaySinh = Convert.ToDateTime(row["NgaySinh"]),
                            DiaChi = row["DiaChi"].ToString(),
                            SoCMND = row["SoCMND"].ToString(),
                            DienThoai = row["DienThoai"].ToString(),
                            Email = row["Email"].ToString(),
                            TrinhDo = row["TrinhDo"].ToString(),
                            NgayVaoLam = Convert.ToDateTime(row["NgayVaoLam"]),
                            MucLuong = Convert.ToDouble(row["MucLuong"]),
                            HeSoLuong = Convert.ToInt32(row["HeSoLuong"]),
                            PhuCap = Convert.ToDouble(row["PhuCap"]),
                            TinhTrang = Convert.ToBoolean(row["TinhTrang"])
                        };
                    }
                }
                catch (Exception ex) { Console.WriteLine("Lỗi khi lấy nhân viên theo mã: " + ex.Message); }
            }
            return nv;
        }
        public DataTable HienThiTimKiem(string timkiem)
        {
            DataTable dt = new DataTable();
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "select * from NhanVien where TenNhanVien like @TimKiem";
            Connecstring.SqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(query, Connecstring.Connection);
            Connecstring.SqlDataAdapter.SelectCommand.Parameters.AddWithValue("@TimKiem", "%" + timkiem + "%");
            Connecstring.SqlDataAdapter.Fill(dt);
            Connecstring.Connection.Close();
            return dt;
        }
        public void Them(NhanVien nhanVien)
        {
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "Insert into NhanVien values(@MaNhanVien,@TenNhanVien,@MaPhongBan,@MaChucVu,@GioiTinh," +
                "@NgaySinh,@DiaChi,@SoCMND,@DienThoai,@Email,@TrinhDo,@NgayVaoLam,@MucLuong,@HeSoLuong,@PhuCap,@TinhTrang)";
            Connecstring.SqlCommand = new System.Data.SqlClient.SqlCommand(query, Connecstring.Connection);
            SqlParameter sqlParameter1 = new SqlParameter("@MaNhanVien", nhanVien.MaNhanVien);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter1);
            SqlParameter sqlParameter2 = new SqlParameter("@TenNhanVien", nhanVien.TenNhanVien);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter2);
            SqlParameter sqlParameter3 = new SqlParameter("@MaPhongBan", nhanVien.MaPhongBan);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter3);
            SqlParameter sqlParameter4 = new SqlParameter("@MaChucVu", nhanVien.MaChucVu);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter4);
            SqlParameter sqlParameter5 = new SqlParameter("@GioiTinh", nhanVien.GioiTinh);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter5);
            SqlParameter sqlParameter6 = new SqlParameter("@NgaySinh", nhanVien.NgaySinh);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter6);
            SqlParameter sqlParameter7 = new SqlParameter("@DiaChi", nhanVien.DiaChi);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter7);
            SqlParameter sqlParameter8 = new SqlParameter("@SoCMND", nhanVien.SoCMND);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter8);
            SqlParameter sqlParameter9 = new SqlParameter("@DienThoai", nhanVien.DienThoai);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter9);
            SqlParameter sqlParameter10 = new SqlParameter("@Email", nhanVien.Email);
                Connecstring.SqlCommand.Parameters.Add(sqlParameter10); ;
            SqlParameter sqlParameter11 = new SqlParameter("@TrinhDo", nhanVien.TrinhDo);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter11);
            SqlParameter sqlParameter12 = new SqlParameter("@NgayVaoLam", nhanVien.NgayVaoLam);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter12);
            SqlParameter sqlParameter13 = new SqlParameter("@HeSoLuong", nhanVien.HeSoLuong);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter13);
            SqlParameter sqlParameter14 = new SqlParameter("@TinhTrang", nhanVien.TinhTrang);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter14);
            SqlParameter sqlParameter15 = new SqlParameter("@MucLuong", nhanVien.MucLuong);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter15);
            SqlParameter sqlParameter16 = new SqlParameter("@PhuCap", nhanVien.PhuCap);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter16);
            Connecstring.SqlCommand.ExecuteNonQuery();
            Connecstring.Connection.Close();
        }
        public void Sua(NhanVien nhanVien)
        {
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "Update NhanVien set TenNhanVien=@TenNhanVien,MaPhongBan=@MaPhongBan,MaChucVu=@MaChucVu,GioiTinh=@GioiTinh," +
                "NgaySinh=@NgaySinh,DiaChi=@DiaChi,SoCMND=@SoCMND,DienThoai=@DienThoai,Email=@Email,TrinhDo=@TrinhDo," +
                "NgayVaoLam=@NgayVaoLam,HeSoLuong=@HeSoLuong,MucLuong=@MucLuong,PhuCap=@PhuCap" +
                " where MaNhanVien=@MaNhanVien";
            Connecstring.SqlCommand = new System.Data.SqlClient.SqlCommand(query, Connecstring.Connection);
            SqlParameter sqlParameter1 = new SqlParameter("@MaNhanVien", nhanVien.MaNhanVien);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter1);
            SqlParameter sqlParameter2 = new SqlParameter("@TenNhanVien", nhanVien.TenNhanVien);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter2);
            SqlParameter sqlParameter3 = new SqlParameter("@MaPhongBan", nhanVien.MaPhongBan);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter3);
            SqlParameter sqlParameter4 = new SqlParameter("@MaChucVu", nhanVien.MaChucVu);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter4);
            SqlParameter sqlParameter5 = new SqlParameter("@GioiTinh", nhanVien.GioiTinh);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter5);
            SqlParameter sqlParameter6 = new SqlParameter("@NgaySinh", nhanVien.NgaySinh);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter6);
            SqlParameter sqlParameter7 = new SqlParameter("@DiaChi", nhanVien.DiaChi);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter7);
            SqlParameter sqlParameter8 = new SqlParameter("@SoCMND", nhanVien.SoCMND);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter8);
            SqlParameter sqlParameter9 = new SqlParameter("@DienThoai", nhanVien.DienThoai);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter9);
            SqlParameter sqlParameter10 = new SqlParameter("@Email", nhanVien.Email);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter10); ;
            SqlParameter sqlParameter11 = new SqlParameter("@TrinhDo", nhanVien.TrinhDo);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter11);
            SqlParameter sqlParameter12 = new SqlParameter("@NgayVaoLam", nhanVien.NgayVaoLam);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter12);
            SqlParameter sqlParameter13 = new SqlParameter("@HeSoLuong", nhanVien.HeSoLuong);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter13);
            SqlParameter sqlParameter15 = new SqlParameter("@MucLuong", nhanVien.MucLuong);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter15);
            SqlParameter sqlParameter16 = new SqlParameter("@PhuCap", nhanVien.PhuCap);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter16);
            Connecstring.SqlCommand.ExecuteNonQuery();
            Connecstring.Connection.Close();
        }
        public void Xoa(string manhanvien)
        {
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            //string query = "Update  NhanVien Set TinhTrang='False' where MaNhanVien=@MaNhanVien";
            string query = "Update NhanVien Set TinhTrang = 0 where MaNhanVien=@MaNhanVien";
            Connecstring.SqlCommand = new System.Data.SqlClient.SqlCommand(query, Connecstring.Connection);
            SqlParameter sqlParameter1 = new SqlParameter("@MaNhanVien", manhanvien);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter1);

            Connecstring.SqlCommand.ExecuteNonQuery();
            Connecstring.Connection.Close();
        }
        public bool KiemTraTrungMa(string maNhanVien)
        {
            bool isTrung = false;
            Connecstring.Connection = new SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();

            string query = "SELECT COUNT(*) FROM NhanVien WHERE MaNhanVien = @MaNhanVien";
            Connecstring.SqlCommand = new SqlCommand(query, Connecstring.Connection);
            Connecstring.SqlCommand.Parameters.AddWithValue("@MaNhanVien", maNhanVien);

            int count = (int)Connecstring.SqlCommand.ExecuteScalar();
            if (count > 0)
                isTrung = true;

            Connecstring.Connection.Close();
            return isTrung;
        }
        public bool CheckCMND(string soCMND)
        {
            bool isTrung = false;
            Connecstring.Connection = new SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();

            string query = "SELECT COUNT(*) FROM NhanVien WHERE SoCMND = @SoCMND";
            Connecstring.SqlCommand = new SqlCommand(query, Connecstring.Connection);
            Connecstring.SqlCommand.Parameters.AddWithValue("@SoCMND", soCMND);

            int count = (int)Connecstring.SqlCommand.ExecuteScalar();
            if (count > 0)
                isTrung = true;

            Connecstring.Connection.Close();
            return isTrung;
        }
        public bool CheckSDT(string soDienThoai)
        {
            bool isTrung = false;
            Connecstring.Connection = new SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();

            string query = "SELECT COUNT(*) FROM NhanVien WHERE SoDienThoai = @SoDienThoai";
            Connecstring.SqlCommand = new SqlCommand(query, Connecstring.Connection);
            Connecstring.SqlCommand.Parameters.AddWithValue("@SoDienThoai", soDienThoai);

            int count = (int)Connecstring.SqlCommand.ExecuteScalar();
            if (count > 0)
                isTrung = true;

            Connecstring.Connection.Close();
            return isTrung;
        }


    }
}
