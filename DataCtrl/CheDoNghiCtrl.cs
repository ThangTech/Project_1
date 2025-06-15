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
    public class CheDoNghiCtrl
    {
        public CheDoNghiCtrl() { }
        Connecstring Connecstring = new Connecstring();
        public DataTable HienThi()
        {
            DataTable dt = new DataTable();
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "select * from CheDoNghi";
            Connecstring.SqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(query, Connecstring.Connection);

            Connecstring.SqlDataAdapter.Fill(dt);
            Connecstring.Connection.Close();

            return dt;
        }
        public DataTable HienThiTimKiem(string timkiem)
        {
            DataTable dt = new DataTable();
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "select * from CheDoNghi where MaNhanVien like @TimKiem ";
            Connecstring.SqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(query, Connecstring.Connection);
            Connecstring.SqlDataAdapter.SelectCommand.Parameters.AddWithValue("@TimKiem", "%" + timkiem + "%");
            Connecstring.SqlDataAdapter.Fill(dt);
            Connecstring.Connection.Close();
            return dt;
        }
        public void Them(CheDoNghi cheDoNghi)
        {
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "Insert into CheDoNghi values(@MaNghi,@MaNhanVien,@LoaiNghi,@NgayBatDau,@NgayKetThuc,@LyDo)";
            Connecstring.SqlCommand = new System.Data.SqlClient.SqlCommand(query, Connecstring.Connection);
            SqlParameter sqlParameter1 = new SqlParameter("@MaNghi", cheDoNghi.MaNghi);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter1);
            SqlParameter sqlParameter2 = new SqlParameter("@MaNhanVien", cheDoNghi.MaNhanVien);

            Connecstring.SqlCommand.Parameters.Add(sqlParameter2);
            SqlParameter sqlParameter3 = new SqlParameter("@LoaiNghi", cheDoNghi.LoaiNghi);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter3);
            SqlParameter sqlParameter4 = new SqlParameter("@NgayBatDau", cheDoNghi.NgayBatDau);

            Connecstring.SqlCommand.Parameters.Add(sqlParameter4);
            SqlParameter sqlParameter5 = new SqlParameter("@NgayKetThuc", cheDoNghi.NgayKetThuc);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter5);
            SqlParameter sqlParameter6 = new SqlParameter("@LyDo", cheDoNghi.LyDo);

            Connecstring.SqlCommand.Parameters.Add(sqlParameter6);
            Connecstring.SqlCommand.ExecuteNonQuery();
            Connecstring.Connection.Close();
        }
        public void Sua(CheDoNghi cheDoNghi)
        {
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "Update CheDoNghi set MaNhanVien=@MaNhanVien," +
                "LoaiNghi=@LoaiNghi,NgayBatDau=@NgayBatDau,NgayKetThuc=@NgayKetThuc,LyDo=@LyDo" +
                " where MaNghi=@MaNghi";
            Connecstring.SqlCommand = new System.Data.SqlClient.SqlCommand(query, Connecstring.Connection);
            Connecstring.SqlCommand = new System.Data.SqlClient.SqlCommand(query, Connecstring.Connection);
            SqlParameter sqlParameter1 = new SqlParameter("@MaNghi", cheDoNghi.MaNghi);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter1);
            SqlParameter sqlParameter2 = new SqlParameter("@MaNhanVien", cheDoNghi.MaNhanVien);

            Connecstring.SqlCommand.Parameters.Add(sqlParameter2);
            SqlParameter sqlParameter3 = new SqlParameter("@LoaiNghi", cheDoNghi.LoaiNghi);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter3);
            SqlParameter sqlParameter4 = new SqlParameter("@NgayBatDau", cheDoNghi.NgayBatDau);

            Connecstring.SqlCommand.Parameters.Add(sqlParameter4);
            SqlParameter sqlParameter5 = new SqlParameter("@NgayKetThuc", cheDoNghi.NgayKetThuc);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter5);
            SqlParameter sqlParameter6 = new SqlParameter("@LyDo", cheDoNghi.LyDo);
            Connecstring.SqlCommand.ExecuteNonQuery();
            Connecstring.Connection.Close();
        }
        public void Xoa(string manghi)
        {
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "Delete from CheDoNghi where MaNghi=@MaNghi";
            Connecstring.SqlCommand = new System.Data.SqlClient.SqlCommand(query, Connecstring.Connection);
            SqlParameter sqlParameter1 = new SqlParameter("@MaNghi", manghi);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter1);

            Connecstring.SqlCommand.ExecuteNonQuery();
            Connecstring.Connection.Close();
        }
        public bool KiemTraTrungMa(string maNghi)
        {
            bool tonTai = false;
            Connecstring.Connection = new SqlConnection(Connecstring.str_Connect);
            string query = "SELECT COUNT(*) FROM CheDoNghi WHERE MaNghi = @MaNghi";
            SqlCommand cmd = new SqlCommand(query, Connecstring.Connection);
            cmd.Parameters.AddWithValue("@MaNghi", maNghi);
            Connecstring.Connection.Open();
            int count = (int)cmd.ExecuteScalar();
            tonTai = count > 0;
            Connecstring.Connection.Close();
            return tonTai;
        }

    }
}
