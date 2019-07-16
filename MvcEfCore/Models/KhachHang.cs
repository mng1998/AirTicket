using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcEfCore.Models
{
    public class KhachHang
    {
        [Key]
        [MaxLength(30)]
        public string KhachHangID { get; set; }
        public string TenKhachHang { get; set; }
        public string DiaChi { get; set; }
        public string CMND { get; set; }
        public string SDT { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public List<PhieuDatCho> PhieuDatChos { get; set; }
        public List<PhieuDatVe> PhieuDatVes { get; set; }
    }
}
