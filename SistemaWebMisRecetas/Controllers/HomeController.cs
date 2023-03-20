using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SistemaWebMisRecetas.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebMisRecetas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.P1 = "El desayuno es la primera comida que se consume en el día. El nombre deriva del hecho de que uno no come mientras duerme, por lo que al levantarse se encuentra en ayunas, rompiéndose ese ayuno al tomar esta comida (des-ayuno).";
            ViewBag.P2 = "El desayuno es la comida fundamental del día, ya que consumirlo o no, nos afecta de forma notable a corto y a largo plazo.";
            ViewBag.P3 = "¿Qué es el desayuno americano? El desayuno americano está compuesto por huevos, ya sean fritos o revueltos, bacon y tortitas americanas.";
            return View();
        }
    }
}
