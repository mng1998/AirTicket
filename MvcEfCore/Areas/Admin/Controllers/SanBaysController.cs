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
    [Route("admin/sanbays")]
    public class SanBaysController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SanBaysController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SanBays
        [Route("index")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.SanBays.ToListAsync());
        }

        // GET: SanBays/Details/5
        [Route("details")]
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanBay = await _context.SanBays
                .FirstOrDefaultAsync(m => m.SanBayId == id);
            if (sanBay == null)
            {
                return NotFound();
            }

            return View(sanBay);
        }

        // GET: SanBays/Create
        [Route("create")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: SanBays/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("create")]
        public async Task<IActionResult> Create([Bind("SanBayId,TenSanBay")] SanBay sanBay)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sanBay);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sanBay);
        }

        // GET: SanBays/Edit/5
        [Route("edit")]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanBay = await _context.SanBays.FindAsync(id);
            if (sanBay == null)
            {
                return NotFound();
            }
            return View(sanBay);
        }

        // POST: SanBays/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("edit")]
        public async Task<IActionResult> Edit(string SanBayId, [Bind("SanBayId,TenSanBay")] SanBay sanBay)
        {
            if (SanBayId != sanBay.SanBayId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sanBay);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SanBayExists(sanBay.SanBayId))
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
            return View(sanBay);
        }

        // GET: SanBays/Delete/5
        [Route("delete")]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanBay = await _context.SanBays
                .FirstOrDefaultAsync(m => m.SanBayId == id);
            if (sanBay == null)
            {
                return NotFound();
            }

            return View(sanBay);
        }

        // POST: SanBays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Route("delete")]
        public async Task<IActionResult> DeleteConfirmed(string SanBayId)
        {
            var sanBay = await _context.SanBays.FindAsync(SanBayId);
            _context.SanBays.Remove(sanBay);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SanBayExists(string id)
        {
            return _context.SanBays.Any(e => e.SanBayId == id);
        }
    }
}