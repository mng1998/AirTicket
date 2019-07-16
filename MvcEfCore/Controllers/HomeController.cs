using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MvcEfCore.Data;
using MvcEfCore.Models;
using MvcEfCore.ViewModels;

namespace MvcEfCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public List<LichChuyenBayVM> chuyenBayVM;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(LichChuyenBay lichCB)
        {
            ViewData["ChuyenBayID"] = new SelectList(_context.LichChuyenBays, "ChuyenBayID", "ChuyenBayID", lichCB.ChuyenBayID);
            return View(lichCB);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
