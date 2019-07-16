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
    [Route("admin/phieudatves")]
    public class PhieuDatVesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PhieuDatVesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/PhieuDatVes
        [Route("index")]
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.PhieuDatVes.Include(p => p.HangVe).Include(p => p.KhachHang).Include(p => p.LichChuyenBay);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admin/PhieuDatVes/Details/5
        [Route("details")]
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

        // GET: Admin/PhieuDatVes/Create
        [Route("create")]
        public IActionResult Create()
        {
            ViewData["HangID"] = new SelectList(_context.HangVes, "HangID", "HangID");
            ViewData["KhachHangID"] = new SelectList(_context.KhachHangs, "KhachHangID", "KhachHangID");
            ViewData["ChuyenBayID"] = new SelectList(_context.LichChuyenBays, "ChuyenBayID", "ChuyenBayID");
            return View();
        }

        // POST: Admin/PhieuDatVes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("create")]
        public async Task<IActionResult> Create([Bind("PhieuDatVeID,GiaTien,HangID,KhachHangID,ChuyenBayID")] PhieuDatVe phieuDatVe)
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

        // GET: Admin/PhieuDatVes/Edit/5
        [Route("edit")]
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

        // POST: Admin/PhieuDatVes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("edit")]
        public async Task<IActionResult> Edit(string PhieuDatVeID, [Bind("PhieuDatVeID,GiaTien,HangID,KhachHangID,ChuyenBayID")] PhieuDatVe phieuDatVe)
        {
            if (PhieuDatVeID != phieuDatVe.PhieuDatVeID)
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
                return RedirectToAction(nameof(Index));
            }
            ViewData["HangID"] = new SelectList(_context.HangVes, "HangID", "HangID", phieuDatVe.HangID);
            ViewData["KhachHangID"] = new SelectList(_context.KhachHangs, "KhachHangID", "KhachHangID", phieuDatVe.KhachHangID);
            ViewData["ChuyenBayID"] = new SelectList(_context.LichChuyenBays, "ChuyenBayID", "ChuyenBayID", phieuDatVe.ChuyenBayID);
            return View(phieuDatVe);
        }

        // GET: Admin/PhieuDatVes/Delete/5
        [Route("delete")]
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

        // POST: Admin/PhieuDatVes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Route("delete")]
        public async Task<IActionResult> DeleteConfirmed(string PhieuDatVeID)
        {
            var phieuDatVe = await _context.PhieuDatVes.FindAsync(PhieuDatVeID);
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
