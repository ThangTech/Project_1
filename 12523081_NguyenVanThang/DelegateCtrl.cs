using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12523081_NguyenVanThang
{
    public delegate void DelegateMaNV(object sender, DelegateCtrl e);
    public class DelegateCtrl: EventArgs

    {
      
      public string manv { get; set; }
        public string tennv { get; set; }

    }
}
