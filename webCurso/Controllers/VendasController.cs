﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace webCurso.Controllers
{
    public class VendasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PesquisaSimples()
        {
            return View();
        }

        public IActionResult PesquisaAgrupada()
        {
            return View();
        }


    }
}