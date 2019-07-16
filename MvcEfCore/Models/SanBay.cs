using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcEfCore.Models
{
    public class SanBay
    {
        [Key]
        [MaxLength(6)]
        public string SanBayId { get; set; }
        [Required(ErrorMessage = "Name not null")]
        
        public string TenSanBay { get; set; }

        public string ThanhPho { get; set; }
        public List<ChiTietTrungGian> ChiTietTrungGians { get; set; }
    }
}
