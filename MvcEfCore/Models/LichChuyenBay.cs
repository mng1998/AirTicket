using MvcEfCore.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MvcEfCore.Models
{
    public class LichChuyenBay
    {
        [Key]
        [MaxLength(10)]
        public string ChuyenBayID { get; set; }
        public DateTime NgayGioBay { get; set; }
        public int GiaVe { get; set; }
        public string KhoiHanhId  { get; set; }
        public string DenId { get; set; }
        public int ThoiGianBay { get; set; }
        public int BusinessClass { get; set; }
        public int EconomyClass { get; set; }
        public bool Trangthai { get; set; }
        //public int ThamSo { get; set; }
        public List<PhieuDatCho> PhieuDatChos { get; set; }
        public List<PhieuDatVe> PhieuDatVes { get; set; }
        public List<ChiTietTrungGian> ChiTietTrungGians { get; set; }
    }
    
}
