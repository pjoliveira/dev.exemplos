using ApplicationBusiness.CadastrosModels;
using ApplicationInfra;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationMVC.Controllers
{
    [Authorize]
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
        public async Task<IActionResult> Index()
        {
            ViewBag.Cadastro = "Bancos";

            ViewBag.OrdenaCodigo = "Codigo";
            ViewBag.OrdenaNome = "Nome";
            ViewBag.OrdenaFantasia = "Fantasia";
            
            ViewBag.CurrentOrderBy = ViewBag.OrdenaCodigo; // 
            ViewBag.CurrentFilterBy = " "; // 

            List<Banco> result;

            result = await _context.Banco.OrderBy(s => s.Codigo).ToListAsync();
            

            // salvar a ultima busca e ultimo filtro utilizados
            //***********************************************************
            //ViewBag.CurrentFiltro = CurrentFiltro; 
            //ViewBag.CurrentValor = CurrentValor.Trim();
            
            // cria uma list para ser utilizada no filtroParam do index
            // verifica ultimo item utilizado e o deixa selecionado 
            //***********************************************************
            //ViewBag.Filtros = new List<SelectListItem>();
            //ViewBag.Filtros.Add(new SelectListItem { Text = "Codigo", Value = "1", Selected = (CurrentFiltro == "1") });
            //ViewBag.Filtros.Add(new SelectListItem { Text = "Nome", Value = "2", Selected = (CurrentFiltro == "2") });
            //ViewBag.Filtros.Add(new SelectListItem { Text = "Fantasia", Value = "3", Selected = (CurrentFiltro == "3") });


            // exibe a lista na pagina.
            //***********************************************************
            return View(result);

        }
        
        [HttpGet]
        public PartialViewResult Listagem(string texto)
        {
            List<Banco> list;

            //faz a pesquisa
            if (string.IsNullOrEmpty(texto))
            {
                list = _context.Banco.OrderBy(s => s.Codigo).ToList();
            }
            else
            {
                list = _context.Banco.Where(s => s.Codigo.Contains(texto)).OrderBy(s => s.Codigo).ToList();
            }

            return PartialView("_ListaPartialView", list);
        }

        public async Task<IActionResult> OrderBy(string OrdenaParm)
        {
            ViewBag.Cadastro = "Bancos";

            ViewBag.OrdenaCodigo = "Codigo";
            ViewBag.OrdenaNome = "Nome";
            ViewBag.OrdenaFantasia = "Fantasia";

            List<Banco> result;

            // verificar o que é para filtar...
            //***********************************************************
            switch (OrdenaParm)
            {
                case "Codigo": //Codigo                    
                    result = await _context.Banco.OrderBy(s => s.Codigo).ToListAsync();
                    
                    break;
                case "Nome": //Nome
                    result = await _context.Banco.OrderBy(s => s.Nome).ToListAsync();
                    //queryList = queryList.Where(s => s.Nome.Contains(buscaParam) || s.Fantasia.Contains(buscaParam));
                    
                    break;
                case "Fantasia": //Fantasia
                    result = await _context.Banco.OrderBy(s => s.Fantasia).ToListAsync();
                    
                    break;
                default: //lista todos os registros.
                    result = await _context.Banco.OrderBy(s => s.Nome).ToListAsync();
                    
                    break;
            }

            ViewBag.CurrentOrderBy = OrdenaParm; // 

            //return PartialView("ListaPartialView", result); 
            return View("Index", result);
        }

        [HttpGet]
        public PartialViewResult Filtrar(string texto, string FiltrarPor)
        {
            ViewBag.OrdenaCodigo = "Codigo";
            ViewBag.OrdenaNome = "Nome";
            ViewBag.OrdenaFantasia = "Fantasia";

            List<Banco> result;            

            // verificar o que é para filtar...
            //***********************************************************
            switch (FiltrarPor) //ViewBag.CurrentOrderBy
            {
                case "Codigo": //Codigo                    
                    result =  _context.Banco.Where(s => s.Codigo.Contains(texto)).OrderBy(s => s.Codigo).ToList();

                    break;
                case "Nome": //Nome
                    result =  _context.Banco.Where(s => s.Nome.Contains(texto)).OrderBy(s => s.Nome).ToList();
                    //queryList = queryList.Where(s => s.Nome.Contains(buscaParam) || s.Fantasia.Contains(buscaParam));

                    break;
                case "Fantasia": //Fantasia
                    result =  _context.Banco.Where(s => s.Fantasia.Contains(texto)).OrderBy(s => s.Fantasia).ToList();

                    break;
                default: //lista todos os registros.
                    result =  _context.Banco.Where(s => s.EmpresaId != "00").OrderBy(s => s.Nome).ToList();

                    break;
            }

            ViewBag.CurrentOrderBy = FiltrarPor; // 
            ViewBag.CurrentFilterBy = texto; // 

            return PartialView("_ListaPartialView", result);
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
