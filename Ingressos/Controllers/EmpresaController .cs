﻿using Microsoft.AspNetCore.Mvc;

namespace Ingressos.Controllers
{
    public class EmpresaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
