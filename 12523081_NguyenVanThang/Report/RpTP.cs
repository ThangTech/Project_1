using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace _12523081_NguyenVanThang.Report
{
    public partial class RpTP : DevExpress.XtraReports.UI.XtraReport
    {
        public RpTP()
        {
            InitializeComponent();
        }
        public void DataBind()
        {
            xrLabelSTT.DataBindings.Add("Text", DataSource, "STT");
            xrLabelMaKTP.DataBindings.Add("Text", DataSource, "MaKTP");
            xrLabelLoai.DataBindings.Add("Text", DataSource, "Loai");
            xrLabelLyDo.DataBindings.Add("Text", DataSource, "LyDo");
            xrLabelSoTien.DataBindings.Add("Text", DataSource, "SoTien");
            xrLabelThangnam.DataBindings.Add("Text", DataSource, "ThangNam");
            xrLabelThang.Text = DateTime.Now.Month.ToString();
            xrLabelNgay.Text = DateTime.Now.Day.ToString();
            xrLabelNam.Text = DateTime.Now.Year.ToString();
        }

    }
}
