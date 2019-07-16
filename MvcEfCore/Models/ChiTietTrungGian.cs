using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcEfCore.Models
{
    public class ChiTietTrungGian
    {
        [Key]
        [MaxLength (10)]
        public string ChiTietID { get; set; }
        public int? ThoiGian { get; set; }
        public string GhiChu { get; set; }
        public string SanBayDen { get; set; }

        public string SanBayId { get; set; }
        public SanBay SanBay { get; set; }
        public string ChuyenBayID { get; set; }
        public LichChuyenBay LichChuyenBay { get; set; }
    }
}
