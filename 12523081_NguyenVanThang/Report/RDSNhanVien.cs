using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraReports.UI;

namespace _12523081_NguyenVanThang.Report
{
    public partial class RDSNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public RDSNhanVien()
        {
            InitializeComponent();
        }
        public void DataBind()
        {
            xrLabelSTT.DataBindings.Add("Text",DataSource,"STT");
            xrLabelTenPhong.DataBindings.Add("Text", DataSource, "TenPhongBan");
            xrLabelMaNV.DataBindings.Add("Text", DataSource, "MaNhanVien");
            xrLabelHoVaTen.DataBindings.Add("Text", DataSource, "TenNhanVien");
            xrLabelGioiTinh.DataBindings.Add("Text", DataSource, "GioiTinh");
            xrLabelNgaySinh.DataBindings.Add("Text", DataSource, "NgaySinh").FormatString=("{0:dd/MM/yyyy}");
            xrLabelDiaChi.DataBindings.Add("Text", DataSource, "DiaChi");
            xrLabelThang.Text = DateTime.Now.Month.ToString();
            xrLabelNgay.Text = DateTime.Now.Day.ToString();
            xrLabelNam.Text = DateTime.Now.Year.ToString();
        }
    }
}
