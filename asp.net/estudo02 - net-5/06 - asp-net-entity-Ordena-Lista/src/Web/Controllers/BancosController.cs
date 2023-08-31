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

        // GET: Bancos
        public async Task<IActionResult> Index(string OrdenaParm)
        {
            ViewBag.CodigoOrdenaParm = "codigo";
            ViewBag.NameOrdenaParm = "nome";
            ViewBag.FantasiaOrdenaParm = "fantasia";

            List<Banco> banco;

            switch (OrdenaParm)
            {
                case "codigo":
                    banco = await _context.Banco.OrderBy(s => s.Codigo).ToListAsync();
                    break;
                case "nome":
                    banco = await _context.Banco.OrderBy(s => s.Nome).ToListAsync();
                    break;
                case "fantasia":
                    banco = await _context.Banco.OrderBy(s => s.Fantasia).ToListAsync();
                    break;
                default:
                    banco = await _context.Banco.OrderBy(s => s.Nome).ToListAsync();
                    break;
            }

            return View(banco);
        }

        // GET: Bancos/Details/5
        public async Task<IActionResult> Details(string id)
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
        public async Task<IActionResult> Create([Bind("Codigo,Nome,Fantasia,IdEmpresa")] Banco banco)
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
        public async Task<IActionResult> Edit(string id, [Bind("Codigo,Nome,Fantasia,IdEmpresa")] Banco banco)
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
