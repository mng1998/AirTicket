using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MvcEfCore.Data;
using MvcEfCore.Models;
using MvcEfCore.ViewModels;

namespace MvcEfCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]

    [Route("admin/home")]

    public class AdminHomeController : Controller
    {
        //ApplicationDbContext db = null;
        
        //public List<LichChuyenBay> ListLichChuyenBay(int top)
        //{
        //    return db.LichChuyenBays.OrderByDescending(x => x.NgayGioBay).Take(top).ToList();
        //}

        public int giaChuyenBay = 0;
        private readonly ApplicationDbContext _context;
        public List<LichChuyenBayVM> chuyenBayVM;
        // GET: DatVe
        public AdminHomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            var ChuyenBay = _context.LichChuyenBays.ToList();
            chuyenBayVM = new List<LichChuyenBayVM>();
       
            foreach (var chuyenBay in ChuyenBay)
            {
                chuyenBayVM.Add(new LichChuyenBayVM()
                {
                    ChuyenBayID = chuyenBay.ChuyenBayID,
                    GiaVe = chuyenBay.GiaVe,
                    NgayGioBay = chuyenBay.NgayGioBay,
                    ThoiGianBay = chuyenBay.ThoiGianBay,
                });
            }
            return View(chuyenBayVM);
        }
        
    }
}