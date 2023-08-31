using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ApplicationBusiness.CadastrosModels;
using ApplicationInfra;

namespace Web.Controllers
{
    public class BancosController : Controller
    {
        private readonly Contexto _context;

        public BancosController(Contexto context)
        {
            _context = context;

        }

        public string CurrentFiltro { get; set; }
        public string CurrentValor { get; set; }
        
        public IQueryable<Banco> QueryList { get; set; }

        // GET: Bancos
        public async Task<IActionResult> Index(string filtroParam, string valorParam)
        {
            CurrentFiltro = !string.IsNullOrEmpty(filtroParam) ? filtroParam : "2";
            CurrentValor = !string.IsNullOrEmpty(valorParam) ? valorParam : " ";

            //criar o objeto contexto e queryList da consulta.
            //***********************************************************
            var contexto = _context.Banco;
            
            //se checar o que é para filtar...
            //***********************************************************
            switch (CurrentFiltro)
            {
                case "1": //Codigo                    
                    QueryList = contexto.Where(s => s.Codigo.Contains(CurrentValor));
                    QueryList = QueryList.OrderBy(s => s.Codigo);
                    break;
                case "2": //Nome
                    QueryList = contexto.Where(s => s.Nome.Contains(CurrentValor));
                    //queryList = queryList.Where(s => s.Nome.Contains(buscaParam) || s.Fantasia.Contains(buscaParam));
                    QueryList = QueryList.OrderBy(s => s.Nome);
                    break;
                case "3": //Fantasia
                    QueryList = contexto.Where(s => s.Fantasia.Contains(CurrentValor));
                    QueryList = QueryList.OrderBy(s => s.Fantasia);
                    break;
                default: //lista todos os registros.
                    QueryList = contexto.Where(s => s.EmpresaId != "00");
                    QueryList = QueryList.OrderBy(s => s.Nome);
                    break;
            }
            
            // salvar a ultima busca e ultimo filtro utilizados
            //***********************************************************
            ViewBag.CurrentFiltro = CurrentFiltro; 
            ViewBag.CurrentValor = CurrentValor.Trim();
            
            // cria uma list para ser utilizada no filtroParam do index
            // verifica ultimo item utilizado e o deixa selecionado 
            //***********************************************************
            ViewBag.Filtros = new List<SelectListItem>();
            ViewBag.Filtros.Add(new SelectListItem { Text = "Codigo", Value = "1", Selected = (CurrentFiltro == "1") });
            ViewBag.Filtros.Add(new SelectListItem { Text = "Nome", Value = "2", Selected = (CurrentFiltro == "2") });
            ViewBag.Filtros.Add(new SelectListItem { Text = "Fantasia", Value = "3", Selected = (CurrentFiltro == "3") });


            // exibe a lista na pagina.
            //***********************************************************
            return View(await QueryList.ToListAsync());

        }

        // GET: Bancos/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var banco = await _context.Banco.FirstOrDefaultAsync(m => m.Codigo == id);
            if (banco == null)
            {
                return NotFound();
            }

            return View(banco);
        }

        // GET: Bancos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bancos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Codigo,Nome,Fantasia,EmpresaId")] Banco banco)
        {
            if (ModelState.IsValid)
            {
                _context.Add(banco);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(banco);
        }

        // GET: Bancos/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var banco = await _context.Banco.FindAsync(id);
            if (banco == null)
            {
                return NotFound();
            }
            return View(banco);
        }

        // POST: Bancos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Codigo,Nome,Fantasia,EmpresaId")] Banco banco)
        {
            if (id != banco.Codigo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(banco);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BancoExists(banco.Codigo))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(banco);
        }

        // GET: Bancos/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var banco = await _context.Banco
                .FirstOrDefaultAsync(m => m.Codigo == id);
            if (banco == null)
            {
                return NotFound();
            }

            return View(banco);
        }

        // POST: Bancos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var banco = await _context.Banco.FindAsync(id);
            _context.Banco.Remove(banco);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BancoExists(string id)
        {
            return _context.Banco.Any(e => e.Codigo == id);
        }
    }
}
