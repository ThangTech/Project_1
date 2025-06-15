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
    public class KhenThuongPhatCtrl
    {
       public KhenThuongPhatCtrl() { }
        Connecstring Connecstring = new Connecstring();
        public DataTable HienThi()
        {
            DataTable dt = new DataTable();
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "select * from KhenThuongPhat";
            Connecstring.SqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(query, Connecstring.Connection);

            Connecstring.SqlDataAdapter.Fill(dt);
            Connecstring.Connection.Close();

            return dt;
        }
        public DataTable HienThiTimKiem(string timkiem)
        {
            int thangnam=int.Parse(timkiem);
            DataTable dt = new DataTable();
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "select * from KhenThuongPhat where ThangNam= @TimKiem";
            Connecstring.SqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(query, Connecstring.Connection);
            Connecstring.SqlDataAdapter.SelectCommand.Parameters.AddWithValue("@TimKiem",  thangnam );
            Connecstring.SqlDataAdapter.Fill(dt);
            Connecstring.Connection.Close();
            return dt;
        }
        public void Them(KhenThuongPhat khenThuongPhat)
        {
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "Insert into KhenThuongPhat values(@MaKTP,@MaNhanVien,@Loai,@LyDo,@SoTien,@ThangNam)";
            Connecstring.SqlCommand = new System.Data.SqlClient.SqlCommand(query, Connecstring.Connection);
            SqlParameter sqlParameter1 = new SqlParameter("@MaKTP", khenThuongPhat.MaKTP);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter1);
            SqlParameter sqlParameter2 = new SqlParameter("@MaNhanVien", khenThuongPhat.MaNhanVien);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter2);
            SqlParameter sqlParameter3 = new SqlParameter("@Loai", khenThuongPhat.Loai);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter3);
            SqlParameter sqlParameter4 = new SqlParameter("@LyDo", khenThuongPhat.LyDo);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter4);
            SqlParameter sqlParameter5 = new SqlParameter("@SoTien", khenThuongPhat.SoTien);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter5);
            SqlParameter sqlParameter6 = new SqlParameter("@ThangNam", khenThuongPhat.ThangNam);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter6);
            Connecstring.SqlCommand.ExecuteNonQuery();
            Connecstring.Connection.Close();
        }
        public void Sua(KhenThuongPhat khenThuongPhat)
        {
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "Update KhenThuongPhat set MaNhanVien=@MaNhanVien,Loai=@Loai," +
                "LyDo=@LyDo,SoTien=@SoTien,ThangNam=@ThangNam where MaKTP=@MaKTP";
            Connecstring.SqlCommand = new System.Data.SqlClient.SqlCommand(query, Connecstring.Connection);
            SqlParameter sqlParameter1 = new SqlParameter("@MaKTP", khenThuongPhat.MaKTP);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter1);
            SqlParameter sqlParameter2 = new SqlParameter("@MaNhanVien", khenThuongPhat.MaNhanVien);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter2);
            SqlParameter sqlParameter3 = new SqlParameter("@Loai", khenThuongPhat.Loai);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter3);
            SqlParameter sqlParameter4 = new SqlParameter("@LyDo", khenThuongPhat.LyDo);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter4);
            SqlParameter sqlParameter5 = new SqlParameter("@SoTien", khenThuongPhat.SoTien);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter5);
            SqlParameter sqlParameter6 = new SqlParameter("@ThangNam", khenThuongPhat.ThangNam);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter6);
            Connecstring.SqlCommand.ExecuteNonQuery();
            Connecstring.Connection.Close();
        }
        public void Xoa(string maktp)
        {
            Connecstring.Connection = new System.Data.SqlClient.SqlConnection(Connecstring.str_Connect);
            Connecstring.Connection.Open();
            string query = "Delete from KhenThuongPhat where MaKTP=@MaKTP";
            Connecstring.SqlCommand = new System.Data.SqlClient.SqlCommand(query, Connecstring.Connection);
            SqlParameter sqlParameter1 = new SqlParameter("@MaKTP", maktp);
            Connecstring.SqlCommand.Parameters.Add(sqlParameter1);

            Connecstring.SqlCommand.ExecuteNonQuery();
            Connecstring.Connection.Close();
        }
        public bool KiemTraTrungMa(string maKTP)
        {
            bool tonTai = false;
            Connecstring.Connection = new SqlConnection(Connecstring.str_Connect);
            string query = "SELECT COUNT(*) FROM KhenThuongPhat WHERE MaKTP = @MaKTP";
            SqlCommand cmd = new SqlCommand(query, Connecstring.Connection);
            cmd.Parameters.AddWithValue("@MaKTP", maKTP);
            Connecstring.Connection.Open();
            int count = (int)cmd.ExecuteScalar();
            if (count > 0)
                tonTai = true;
            Connecstring.Connection.Close();
            return tonTai;
        }
    }
}
