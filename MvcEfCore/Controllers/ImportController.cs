using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcEfCore.Data;
using MvcEfCore.Models;

namespace MvcEfCore.Controllers
{
    //[Route("team")]
    //public class ImportController : Controller
    //{
    //    private readonly ApplicationDbContext _context;
    //    public ImportController(ApplicationDbContext context)
    //    {
    //        _context = context;
    //    }
    //    [Route("index")]
    //    //[Route("")]
    //    //[Route("~/")]
    //    public IActionResult Index()
    //    {
    //        return View();
    //    }

    //    [HttpPost]
    //    [Route("importXML")]
    //    public async Task<IActionResult> ImportXML(IFormFile xmlFile)
    //    {
    //        try
    //        {
    //            var path = Path.Combine(Directory.GetCurrentDirectory(), "xmls", xmlFile.FileName);
    //            using (var stream = new FileStream(path, FileMode.Create))
    //            {
    //                await xmlFile.CopyToAsync(stream);
    //            }
    //            ViewBag.products = ProcessImport("xmls/" + xmlFile.FileName);
    //            ViewBag.result = "Done";
    //        }
    //        catch (Exception e)
    //        {
    //            ViewBag.result = e.Message;
    //        }

    //        return View("index");
    //    }

    //    public List<Team> ProcessImport(string path)
    //    {
    //        XDocument xDocument = XDocument.Load(path);
    //        List<Team> teams = xDocument.Descendants("team").Select
    //            (p => new Team()
    //            {
    //                TeamName = p.Element("TeamName").Value,
    //                City = p.Element("City").Value,
    //                Province = p.Element("Province").Value,
    //                Country = p.Element("Country").Value
    //            }).ToList();

    //        foreach (var team in teams)
    //        {
    //            var teamInfo = _context.Teams.SingleOrDefault(p => p.TeamName.Equals(team.TeamName));
    //            if (teamInfo == null)
    //            {
    //                _context.Add(team);
    //            }
    //            _context.SaveChanges();
    //        }
    //        return teams;
    //    }
    //}
}