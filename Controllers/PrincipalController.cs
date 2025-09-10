using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiServico.Controllers.Models.Dtos;

namespace ApiServico.Controllers
{
    [Route("/principal")]
    [ApiController]
    public class PrincipalController : ControllerBase
    {

        [HttpGet("principal")]
        public IActionResult Principal()
        {
            var resultado = new { situaçaonome = "ok", mensagem = "Api Serviço"  };
            return Ok("resultado");
        }
        [HttpGet("autor")]
        
        public IActionResult GetAutor()
        {
            var resultado = new { nome = "Milka", email = "milkafreire40@gmail.com", telefone = "2222" };
                return Ok(resultado);
            }

    }
}
