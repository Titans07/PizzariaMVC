using Microsoft.AspNetCore.Mvc;
using Pizzaria.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria.Controllers
{
    public class PizzasController : Controller
    {
        private PizzariaDbContext _context;

        public PizzasController(PizzariaDbContext context)
        {
            _context = context;
        }

        public IActionResult Index() => View(_context.Pizzas);


    }
}
