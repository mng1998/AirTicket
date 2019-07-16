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
    [Route("admin/hangves")]
    public class HangVesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HangVesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/HangVes
        [Route("index")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.HangVes.ToListAsync());
        }

        // GET: Admin/HangVes/Details/5
        [Route("details")]
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hangVe = await _context.HangVes
                .FirstOrDefaultAsync(m => m.HangID == id);
            if (hangVe == null)
            {
                return NotFound();
            }

            return View(hangVe);
        }

        // GET: Admin/HangVes/Create
        [Route("create")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/HangVes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("create")]
        public async Task<IActionResult> Create([Bind("HangID,TenHang,TiLeGia")] HangVe hangVe)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hangVe);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hangVe);
        }

        // GET: Admin/HangVes/Edit/5
        [Route("edit")]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hangVe = await _context.HangVes.FindAsync(id);
            if (hangVe == null)
            {
                return NotFound();
            }
            return View(hangVe);
        }

        // POST: Admin/HangVes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("edit")]
        public async Task<IActionResult> Edit(string HangID, [Bind("HangID,TenHang,TiLeGia")] HangVe hangVe)
        {
            if (HangID != hangVe.HangID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hangVe);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HangVeExists(hangVe.HangID))
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
            return View(hangVe);
        }

        // GET: Admin/HangVes/Delete/5
        [Route("delete")]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hangVe = await _context.HangVes
                .FirstOrDefaultAsync(m => m.HangID == id);
            if (hangVe == null)
            {
                return NotFound();
            }

            return View(hangVe);
        }

        // POST: Admin/HangVes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Route("delete")]
        public async Task<IActionResult> DeleteConfirmed(string HangID)
        {
            var hangVe = await _context.HangVes.FindAsync(HangID);
            _context.HangVes.Remove(hangVe);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HangVeExists(string id)
        {
            return _context.HangVes.Any(e => e.HangID == id);
        }
    }
}
