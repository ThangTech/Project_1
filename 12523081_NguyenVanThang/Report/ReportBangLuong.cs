using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraReports.UI;

namespace _12523081_NguyenVanThang.Report
{
    public partial class ReportBangLuong : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportBangLuong()
        {
            InitializeComponent();
        }
        DateTime DateTime =new DateTime();
        public void DataBind()
        {
            xrLabelSTT.DataBindings.Add("Text", DataSource, "STT");
            xrLabelTenPhong.DataBindings.Add("Text", DataSource, "TenPhongBan");
            xrLabelKhongCong.DataBindings.Add("Text", DataSource, "KhongCong");
            xrLabelHoVaTen.DataBindings.Add("Text", DataSource, "TenNhanVien");
            xrLabelTongLuong.DataBindings.Add("Text", DataSource, "TongLuong");
            xrLabelLuongCoBan.DataBindings.Add("Text", DataSource, "LuongCoBan");
            xrLabelSoNgayLam.DataBindings.Add("Text", DataSource, "SoNgayLam");
            xrLabelThangNam.DataBindings.Add("Text", DataSource, "ThangNam");
            xrLabelThang.Text = DateTime.Now.Month.ToString();
            xrLabelNgay.Text = DateTime.Now.Day.ToString();
            xrLabelNam.Text= DateTime.Now.Year.ToString();
        }
    }
}
