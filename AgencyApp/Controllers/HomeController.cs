using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AgencyApp.Models;
using AgencyApp.DAL;

namespace AgencyApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly AgencyDbContext _db;

        public HomeController(AgencyDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            ViewBag.SubPage = true;



            return View();
        }
       
    }
}
