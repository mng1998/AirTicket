using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcEfCore.Models
{
    public class HangVe
    {
        [Key]
        [MaxLength(5)]
        public string HangID { get; set; }
        public string TenHang { get; set; }
        public int TiLeGia { get; set; }
        public List<PhieuDatCho> PhieuDatChos { get; set; }
        public List<PhieuDatVe> PhieuDatVes { get; set; }
    }
}
