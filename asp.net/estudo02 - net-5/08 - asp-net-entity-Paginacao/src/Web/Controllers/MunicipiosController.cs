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

        public IQueryable<Municipio> QueryList { get; set; }

        // GET: Municipios
        public async Task<IActionResult> Index(string CurrentOrdem, string CurrentFiltro, string CurrentValor, int? pageNumber)
        {
            //faz uma pré validação nos parametros.
            //***********************************************************
            CurrentFiltro = !string.IsNullOrEmpty(CurrentFiltro) ? CurrentFiltro : "2";
            CurrentValor = !string.IsNullOrEmpty(CurrentValor) ? CurrentValor : " ";
            CurrentOrdem = !string.IsNullOrEmpty(CurrentOrdem) ? CurrentOrdem : "2";

            if (string.IsNullOrEmpty(CurrentValor))
            {
                pageNumber = 1;
            }
           
            var contexto = _context.Municipio.Include(m => m.Estado).Include(m => m.Estado.Pais);

            //verificar o que vai ser filtrado...
            //***********************************************************
            switch (CurrentFiltro)
            {
                case "1": //ID                    
                    QueryList = contexto.Where(s => s.ID.Equals(CurrentValor));
                    break;
                case "2": //Nome
                    QueryList = contexto.Where(s => s.Nome.Contains(CurrentValor));
                    //queryList = queryList.Where(s => s.Nome.Contains(buscaParam) || s.Fantasia.Contains(buscaParam));
                    break;
                case "3": //Fantasia
                    QueryList = contexto.Where(s => s.Estado.Sigla.Contains(CurrentValor));
                    break;
                default: //lista todos os registros.
                    QueryList = contexto.Where(s => s.Nome.Contains(CurrentValor));
                    break;
            }

            //aplica uma ordenação ao dados 
            //***********************************************************
            switch (CurrentOrdem)
            {
                case "1": // id
                    QueryList = QueryList.OrderBy(s => s.ID);
                    break;
                case "2": // nome do municipio
                    QueryList = QueryList.OrderBy(s => s.Nome);
                    break;
                case "3": // sigla do estado
                    QueryList = QueryList.OrderBy(s => s.Estado.Sigla);
                    break;
                case "4": // nome do país
                    QueryList = QueryList.OrderBy(s => s.Estado.Pais.Nome);
                    break;
                default:
                    QueryList = QueryList.OrderBy(s => s.Nome);
                    break;
            }

            // salvar a ultima busca e ultimo filtro utilizados
            //***********************************************************
            ViewBag.CurrentFiltro = CurrentFiltro;
            ViewBag.CurrentValor = CurrentValor.Trim();
            ViewBag.CurrentOrdem = CurrentOrdem; 

            // cria uma list para ser utilizada no filtroParam do index
            // verifica ultimo item utilizado e o deixa selecionado 
            //***********************************************************
            ViewBag.Filtros = new List<SelectListItem>();
            ViewBag.Filtros.Add(new SelectListItem { Text = "ID", Value = "1", Selected = (CurrentFiltro == "1") });
            ViewBag.Filtros.Add(new SelectListItem { Text = "Nome", Value = "2", Selected = (CurrentFiltro == "2") });
            ViewBag.Filtros.Add(new SelectListItem { Text = "Estado", Value = "3", Selected = (CurrentFiltro == "3") });
            ViewBag.Filtros.Add(new SelectListItem { Text = "Pais", Value = "4", Selected = (CurrentFiltro == "4") });

            ViewBag.Ordena = new List<SelectListItem>();
            ViewBag.Ordena.Add(new SelectListItem { Text = "ID", Value = "1", Selected = (CurrentOrdem == "1") });
            ViewBag.Ordena.Add(new SelectListItem { Text = "Nome", Value = "2", Selected = (CurrentOrdem == "2") });
            ViewBag.Ordena.Add(new SelectListItem { Text = "Estado", Value = "3", Selected = (CurrentOrdem == "3") });
            ViewBag.Ordena.Add(new SelectListItem { Text = "Pais", Value = "4", Selected = (CurrentOrdem == "4") });


            // exibe a lista na pagina.
            //***********************************************************
            //return View(await QueryList.ToListAsync());
            int pageSize = 20;
            return View(await PaginatedList<Municipio>.CreateAsync(QueryList.AsNoTracking(), pageNumber ?? 1, pageSize));
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
