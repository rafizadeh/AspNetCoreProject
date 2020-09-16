using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgencyApp.DAL;
using Microsoft.AspNetCore.Mvc;

namespace AgencyApp.Controllers
{
    public class BlogController : Controller
    {
        private readonly AgencyDbContext _db;
        public BlogController(AgencyDbContext db)
        {
            _db = db;
        }


        [Route("our-blogs")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail()
        {
            return View();
        }
    }
}