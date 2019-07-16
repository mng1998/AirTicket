using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcEfCore.Models
{
    public class PhieuDatVe
    {
        public string PhieuDatVeID { get; set; }
        public int GiaTien { get; set; }
       

        public string HangID { get; set; }
        public HangVe HangVe { get; set; }

        public string KhachHangID { get; set; }
        public KhachHang KhachHang { get; set; }
        public string ChuyenBayID { get; set; }
        public bool TrangThai { get; set; }
        public LichChuyenBay LichChuyenBay { get; set; }
    }
}
