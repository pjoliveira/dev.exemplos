using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ApplicationBusiness.ParametrosModels;
using ApplicationInfra;

namespace Web.Controllers
{
    public class MunicipiosController : Controller
    {
        private readonly Contexto _context;

        public MunicipiosController(Contexto context)
        {
            _context = context;
        }

        // GET: Municipios
        public async Task<IActionResult> Index(string OrdenaParm)
        {

            ViewBag.IDOrdenaParm = "ID";
            ViewBag.NameOrdenaParm = "nome";
            ViewBag.EstadoOrdenaParm = "estado";
            ViewBag.PaisOrdenaParm = "pais";

            var contexto = _context.Municipio.Include(m => m.Estado).Include(m => m.Estado.Pais);

            List<Municipio> municipio;

            switch (OrdenaParm)
            {
                case "ID":
                    municipio = await contexto.OrderBy(m => m.ID).ToListAsync();
                    break;
                case "nome":
                    municipio = await contexto.OrderBy(m => m.Nome).ToListAsync();
                    break;
                case "estado":
                    municipio = await contexto.OrderBy(m => m.Estado.Sigla).ToListAsync();
                    break;
                case "pais":
                    municipio = await contexto.OrderBy(m => m.Estado.Pais.Nome).ToListAsync();
                    break;
                default:
                    municipio = await contexto.OrderBy(m => m.Nome).ToListAsync();
                    break;
            }
            //return View(await contexto.OrderBy(s => s.Nome).ToListAsync());
            return View(municipio);
        }

        // GET: Municipios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var municipio = await _context.Municipio.Include(m => m.Estado).Include(m => m.Estado.Pais)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (municipio == null)
            {
                return NotFound();
            }

            return View(municipio);
        }

        // GET: Municipios/Create
        public IActionResult Create()
        {
            ViewData["UfID"] = new SelectList(_context.Estado, "ID", "Nome");
            return View();
        }

        // POST: Municipios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Nome,UfID")] Municipio municipio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(municipio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UfID"] = new SelectList(_context.Estado, "ID", "Nome", municipio.UfID);
            return View(municipio);
        }

        // GET: Municipios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var municipio = await _context.Municipio.FindAsync(id);
            if (municipio == null)
            {
                return NotFound();
            }
            ViewData["UfID"] = new SelectList(_context.Estado, "ID", "Nome", municipio.UfID);
            return View(municipio);
        }

        // POST: Municipios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Nome,UfID")] Municipio municipio)
        {
            if (id != municipio.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(municipio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MunicipioExists(municipio.ID))
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
            ViewData["UfID"] = new SelectList(_context.Estado, "ID", "Nome", municipio.UfID);
            return View(municipio);
        }

        // GET: Municipios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var municipio = await _context.Municipio.Include(m => m.Estado).FirstOrDefaultAsync(m => m.ID == id);
            if (municipio == null)
            {
                return NotFound();
            }

            return View(municipio);
        }

        // POST: Municipios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var municipio = await _context.Municipio.FindAsync(id);
            _context.Municipio.Remove(municipio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MunicipioExists(int id)
        {
            return _context.Municipio.Any(e => e.ID == id);
        }
    }
}
