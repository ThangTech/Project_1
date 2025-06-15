using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace DataCtrl
{
    public class ReportCtrl
    {
        public ReportCtrl() { }
        Connecstring Connecstring = new Connecstring();
        public DataTable LayDSChamCong(string maphongban)
        {
            int i = 1;
            DataTable dt = new DataTable();
            DataTable dataTable = new DataTable();
            dt.Columns.Add("STT", typeof(string));
            dt.Columns.Add("MaNhanVien", typeof(string));
            dt.Columns.Add("TenNhanVien", typeof(string));
            dt.Columns.Add("TenPhongBan", typeof(string));
            dt.Columns.Add("GioiTinh", typeof(string));
            dt.Columns.Add("NgaySinh", typeof(DateTime));
            dt.Columns.Add("DiaChi", typeof(string));

            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "select MaNhanVien,TenNhanVien,PhongBan.TenPhongBan,GioiTinh,NgaySinh,DiaChi from NhanVien " +
                "inner join PhongBan on NhanVien.MaPhongBan=PhongBan.MaPhongBan " +
                " Where TinhTrang='True' and Phongban.MaPhongBan=@MaPhongBan";
            Connecstring.SqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(query, Connecstring.Connection);
            Connecstring.SqlDataAdapter.SelectCommand.Parameters.AddWithValue("@MaPhongBan", maphongban);
            Connecstring.SqlDataAdapter.Fill(dataTable);
            Connecstring.Connection.Close();
            foreach (DataRow row in dataTable.Rows)
            {
                dt.Rows.Add(i, row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString()
                    , row[4], row[5].ToString());
                i++;
            }


            return dt;
        }
        public DataTable DSChamCong(string maphongban, int thangnam)
        {
            int i = 1;
            DataTable dt = new DataTable();
            DataTable dataTable = new DataTable();
            dt.Columns.Add("STT", typeof(string));
            dt.Columns.Add("TenNhanVien", typeof(string));
            dt.Columns.Add("TenPhongBan", typeof(string));
            dt.Columns.Add("LuongCoBan", typeof(string));
            dt.Columns.Add("SoNgayLam", typeof(string));
            dt.Columns.Add("KhongCong", typeof(string));
            dt.Columns.Add("TongLuong", typeof(string));
            dt.Columns.Add("ThangNam", typeof(string));
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "select TenNhanVien,PhongBan.TenPhongBan,LuongCoBan,SoNgayLam,KhongCong,TongLuong from BangLuong " +
                "inner join NhanVien on BangLuong.MaNhanVien=NhanVien.MaNhanVien " +
                " inner join PhongBan on NhanVien.MaPhongBan=PhongBan.MaPhongBan " +

                " Where TinhTrang='True' and Phongban.MaPhongBan=@MaPhongBan and BangLuong.ThangNam=@ThangNam";
            Connecstring.SqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(query, Connecstring.Connection);
            Connecstring.SqlDataAdapter.SelectCommand.Parameters.AddWithValue("@MaPhongBan", maphongban);
            Connecstring.SqlDataAdapter.SelectCommand.Parameters.AddWithValue("@ThangNam", thangnam);
            Connecstring.SqlDataAdapter.Fill(dataTable);
            Connecstring.Connection.Close();
            foreach (DataRow row in dataTable.Rows)
            {
                dt.Rows.Add(i, row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString()
                    , row[4], row[5].ToString(), thangnam);
                i++;
            }


            return dt;
        }
        public DataTable LayDSBaoHiem()
        {
            int i = 1;
            DataTable dt = new DataTable();
            DataTable dataTable = new DataTable();

            dt.Columns.Add("STT", typeof(string));
            dt.Columns.Add("MaBaoHiem", typeof(string));
            dt.Columns.Add("TenNhanVien", typeof(string));
            dt.Columns.Add("LoaiBaoHiem", typeof(string));
            dt.Columns.Add("NgayCap", typeof(DateTime));
            dt.Columns.Add("NgayHetHan", typeof(DateTime));
            dt.Columns.Add("NoiCap", typeof(string));

            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();

            string query = @"
        SELECT 
            BaoHiem.MaBaoHiem,
            NhanVien.TenNhanVien,
            BaoHiem.LoaiBaoHiem,
            BaoHiem.NgayCap,
            BaoHiem.NgayHetHan,
            BaoHiem.NoiCap
        FROM BaoHiem
        INNER JOIN NhanVien ON BaoHiem.MaNhanVien = NhanVien.MaNhanVien
        WHERE NhanVien.TinhTrang = 'True'";

            Connecstring.SqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(query, Connecstring.Connection);
            Connecstring.SqlDataAdapter.Fill(dataTable);

            Connecstring.Connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                dt.Rows.Add(i,
                    row["MaBaoHiem"].ToString(),
                    row["TenNhanVien"].ToString(),
                    row["LoaiBaoHiem"].ToString(),
                    row["NgayCap"],
                    row["NgayHetHan"],
                    row["NoiCap"].ToString()
                );
                i++;
            }

            return dt;
        }
        public DataTable LayDSKTP()
        {
            int i = 1;
            DataTable dt = new DataTable();
            DataTable dataTable = new DataTable();

            dt.Columns.Add("STT", typeof(string));
            dt.Columns.Add("MaKTP", typeof(string));
            dt.Columns.Add("Loai", typeof(string));
            dt.Columns.Add("LyDo", typeof(string));
            dt.Columns.Add("SoTien", typeof(decimal));
            dt.Columns.Add("ThangNam", typeof(string));

            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();

            string query = @"
        SELECT 
        MaKTP,
        CASE WHEN Loai = 'Khen' THEN N'Khen Thưởng' ELSE N'Phạt' END AS Loai,
        LyDo,
        SoTien,
        RIGHT(ThangNam, 2) + '/'+ LEFT(ThangNam, 4) AS ThangNam
        FROM KhenThuongPhat
";

            Connecstring.SqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(query, Connecstring.Connection);
            Connecstring.SqlDataAdapter.Fill(dataTable);
            Connecstring.Connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                dt.Rows.Add(i,
                    row["MaKTP"].ToString(),
                    row["Loai"].ToString(),
                    row["LyDo"].ToString(),
                    Convert.ToDecimal(row["SoTien"]),
                    row["ThangNam"].ToString()
                );
                i++;
            }

            return dt;
        }
    }
}
