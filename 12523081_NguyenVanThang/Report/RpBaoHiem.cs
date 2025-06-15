using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace _12523081_NguyenVanThang.Report
{
    public partial class RpBaoHiem : DevExpress.XtraReports.UI.XtraReport
    {
        public RpBaoHiem()
        {
            InitializeComponent();
        }
        public void DataBind()
        {
            xrLabelSTT.DataBindings.Add("Text", DataSource, "STT");
            xrLabelMaBH.DataBindings.Add("Text", DataSource, "MaBaoHiem");
            xrLabelLBH.DataBindings.Add("Text", DataSource, "LoaiBaoHiem");
            xrLabelNgayCap.DataBindings.Add("Text", DataSource, "NgayCap").FormatString = ("{0:dd/MM/yyyy}");
            xrLabelNoiCap.DataBindings.Add("Text", DataSource, "NoiCap");
            xrLabelThang.Text = DateTime.Now.Month.ToString();
            xrLabelNgay.Text = DateTime.Now.Day.ToString();
            xrLabelNam.Text = DateTime.Now.Year.ToString();
        }
    }
}
