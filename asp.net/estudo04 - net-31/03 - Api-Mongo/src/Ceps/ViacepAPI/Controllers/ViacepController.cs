using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using System.Threading.Tasks;
using ViacepAPI.Respostas;
using ViacepAPI.ServicoInterfaces;

namespace ViacepAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ViacepController : ControllerBase
    {

        // propriedade _servico 
        //***********************************************************************************
        private readonly IViacepServico _servico;


        public ViacepController(IViacepServico appServico)
        {
            // injeção de dependencia do SERVICE la da camada SERVIÇO  
            //***********************************************************************************
            _servico = appServico;

        }


        [HttpGet("{cep:long}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ViacepResposta), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ViacepResposta), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetCEP([FromRoute] string cep)
        {

            if (cep is null)
            {
                return BadRequest("rquisição invalida"); 
            }

            var resultado = await _servico.GetCEPmodel(cep);
            if (resultado is null)
            {
                return NotFound("Cep nao localizado");
            }

            return Ok(resultado);
        }

        
    }
}
