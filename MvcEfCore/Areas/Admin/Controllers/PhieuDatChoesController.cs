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
    [Route("admin/phieudatchoes")]
    public class PhieuDatChoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PhieuDatChoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/PhieuDatChoes
        [Route("index")]
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.PhieuDatChos.Include(p => p.HangVe).Include(p => p.KhachHang).Include(p => p.LichChuyenBay);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admin/PhieuDatChoes/Details/5
        [Route("details")]
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phieuDatCho = await _context.PhieuDatChos
                .Include(p => p.HangVe)
                .Include(p => p.KhachHang)
                .Include(p => p.LichChuyenBay)
                .FirstOrDefaultAsync(m => m.PhieuDatChoID == id);
            if (phieuDatCho == null)
            {
                return NotFound();
            }

            return View(phieuDatCho);
        }

        // GET: Admin/PhieuDatChoes/Create
        [Route("create")]
        public IActionResult Create()
        {
            ViewData["HangID"] = new SelectList(_context.HangVes, "HangID", "HangID");
            ViewData["KhachHangID"] = new SelectList(_context.KhachHangs, "KhachHangID", "KhachHangID");
            ViewData["ChuyenBayID"] = new SelectList(_context.LichChuyenBays, "ChuyenBayID", "ChuyenBayID");
            return View();
        }

        // POST: Admin/PhieuDatChoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("create")]
        public async Task<IActionResult> Create([Bind("PhieuDatChoID,GiaTien,HangID,KhachHangID,ChuyenBayID")] PhieuDatCho phieuDatCho)
        {
            if (ModelState.IsValid)
            {
                _context.Add(phieuDatCho);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["HangID"] = new SelectList(_context.HangVes, "HangID", "HangID", phieuDatCho.HangID);
            ViewData["KhachHangID"] = new SelectList(_context.KhachHangs, "KhachHangID", "KhachHangID", phieuDatCho.KhachHangID);
            ViewData["ChuyenBayID"] = new SelectList(_context.LichChuyenBays, "ChuyenBayID", "ChuyenBayID", phieuDatCho.ChuyenBayID);
            return View(phieuDatCho);
        }

        // GET: Admin/PhieuDatChoes/Edit/5
        [Route("edit")]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phieuDatCho = await _context.PhieuDatChos.FindAsync(id);
            if (phieuDatCho == null)
            {
                return NotFound();
            }
            ViewData["HangID"] = new SelectList(_context.HangVes, "HangID", "HangID", phieuDatCho.HangID);
            ViewData["KhachHangID"] = new SelectList(_context.KhachHangs, "KhachHangID", "KhachHangID", phieuDatCho.KhachHangID);
            ViewData["ChuyenBayID"] = new SelectList(_context.LichChuyenBays, "ChuyenBayID", "ChuyenBayID", phieuDatCho.ChuyenBayID);
            return View(phieuDatCho);
        }

        // POST: Admin/PhieuDatChoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("edit")]
        public async Task<IActionResult> Edit(string PhieuDatChoID, [Bind("PhieuDatChoID,GiaTien,HangID,KhachHangID,ChuyenBayID")] PhieuDatCho phieuDatCho)
        {
            if (PhieuDatChoID != phieuDatCho.PhieuDatChoID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(phieuDatCho);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhieuDatChoExists(phieuDatCho.PhieuDatChoID))
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
            ViewData["HangID"] = new SelectList(_context.HangVes, "HangID", "HangID", phieuDatCho.HangID);
            ViewData["KhachHangID"] = new SelectList(_context.KhachHangs, "KhachHangID", "KhachHangID", phieuDatCho.KhachHangID);
            ViewData["ChuyenBayID"] = new SelectList(_context.LichChuyenBays, "ChuyenBayID", "ChuyenBayID", phieuDatCho.ChuyenBayID);
            return View(phieuDatCho);
        }

        // GET: Admin/PhieuDatChoes/Delete/5
        [Route("delete")]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phieuDatCho = await _context.PhieuDatChos
                .Include(p => p.HangVe)
                .Include(p => p.KhachHang)
                .Include(p => p.LichChuyenBay)
                .FirstOrDefaultAsync(m => m.PhieuDatChoID == id);
            if (phieuDatCho == null)
            {
                return NotFound();
            }

            return View(phieuDatCho);
        }

        // POST: Admin/PhieuDatChoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Route("delete")]
        public async Task<IActionResult> DeleteConfirmed(string PhieuDatChoID)
        {
            var phieuDatCho = await _context.PhieuDatChos.FindAsync(PhieuDatChoID);
            _context.PhieuDatChos.Remove(phieuDatCho);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhieuDatChoExists(string id)
        {
            return _context.PhieuDatChos.Any(e => e.PhieuDatChoID == id);
        }
    }
}
