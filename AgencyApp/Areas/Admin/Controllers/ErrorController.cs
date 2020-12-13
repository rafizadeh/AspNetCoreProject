using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AgencyApp.Areas.Admin.Controllers
{
    public class ErrorController : Controller
    {
        [Route("404")]
        public IActionResult Index()
        {
            return View();
        }
    }
}