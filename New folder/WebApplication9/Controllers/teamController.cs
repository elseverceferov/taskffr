using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication9.Controllers
{
    public class teamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
