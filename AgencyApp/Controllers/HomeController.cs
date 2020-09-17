using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AgencyApp.Models;
using AgencyApp.DAL;
using AgencyApp.ViewModels;
using Microsoft.EntityFrameworkCore;

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

            HomeViewModel model = new HomeViewModel
            {
                Setting = _db.Settings.FirstOrDefault(),
                About = _db.Abouts.FirstOrDefault(),
                Blogs = _db.Blogs.OrderByDescending(b => b.Date).Take(3).ToList(),
                Socials = _db.Socials.ToList(),
                PortfolioCategories = _db.PortfolioCategories.Include(p => p.Portfolios).ToList(),
                Portfolios = _db.Portfolios.Include(p=>p.PortfolioCategory).ToList()
            };

            return View(model);
        }
       
    }
}
