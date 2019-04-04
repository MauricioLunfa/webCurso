using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webCurso.Models;
using webCurso.Servicos;

namespace webCurso.Controllers
{
    public class VendedoresController : Controller
    {

        private readonly VendedorService _vendedorServico;

        public VendedoresController(VendedorService vendedorServico)
        {
            _vendedorServico = vendedorServico;
        }

        public IActionResult Index()
        {
            var list = _vendedorServico.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost] // Indicando ação de post
        [ValidateAntiForgeryToken] // Validação de segurança contra ataques
        public IActionResult Create(Vendedor ven)
        {
            _vendedorServico.Insert(ven);
            return RedirectToAction(nameof(Index));
        }

    }
}