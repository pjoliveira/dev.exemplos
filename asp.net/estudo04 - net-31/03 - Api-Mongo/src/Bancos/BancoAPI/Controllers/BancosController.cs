using BancoAPI.Dominio.Entidades;
using BancoAPI.Servico.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using System.Threading.Tasks;

namespace BancosAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BancosController : ControllerBase
    {
        // propriedade _servico 
        //***********************************************************************************
        private readonly IBancoServico _servico;

        public BancosController(IBancoServico appServico)
        {
            // injeção de dependencia do SERVICE la da camada SERVIÇO  
            //***********************************************************************************
           _servico = appServico;
        }        
        
        [HttpGet]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(BancoEntidade), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BancoEntidade), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetLista()
        {
            var list = await _servico.GetLista();
            return Ok(list);
        }

        
        [HttpGet("{id}")]
        [Consumes(MediaTypeNames.Application.Json)]
        public async Task<IActionResult> GetPorId(string id)
        {
            var resultado = await _servico.GetId(id);
            if (resultado == null)
            {
                return NotFound(resultado);
            }

            return Ok(resultado);
        }

        [HttpGet("Codigo/{codigo}")]
        [Consumes(MediaTypeNames.Application.Json)]
        public async Task<IActionResult> GetPorCodigo(string codigo)
        {
            var resultado = await _servico.GetCodigo(codigo);
            if (resultado == null)
            {
                return NotFound(resultado);
            }

            return Ok(resultado);
        }


        [HttpGet("Nome/{nome}")]
        [Consumes(MediaTypeNames.Application.Json)]
        public async Task<IActionResult> GetPorNome(string nome)
        {
            var resultado = await _servico.GetNome(nome);
            if (resultado == null)
            {
                return NotFound(resultado);
            }

            return Ok(resultado);
        }

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(BancoEntidade), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(BancoEntidade), StatusCodes.Status400BadRequest)]
        public async Task Create([FromBody] BancoEntidade item)
        {
            await _servico.Add(item);
        }

        [HttpPut]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(BancoEntidade), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BancoEntidade), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(BancoEntidade), StatusCodes.Status404NotFound)]
        public async Task Update([FromBody] BancoEntidade item)
        {
            await _servico.Update(item);
        }

        [HttpDelete("{id}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Deletar(string id)
        {
            var resultado = await _servico.Delete(id); //Async
            if (resultado == 0 )
            {
             
                   return NotFound(resultado);
             
            }

            return Ok(resultado);
        }
        
    }
}
