using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcEfCore.Data;
using MvcEfCore.Models;

namespace MvcEfCore.Controllers
{
    public class PhieuDatVesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PhieuDatVesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PhieuDatVes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.PhieuDatVes.Include(p => p.HangVe).Include(p => p.KhachHang).Include(p => p.LichChuyenBay);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: PhieuDatVes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phieuDatVe = await _context.PhieuDatVes
                .Include(p => p.HangVe)
                .Include(p => p.KhachHang)
                .Include(p => p.LichChuyenBay)
                .FirstOrDefaultAsync(m => m.PhieuDatVeID == id);
            if (phieuDatVe == null)
            {
                return NotFound();
            }

            return View(phieuDatVe);
        }

        // GET: PhieuDatVes/Create
        public IActionResult Create()
        {
            ViewData["HangID"] = new SelectList(_context.HangVes, "HangID", "HangID");
            ViewData["KhachHangID"] = new SelectList(_context.KhachHangs, "KhachHangID", "KhachHangID");
            ViewData["ChuyenBayID"] = new SelectList(_context.LichChuyenBays, "ChuyenBayID", "ChuyenBayID");
            return View();
        }

        // POST: PhieuDatVes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PhieuDatVeID,GiaTien,HangID,KhachHangID,ChuyenBayID,TrangThai")] PhieuDatVe phieuDatVe)
        {
            if (ModelState.IsValid)
            {
                _context.Add(phieuDatVe);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["HangID"] = new SelectList(_context.HangVes, "HangID", "HangID", phieuDatVe.HangID);
            ViewData["KhachHangID"] = new SelectList(_context.KhachHangs, "KhachHangID", "KhachHangID", phieuDatVe.KhachHangID);
            ViewData["ChuyenBayID"] = new SelectList(_context.LichChuyenBays, "ChuyenBayID", "ChuyenBayID", phieuDatVe.ChuyenBayID);
            return View(phieuDatVe);
        }

        // GET: PhieuDatVes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phieuDatVe = await _context.PhieuDatVes.FindAsync(id);
            if (phieuDatVe == null)
            {
                return NotFound();
            }
            ViewData["HangID"] = new SelectList(_context.HangVes, "HangID", "HangID", phieuDatVe.HangID);
            ViewData["KhachHangID"] = new SelectList(_context.KhachHangs, "KhachHangID", "KhachHangID", phieuDatVe.KhachHangID);
            ViewData["ChuyenBayID"] = new SelectList(_context.LichChuyenBays, "ChuyenBayID", "ChuyenBayID", phieuDatVe.ChuyenBayID);
            return View(phieuDatVe);
        }

        // POST: PhieuDatVes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PhieuDatVeID,GiaTien,HangID,KhachHangID,ChuyenBayID,TrangThai")] PhieuDatVe phieuDatVe)
        {
            if (id != phieuDatVe.PhieuDatVeID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(phieuDatVe);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhieuDatVeExists(phieuDatVe.PhieuDatVeID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Edit));
            }
            ViewData["HangID"] = new SelectList(_context.HangVes, "HangID", "HangID", phieuDatVe.HangID);
            ViewData["KhachHangID"] = new SelectList(_context.KhachHangs, "KhachHangID", "KhachHangID", phieuDatVe.KhachHangID);
            ViewData["TenKhachHang"] = new SelectList(_context.KhachHangs, "TenKhachHang", "TenKhachHang", phieuDatVe.KhachHang.TenKhachHang);
            ViewData["CMND"] = new SelectList(_context.KhachHangs, "CMND", "CMND", phieuDatVe.KhachHang.CMND);
            ViewData["SDT"] = new SelectList(_context.KhachHangs, "SDT", "SDT", phieuDatVe.KhachHang.SDT);
            ViewData["KhachHangID"] = new SelectList(_context.KhachHangs, "KhachHangID", "KhachHangID", phieuDatVe.KhachHangID);
            ViewData["ChuyenBayID"] = new SelectList(_context.LichChuyenBays, "ChuyenBayID", "ChuyenBayID", phieuDatVe.ChuyenBayID);
            return View(phieuDatVe);
        }

        // GET: PhieuDatVes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phieuDatVe = await _context.PhieuDatVes
                .Include(p => p.HangVe)
                .Include(p => p.KhachHang)
                .Include(p => p.LichChuyenBay)
                .FirstOrDefaultAsync(m => m.PhieuDatVeID == id);
            if (phieuDatVe == null)
            {
                return NotFound();
            }

            return View(phieuDatVe);
        }

        // POST: PhieuDatVes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var phieuDatVe = await _context.PhieuDatVes.FindAsync(id);
            _context.PhieuDatVes.Remove(phieuDatVe);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhieuDatVeExists(string id)
        {
            return _context.PhieuDatVes.Any(e => e.PhieuDatVeID == id);
        }
    }
}
