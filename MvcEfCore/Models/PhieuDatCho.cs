using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcEfCore.Models
{
    public class PhieuDatCho
    {
        public string PhieuDatChoID { get; set; }
        public double GiaTien { get; set; }


        public string HangID { get; set; }
        public HangVe HangVe { get; set; }

        public string KhachHangID { get; set; }
        public KhachHang KhachHang { get; set; }
        public string ChuyenBayID { get; set; }
        public LichChuyenBay LichChuyenBay { get; set; }
    }
}
