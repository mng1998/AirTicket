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
    [Route("admin/thamsoes")]
    public class ThamSoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ThamSoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/ThamSoes
        [Route("index")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.ThamSos.ToListAsync());
        }

        // GET: Admin/ThamSoes/Details/5
        [Route("details")]
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thamSo = await _context.ThamSos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (thamSo == null)
            {
                return NotFound();
            }

            return View(thamSo);
        }

        // GET: Admin/ThamSoes/Create
        [Route("create")]

        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/ThamSoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("create")]
        public async Task<IActionResult> Create([Bind("Id,GiaTri,GhiChu")] ThamSo thamSo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(thamSo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(thamSo);
        }

        // GET: Admin/ThamSoes/Edit/5
        [Route("edit")]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thamSo = await _context.ThamSos.FindAsync(id);
            if (thamSo == null)
            {
                return NotFound();
            }
            return View(thamSo);
        }

        // POST: Admin/ThamSoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("edit")]
        public async Task<IActionResult> Edit(string id, [Bind("Id,GiaTri,GhiChu")] ThamSo thamSo)
        {
            if (id != thamSo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(thamSo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ThamSoExists(thamSo.Id))
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
            return View(thamSo);
        }

        // GET: Admin/ThamSoes/Delete/5
        [Route("delete")]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thamSo = await _context.ThamSos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (thamSo == null)
            {
                return NotFound();
            }

            return View(thamSo);
        }

        // POST: Admin/ThamSoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Route("delete")]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var thamSo = await _context.ThamSos.FindAsync(id);
            _context.ThamSos.Remove(thamSo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ThamSoExists(string id)
        {
            return _context.ThamSos.Any(e => e.Id == id);
        }
    }
}
