using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcEfCore.Data;
using MvcEfCore.Models;

namespace MvcEfCore.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/lichchuyenbays")]
    public class LichChuyenBaysController : Controller
    {
        private readonly ApplicationDbContext _context;
        
        public LichChuyenBaysController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: LichChuyenBays
       
        [Route("index")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.LichChuyenBays.ToListAsync());
        }

        // GET: LichChuyenBays/Details/5
        [Route("details")]
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lichChuyenBay = await _context.LichChuyenBays
                .FirstOrDefaultAsync(m => m.ChuyenBayID == id);
            if (lichChuyenBay == null)
            {
                return NotFound();
            }
            ViewBag.ChiTietChuyenBay = _context.ChiTietTrungGians
                .Where(p => p.ChuyenBayID == lichChuyenBay.ChuyenBayID).ToList();
            //var a = ViewBag.ChiTietChuyenBay;

            ViewBag.SanBayKhoiHanh = ViewBag.ChiTietChuyenBay[0].SanBayId;
            ViewBag.SanBayDen = ViewBag.ChiTietChuyenBay[ViewBag.ChiTietChuyenBay.Count - 1].SanBayDen;
            return View(lichChuyenBay);
        }

        // GET: LichChuyenBays/Create
        [Route("create")]
        public IActionResult Create()
        {
            //ViewBag.SanBayId = new SelectList(_context.SanBays, "SanBayId", "TenSanBay");
            if (_context.ThamSos.SingleOrDefault(p => p.Id == "TS2") != null)
                ViewBag.TS2 = _context.ThamSos.SingleOrDefault(p => p.Id == "TS2").GiaTri;
            else
                ViewBag.TS2 = 1;
            ViewBag.SanBayId = _context.SanBays;
            ViewBag.ChiTietTrungGian = new List<ChiTietTrungGian>();
            return View();
        }

        // POST: LichChuyenBays/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("create")]
        public async Task<IActionResult> Create(int?[] ThoiGianDung, string[] TramDung, string[] GhiChu, string SanBayDi, string SanBayDen, [Bind("ChuyenBayID,NgayGioBay,GiaVe,ThoiGianBay,BusinessClass,EconomyClass,DenId,KhoiHanhId")] LichChuyenBay lichChuyenBay)
        {
            if (ModelState.IsValid)
            {
                //string[] s = ChiTietTrungGian.Split(' ');
                //string s = ChiTietTrungGian;
                _context.Add(lichChuyenBay);
                await _context.SaveChangesAsync();
                int dem = 0;
                if (ThoiGianDung == null || ThoiGianDung[0] == null)
                {
                    _context.Add(new ChiTietTrungGian() { ChuyenBayID = lichChuyenBay.ChuyenBayID, ChiTietID = lichChuyenBay.ChuyenBayID + "01", SanBayId = SanBayDi, SanBayDen = SanBayDen, ThoiGian = null, GhiChu = "Bay Thẳng" });
                }
                else
                {
                    _context.Add(new ChiTietTrungGian() { ChuyenBayID = lichChuyenBay.ChuyenBayID, ChiTietID = lichChuyenBay.ChuyenBayID + "01", SanBayId = SanBayDi, SanBayDen = TramDung[0], ThoiGian = ThoiGianDung[0], GhiChu = GhiChu[0] });
                    for (int i = 1; i < ThoiGianDung.Length; i++)
                    {
                        if (ThoiGianDung[i] == null)
                        {
                            dem = i;
                            break;
                        }
                        _context.Add(new ChiTietTrungGian() { ChuyenBayID = lichChuyenBay.ChuyenBayID, ChiTietID = lichChuyenBay.ChuyenBayID + "0" + (i + 1), SanBayId = TramDung[i - 1], SanBayDen = TramDung[i], ThoiGian = ThoiGianDung[i], GhiChu = GhiChu[i] });

                    }
                    dem = ThoiGianDung.Length;
                    _context.Add(new ChiTietTrungGian()
                    {
                        ChuyenBayID = lichChuyenBay.ChuyenBayID,
                        ChiTietID = lichChuyenBay.ChuyenBayID + "0" + (dem + 2),
                        SanBayId = TramDung[dem - 1],
                        SanBayDen = SanBayDen,
                        ThoiGian = null,
                        GhiChu = "Đến nơi"
                    });
                }
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(lichChuyenBay);
        }

        // GET: LichChuyenBays/Edit/5
        [Route("edit")]
        public async Task<IActionResult> Edit(string id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var lichChuyenBay = await _context.LichChuyenBays.FindAsync(id);
            if (lichChuyenBay == null)
            {
                return NotFound();
            }
            var tam = _context.ThamSos.SingleOrDefault(p => p.Id == "TS1");
            if (tam != null)
            {
                ViewBag.TS1 = tam.GiaTri;
            }
            else ViewBag.TS1 = 0;
            return View(lichChuyenBay);
        }

        // POST: LichChuyenBays/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public async Task<IActionResult> Edit(string ChuyenBayID, [Bind("ChuyenBayID,NgayGioBay,GiaVe,ThoiGianBay,BusinessClass,EconomyClass,DenId,KhoiHanhId")] LichChuyenBay lichChuyenBay)
        {
            if (ChuyenBayID != lichChuyenBay.ChuyenBayID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lichChuyenBay);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LichChuyenBayExists(lichChuyenBay.ChuyenBayID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(lichChuyenBay);
        }

        // GET: LichChuyenBays/Delete/5
        [Route("delete")]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lichChuyenBay = await _context.LichChuyenBays
                .FirstOrDefaultAsync(m => m.ChuyenBayID == id);
            if (lichChuyenBay == null)
            {
                return NotFound();
            }

            return View(lichChuyenBay);
        }

        // POST: LichChuyenBays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Route("delete")]
        public async Task<IActionResult> DeleteConfirmed(string ChuyenBayID)
        {
            var lichChuyenBay = await _context.LichChuyenBays.FindAsync(ChuyenBayID);
            _context.LichChuyenBays.Remove(lichChuyenBay);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LichChuyenBayExists(string id)
        {
            return _context.LichChuyenBays.Any(e => e.ChuyenBayID == id);
        }
        [Route("editdetail")]
        public async Task<IActionResult> EditDetail(string id)
        {
            ViewData["ChuyenBayID"] = new SelectList(_context.LichChuyenBays, "ChuyenBayID", "ChuyenBayID");
            ViewData["SanBayId"] = new SelectList(_context.SanBays, "SanBayId", "SanBayId");
            if (id == null)
            {
                return NotFound();
            }

            var chiTietTrungGian = await _context.ChiTietTrungGians.FindAsync(id);
            if (chiTietTrungGian == null)
            {
                return NotFound();
            }

            return View(chiTietTrungGian);
        }

        // POST: LichChuyenBays/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("editdetail")]
        public async Task<IActionResult> EditDetail(string ChiTietID, [Bind("ChiTietID,ThoiGian,GhiChu,SanBayDen,SanBayId,ChuyenBayID")] ChiTietTrungGian chiTietTrungGian)
        {
            if (ChiTietID != chiTietTrungGian.ChiTietID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chiTietTrungGian);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LichChuyenBayExists(chiTietTrungGian.ChiTietID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                var a = chiTietTrungGian.ChuyenBayID;
                return RedirectToAction(nameof(Index));
            }
            return View(chiTietTrungGian);
        }
    }
}
