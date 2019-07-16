//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;

//namespace MvcEfCore.Controllers
//{
//    public class RolesController : Controller
//    {
//        [Authorize(Roles = "Admin")]
//        public IActionResult OnlyAdminAccess()
//        {
//            ViewData["role"] = "Admin";
//            return View("Admin");
//        }
//        [Authorize(Roles = "User")]
//        public IActionResult OnlyUserAccess()
//        {
//            ViewData["role"] = "User";
//            return View("MyPage");
//        }
//        [Authorize(Roles = "HR")]
//        public IActionResult OnlyHRAccess()
//        {
//            ViewData["role"] = "HR";
//            return View("MyPage");
//        }

//        [Authorize(Policy = "OnlyAdminAccess")]
//        public IActionResult PolicyExample()
//        {
//            ViewData["role"] = "Admin";
//            return View("MyPage");
//        }
//        public IActionResult Index()
//        {
//            return View();
//        }
//    }
//}