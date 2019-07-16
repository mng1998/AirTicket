using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcEfCore.Data;
using MvcEfCore.Models;
using MvcEfCore.ViewModels;
using Newtonsoft.Json;

namespace MvcEfCore.Controllers
{
    
    
    public class DatVeController : Controller
    {
        
        public int giaChuyenBay = 0;
        private readonly ApplicationDbContext _context;
        public List<LichChuyenBayVM> chuyenBayVM;
        // GET: DatVe
        public DatVeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var ChuyenBay = _context.LichChuyenBays.ToList();
            chuyenBayVM = new List<LichChuyenBayVM>();
            int dem = 0;
            foreach (var chuyenBay in ChuyenBay)
            {
                chuyenBayVM.Add(new LichChuyenBayVM()
                {
                    ChuyenBayID = chuyenBay.ChuyenBayID,
                    GiaVe = chuyenBay.GiaVe,
                    NgayGioBay = chuyenBay.NgayGioBay,
                    ThoiGianBay = chuyenBay.ThoiGianBay,
                });

                var ghe01 = _context.PhieuDatVes.Where(p => p.ChuyenBayID == chuyenBay.ChuyenBayID && p.HangID == "HA01");
                if ((ghe01 == null || ghe01.Count() == 0) && chuyenBayVM[dem].BusinessClass == 0)
                {
                    chuyenBayVM[dem].BusinessClass = chuyenBay.BusinessClass;
                }
                else chuyenBayVM[dem].BusinessClass = chuyenBay.BusinessClass - ghe01.Count();

                var ghe02 = _context.PhieuDatVes.Where(p => p.ChuyenBayID == chuyenBay.ChuyenBayID && p.HangID == "HA02");
                if ((ghe02 == null || ghe02.Count() == 0) && chuyenBayVM[dem].BusinessClass == 0)
                {
                    chuyenBayVM[dem].EconomyClass = chuyenBay.EconomyClass;
                }
                else chuyenBayVM[dem].EconomyClass = chuyenBay.EconomyClass - ghe02.Count();

                var datCho01 = _context.PhieuDatChos.Where(p => p.ChuyenBayID == chuyenBay.ChuyenBayID && p.HangID == "HA01");
                if ((datCho01 == null || datCho01.Count() == 0) &&  chuyenBayVM[dem].BusinessClass == 0)
                {
                    chuyenBayVM[dem].EconomyClass = chuyenBay.BusinessClass;
                }
                else chuyenBayVM[dem].EconomyClass = chuyenBayVM[dem].BusinessClass - datCho01.Count();

                var datCho02 = _context.PhieuDatChos.Where(p => p.ChuyenBayID == chuyenBay.ChuyenBayID && p.HangID == "HA02");
                if (datCho02 == null || datCho02.Count() == 0)
                {
                    //chuyenBayVM[dem].SoGheHang2 = chuyenBay.SoGheHang2;
                }
                else chuyenBayVM[dem].EconomyClass = chuyenBayVM[dem].EconomyClass - datCho02.Count();
                dem++;
            }
            return View(chuyenBayVM);
        }

        // GET: DatVe/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DatVe/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DatVe/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DatVe/Delete/5
        public IActionResult Delete(int id)
        {

            return View();
        }
        public async Task<IActionResult> Create(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lichChuyenBays = await _context.LichChuyenBays.FindAsync(id);
            if (lichChuyenBays == null)
            {
                return NotFound();
            }

            ViewBag.IdChuyenBay = id;
            giaChuyenBay = lichChuyenBays.GiaVe;
            ViewBag.GiaVe = lichChuyenBays.GiaVe;
            ViewBag.HangVe = _context.HangVes.ToList();
            ViewBag.GiaVeHang01 = _context.HangVes.Where(p => p.HangID == "HA01").SingleOrDefault().TiLeGia * lichChuyenBays.GiaVe / 100 + lichChuyenBays.GiaVe;

            ViewData["HangID"] = new SelectList(_context.HangVes, "HangID", "HangID");
            ViewData["KhachHangID"] = new SelectList(_context.KhachHangs, "KhachHangID", "KhachHangID");
            //ViewData["ChuyenBayID"] = new SelectList(_context.LichChuyenBays, "ChuyenBayID", "ChuyenBayID");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>
                            Create(
                            [Bind("PhieuDatVeID,KhachHangId,HangID,ChuyenBayID")] PhieuDatVe phieuDatVe,
                            KhachHang KhachHang)
        {
            if (ModelState.IsValid)
            {
                KhachHang.KhachHangID = phieuDatVe.ChuyenBayID + KhachHang.CMND;
                _context.Add(KhachHang);
                await _context.SaveChangesAsync();
                var x = _context.LichChuyenBays.SingleOrDefault(p => p.ChuyenBayID == phieuDatVe.ChuyenBayID).GiaVe;
                phieuDatVe.KhachHangID = phieuDatVe.ChuyenBayID + KhachHang.CMND;
                phieuDatVe.GiaTien = _context.HangVes.SingleOrDefault(p => p.HangID == phieuDatVe.HangID).TiLeGia * x / 100 + x;
                _context.Add(phieuDatVe);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["HangID"] = new SelectList(_context.HangVes, "HangID", "HangID", phieuDatVe.HangID);
            ViewData["KhachHangID"] = new SelectList(_context.KhachHangs, "KhachHangID", "KhachHangID", phieuDatVe.KhachHangID);
            ViewData["ChuyenBayID"] = new SelectList(_context.LichChuyenBays, "ChuyenBayID", "ChuyenBayID", phieuDatVe.ChuyenBayID);
            return View(phieuDatVe);
        }
        // POST: DatVe/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public async Task<IActionResult> Create2(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lichChuyenBays = await _context.LichChuyenBays.FindAsync(id);
            if (lichChuyenBays == null)
            {
                return NotFound();
            }

            ViewBag.IdChuyenBay = id;
            giaChuyenBay = lichChuyenBays.GiaVe;
            ViewBag.GiaVe = lichChuyenBays.GiaVe;
            ViewBag.HangVe = _context.HangVes.ToList();
            ViewBag.GiaVeHang01 = _context.HangVes.Where(p => p.HangID == "HA01").SingleOrDefault().TiLeGia * lichChuyenBays.GiaVe / 100 + lichChuyenBays.GiaVe;

            ViewData["HangID"] = new SelectList(_context.HangVes, "HangID", "HangID");
            ViewData["KhachHangID"] = new SelectList(_context.KhachHangs, "KhachHangID", "KhachHangID");
            //ViewData["ChuyenBayID"] = new SelectList(_context.LichChuyenBays, "ChuyenBayID", "ChuyenBayID");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>
                            Create2(
                            [Bind("PhieuDatChoId,KhachHangId,HangID,ChuyenBayID")] PhieuDatCho phieuDatCho,
                            KhachHang KhachHang)
        {
            if (ModelState.IsValid)
            {
                KhachHang.KhachHangID = phieuDatCho.ChuyenBayID + KhachHang.CMND;
                _context.Add(KhachHang);
                await _context.SaveChangesAsync();
                var x = _context.LichChuyenBays.SingleOrDefault(p => p.ChuyenBayID == phieuDatCho.ChuyenBayID).GiaVe;
                phieuDatCho.KhachHangID = phieuDatCho.ChuyenBayID + KhachHang.CMND;
                phieuDatCho.GiaTien = _context.HangVes.SingleOrDefault(p => p.HangID == phieuDatCho.HangID).TiLeGia * x / 100 + x;
                _context.Add(phieuDatCho);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["HangID"] = new SelectList(_context.HangVes, "HangID", "HangID", phieuDatCho.HangID);
            ViewData["KhachHangID"] = new SelectList(_context.KhachHangs, "KhachHangID", "KhachHangID", phieuDatCho.KhachHangID);
            ViewData["ChuyenBayID"] = new SelectList(_context.LichChuyenBays, "ChuyenBayID", "ChuyenBayID", phieuDatCho.ChuyenBayID);
            return View(phieuDatCho);
        }
        // POST: DatVe/Delete/5
       
        //public async Task<IActionResult> XemGiaVe(string id)
        //{
        //    var x = _context.HangVes.SingleOrDefault(p => p.HangID == id).TiLeGia;
        //    ViewBag.GiaTien = x * ViewBag.GiaChuyenBay + ViewBag.GiaChuyenBay;
        //    return View();
        //}

        // POST: PhieuDatVes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> XemGiaVe()
        //{
        //    return View();
        //}
        [HttpPost]
        public JsonResult Update([FromBody] HangId model)
        {
            //object o = JsonConvert.DeserializeObject(model);
            //string json2 = JsonConvert.SerializeObject(o, Formatting.Indented);
            //JavaScriptSerializer serializer = new JavaScriptSerializer();
            //HangVe employee = json2.Deserialize<HangVe>(model);

            //save db
            //var entity = _context.Employees.Find(employee.ID);
            //entity.Salary = employee.Salary;
            return Json(new
            {
                status = _context.HangVes.Where(p => p.HangID == model.id).Single().TiLeGia
            });
        }
    }
    public class HangId
    {
        public string id { get; set; }
    }
}