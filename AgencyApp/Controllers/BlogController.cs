using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgencyApp.DAL;
using AgencyApp.Models;
using AgencyApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

            List<Blog> blogs = _db.Blogs.OrderByDescending(b => b.Date).ToList();

            return View(blogs);
        }

        [Route("blog/{slug}")]
        public IActionResult Detail(string slug)
        {
            if (string.IsNullOrEmpty(slug))
            {
                return NotFound();
            }

            Blog blog = _db.Blogs.FirstOrDefault(b => b.Slug == slug);


            return View(blog);
        }
    }
}