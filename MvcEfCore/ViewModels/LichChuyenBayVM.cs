using MvcEfCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcEfCore.ViewModels
{
    public class LichChuyenBayVM
    {
        public string ChuyenBayID { get; set; }
        public DateTime NgayGioBay { get; set; }
        public int GiaVe { get; set; }

        public int ThoiGianBay { get; set; }
        public int BusinessClass { get; set; }
        public int EconomyClass { get; set; }
        public List<ChiTietTrungGian> ChiTietTrungGians { get; set; }

        //public int ThamSo { get; set; }
    }
}
