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
    [Area("Admin")]
    [Route("admin/chitiettrunggians")]
    public class ChiTietTrungGiansController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ChiTietTrungGiansController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/ChiTietTrungGians
        [Route("index")]
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ChiTietTrungGians.Include(c => c.LichChuyenBay).Include(c => c.SanBay);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admin/ChiTietTrungGians/Details/5
        [Route("details")]
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietTrungGian = await _context.ChiTietTrungGians
                .Include(c => c.LichChuyenBay)
                .Include(c => c.SanBay)
                .FirstOrDefaultAsync(m => m.ChiTietID == id);
            if (chiTietTrungGian == null)
            {
                return NotFound();
            }

            return View(chiTietTrungGian);
        }

        // GET: Admin/ChiTietTrungGians/Create
        [Route("create")]
        public IActionResult Create()
        {
            ViewData["ChuyenBayID"] = new SelectList(_context.LichChuyenBays, "ChuyenBayID", "ChuyenBayID");
            ViewData["SanBayId"] = new SelectList(_context.SanBays, "SanBayId", "SanBayId");
            return View();
        }

        // POST: Admin/ChiTietTrungGians/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("create")]
        public async Task<IActionResult> Create([Bind("ChiTietID,ThoiGian,GhiChu,SanBayDen,SanBayId,ChuyenBayID")] ChiTietTrungGian chiTietTrungGian)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chiTietTrungGian);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ChuyenBayID"] = new SelectList(_context.LichChuyenBays, "ChuyenBayID", "ChuyenBayID", chiTietTrungGian.ChuyenBayID);
            ViewData["SanBayId"] = new SelectList(_context.SanBays, "SanBayId", "SanBayId", chiTietTrungGian.SanBayId);
            return View(chiTietTrungGian);
        }

        // GET: Admin/ChiTietTrungGians/Edit/5
        [Route("edit")]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietTrungGian = await _context.ChiTietTrungGians.FindAsync(id);
            if (chiTietTrungGian == null)
            {
                return NotFound();
            }
            ViewData["ChuyenBayID"] = new SelectList(_context.LichChuyenBays, "ChuyenBayID", "ChuyenBayID", chiTietTrungGian.ChuyenBayID);
            ViewData["SanBayId"] = new SelectList(_context.SanBays, "SanBayId", "SanBayId", chiTietTrungGian.SanBayId);
            return View(chiTietTrungGian);
        }

        // POST: Admin/ChiTietTrungGians/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("edit")]
        public async Task<IActionResult> Edit(string ChiTietID, [Bind("ChiTietID,ThoiGian,GhiChu,SanBayDen,SanBayId,ChuyenBayID")] ChiTietTrungGian chiTietTrungGian)
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
                    if (!ChiTietTrungGianExists(chiTietTrungGian.ChiTietID))
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
            ViewData["ChuyenBayID"] = new SelectList(_context.LichChuyenBays, "ChuyenBayID", "ChuyenBayID", chiTietTrungGian.ChuyenBayID);
            ViewData["SanBayId"] = new SelectList(_context.SanBays, "SanBayId", "SanBayId", chiTietTrungGian.SanBayId);
            return View(chiTietTrungGian);
        }

        // GET: Admin/ChiTietTrungGians/Delete/5
        [Route("delete")]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietTrungGian = await _context.ChiTietTrungGians
                .Include(c => c.LichChuyenBay)
                .Include(c => c.SanBay)
                .FirstOrDefaultAsync(m => m.ChiTietID == id);
            if (chiTietTrungGian == null)
            {
                return NotFound();
            }

            return View(chiTietTrungGian);
        }

        // POST: Admin/ChiTietTrungGians/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Route("delete")]
        public async Task<IActionResult> DeleteConfirmed(string ChiTietID)
        {
            var chiTietTrungGian = await _context.ChiTietTrungGians.FindAsync(ChiTietID);
            _context.ChiTietTrungGians.Remove(chiTietTrungGian);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChiTietTrungGianExists(string id)
        {
            return _context.ChiTietTrungGians.Any(e => e.ChiTietID == id);
        }
    }
}
