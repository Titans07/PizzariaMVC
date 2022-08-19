using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pizzaria.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria.Controllers
{
    public class TamanhosController : Controller
    {
        private PizzariaDbContext _context;

        public TamanhosController(PizzariaDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Tamanhos);
        }

        public IActionResult Detalhes(int id)
        {
            var tamanho = _context.Tamanhos
                .Include(c => c.Pizzas)
                .FirstOrDefault(c => c.Id == id);

            if (tamanho == null)
                return View("NotFound");

            return View(tamanho);
        }

        public IActionResult Criar()
        {
            return View();
        }
    }
}
