using ApplicationBusiness.ParametrosModels;
using ApplicationInfra;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Web.Controllers
{
    [Authorize]
    public class UsuariosController : Controller
    {
        private readonly Contexto _context;

        public UsuariosController(Contexto context)
        {
            _context = context;
        }

         [AllowAnonymous]
        // GET: Usuarios
        public async Task<IActionResult> Index(string OrdenaParm)
        {
            ViewBag.IDOrdenaParm = "ID";
            ViewBag.EMailOrdenaParm = "email";
            ViewBag.NomeOrdenaParm = "nome";
            ViewBag.TipoOrdenaParm = "tipo";

            //List<Usuario> usuario = await _context.Usuario.OrderBy(s => s.Nome).ToListAsync();

            var contexto = _context.Usuario;

            List<Usuario> usuario;

            switch (OrdenaParm)
            {
                case "ID":
                    usuario = await contexto.OrderBy(s => s.ID).ToListAsync();
                    break;
                case "email":
                    usuario = await contexto.OrderBy(s => s.Email).ToListAsync();
                    break;
                case "nome":
                    usuario = await contexto.OrderBy(s => s.Nome).ToListAsync();
                    break;
                case "tipo":
                    usuario = await contexto.OrderBy(s => s.Tipo).ToListAsync();
                    break;
                default:
                    usuario = await contexto.OrderBy(s => s.Nome).ToListAsync();
                    break;
            }
            //List<Usuario> usuario = await _context.Usuario.OrderBy(s => s.Nome).ToListAsync();
            //return View(usuario);

            return View(usuario);
        }

        // GET: Usuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuario.FirstOrDefaultAsync(m => m.ID == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // GET: Usuarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Email,Senha,Nome,Tipo,Ativo,ExpiraDias")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        // GET: Usuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuario.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Email,Senha,Nome,Tipo,Ativo,ExpiraDias")] Usuario usuario)
        {
            if (id != usuario.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(usuario.ID))
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
            return View(usuario);
        }

        // GET: Usuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuario
                .FirstOrDefaultAsync(m => m.ID == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuario = await _context.Usuario.FindAsync(id);
            _context.Usuario.Remove(usuario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioExists(int id)
        {
            return _context.Usuario.Any(e => e.ID == id);
        }

        
        [AllowAnonymous]
        public IActionResult LoginPage()
        {
            //(string returnUrl = null)

            // chama a tela de login
            //************************************************
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("UsuarioPage");
            }

            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> LoginPage(string email, string senha)
        {
            // faz a validação do usuário
            //************************************************
            try
            {
                if (ModelState.IsValid)
                {
                    // cria o objeto passando a string de conexão 
                    // para o Repository e valida o login
                    //************************************************                    
                    Usuario usuario = await _context.Usuario.FirstOrDefaultAsync(c => c.Email == email || c.Senha == senha); //id //tabelaRepository.BuscarLogin(email, senha);

                    if (usuario != null)
                    {
                        //usuario não existe e ainda tem tentativas...

                        if (usuario.Email == email && usuario.Senha == senha)
                        {
                            Suporte.UsuarioLogado = usuario;
                            
                            Login();  // executa configuração do login

                            return RedirectToAction("UsuarioPage");
                        }
                        else
                        {
                            ViewBag.Erro = "Usuário e / ou senha incorretos!";
                        }
                    }

                }
            }
            catch (Exception)
            {
                ViewBag.Erro = "Ocorreu algum erro ao tentar se logar, tente novamente!";
            }

            return View();

        }

        /// <summary>
        /// para o funcionamento correto da funcionalidade de login
        /// essas linhas devem se colocadas no metodo CONFIGURE do startu.cs
        /// app.UseCookiePolicy();     // para usar usuarios e senha
        /// app.UseAuthentication();   // para usar usuarios e senha
        /// app.UseAuthorization();    // para usar usuarios e senha
        /// </summary>
        /// <returns>opcoesfiltro - lista com os campos</returns>
        private async void Login()
        {
            //app.UseCookiePolicy();     // para usar usuarios e senha
            //app.UseAuthentication();   // para usar usuarios e senha
            //app.UseAuthorization();    // para usar usuarios e senha

            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, Suporte.UsuarioLogado.Nome),
                new Claim(ClaimTypes.Email, Suporte.UsuarioLogado.Email)//,
                //new Claim(ClaimTypes.Role, Suporte.UsuarioLogado.Tipo)
            };

            ClaimsIdentity identidadeDeUsuario = new ClaimsIdentity(claims, "Login");
            ClaimsPrincipal claimPrincipal = new ClaimsPrincipal(identidadeDeUsuario);

            var propriedadesDeAutenticacao = new AuthenticationProperties
            {
                AllowRefresh = true,
                ExpiresUtc = DateTime.Now.ToLocalTime().AddHours(2),
                IsPersistent = true
            };

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimPrincipal, propriedadesDeAutenticacao);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Logoff()
        {
            await HttpContext.SignOutAsync();

            //Suporte.UsuarioLogado = new UsuarioModel(); 

            return RedirectToAction("UsuarioPage");
        }

        public IActionResult UsuarioPage()
        {

            // chama a tela do usuario
            //************************************************

            return View();

        }
    }
}
