using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria.Controllers
{
    public class SaboresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
