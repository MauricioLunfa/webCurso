using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webCurso.Models;

namespace webCurso.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {

            List<Departamento> lista = new List<Departamento>();
            lista.Add(new Departamento { Id = 1, Nome = "Eletronicos" });
            lista.Add(new Departamento { Id = 2, Nome = "Alimentos" });
            lista.Add(new Departamento { Id = 3, Nome = "Medicamentos" });

            return View(lista);
        }
    }
}