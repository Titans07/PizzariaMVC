using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pizzaria.Data;
using Pizzaria.Models;
using Pizzaria.Models.ViewModels.RequestDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria.Controllers
{
    public class CinemasController : Controller
    {
        private PizzariaDbContext _context;

        public CinemasController(PizzariaDbContext context)
        {
            _context = context;
        }

        public IActionResult Index() => View(_context.Tamanhos);

        public IActionResult Detalhes(int id)
        {
            var tamanho = _context.Tamanhos
                .Include(p => p.Pizzas)
                .FirstOrDefault(c => c.Id == id);

            if (tamanho == null)
                return View("NotFound");

            return View(tamanho);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(PostTamanhoDTO tamanhoDto)
        {
            if (!ModelState.IsValid) return View(tamanhoDto);

            Tamanho tamanho = new Tamanho(tamanhoDto.Nome);
            _context.Tamanhos.Add(tamanho);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Atualizar(int id)
        {
            var result = _context.Tamanhos.FirstOrDefault(tamanho => tamanho.Id == id);

            if (result == null)
                return View("NotFound");

            return View(result);
        }

        [HttpPost]
        public IActionResult Atualizar(int id, PostTamanhoDTO cinemaDTO)
        {
            var result = _context.Tamanhos.FirstOrDefault(cinema => cinema.Id == id);
            result.AlterarDados(cinemaDTO.Nome);
            _context.Tamanhos.Update(result);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Deletar(int id)
        {
            var result = _context.Tamanhos.FirstOrDefault(tamanho => tamanho.Id == id);

            if (result == null)
            {
                return View("NotFound");
            }

            return View(result);
        }

        [HttpPost, ActionName("Deletar")]
        public IActionResult ConfirmarDeletar(int id)
        {
            var result = _context.Tamanhos.FirstOrDefault(tamanho => tamanho.Id == id);
            if (result == null)
                return View("NotFound");

            _context.Remove(result);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
