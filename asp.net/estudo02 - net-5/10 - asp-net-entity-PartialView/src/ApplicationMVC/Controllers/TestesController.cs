using ApplicationInfra;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationMVC.Controllers
{
    public class TestesController : Controller
    {
        private readonly Contexto _context;
        public TestesController(Contexto context)
        {
            _context = context;

        }

        public IActionResult Index()
        {
            //ViewBag.Qtde = new LogBusiness().Maximo();

            return View();
        }
        [HttpGet]
        public PartialViewResult Listagem(string texto)
        {
            //faz a pesquisa
            var list = _context.Banco.Where(s => s.Codigo.Contains(texto)).OrderBy(s => s.Codigo).ToList();

            //faz o log
            //new LogBusiness().Registrar(Request.UserHostAddress, texto);

            return PartialView("_Listagem", list);
        }
        [HttpGet]
        public ActionResult Details(string id)
        {
            //var evento = new EventoBusiness().Buscar(id);
            var list = _context.Banco.Find(id);

            return View(list);
        }
    }
}
