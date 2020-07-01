using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaJogos.Services;
using Microsoft.AspNetCore.Mvc;
using LojaJogos.Models;
namespace LojaJogos.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly CategoriaService _categoriaService;

        public CategoriasController(CategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        public IActionResult Index()
        {
            var categorias = _categoriaService.getCategorias();
            return View(categorias);
        }
        [HttpPost]

        public IActionResult Create(Categoria categoria)
        {
            _categoriaService.Inserir(categoria);
            return RedirectToAction(nameof(Index));
        }
    }
}