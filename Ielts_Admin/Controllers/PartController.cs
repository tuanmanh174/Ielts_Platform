using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ielts_Admin.Controllers
{
    public class PartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
