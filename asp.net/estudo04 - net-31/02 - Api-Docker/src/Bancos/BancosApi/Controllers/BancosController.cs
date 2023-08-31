using BancosAPI.Servico.Interfaces;
using BancosAPI.Servico.Requisicoes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace BancosAPI.Controllers
{
    [Route("api/[controller]")]
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
        public async Task<IActionResult> GetTodos()
        {
            var list = await _servico.GetLista();
            return Ok(list);
        }

        [HttpGet("{id:long}")]
        [Consumes(MediaTypeNames.Application.Json)]
        public async Task<IActionResult> GetPorId([FromRoute] string id)
        {
            var resultado = await _servico.GetID(id);
            if (resultado == null)
            {
                return NotFound(resultado);
            }

            return Ok(resultado);
        }

        [HttpDelete("{id:long}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Deletar([FromRoute] string id)
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
