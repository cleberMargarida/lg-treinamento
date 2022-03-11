using LG.Treinamento.InterfacesFabricas.ContratosDeServicos.Servicos;
using LG.Treinamento.Negocio.Interfaces;
using LG.Treinamento.Negocio.Objetos;
using LG.Treinamento.UIWebMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LG.Treinamento.UIWebMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IServiceTurma service;

        public HomeController(IServiceTurma service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
