using ApiService.Controllers.Models.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace ApiServico.Controllers.Models.Dtos
{
    [Route("/chamados")]
    [ApiController]
    public class ChamadoController : ControllerBase
    {
        private static List<Chamado> _listaChamados = new List<Chamado>
        {
            new Chamado(){
                Id = 1, titulo ="Erro na Tela de acesso", Descricao ="o usuario nao conseguiu logar"},
            new Chamado()
            {Id = 2, titulo ="sistema com lentidao",Descricao =" demora no carregamento das telas"}
        };
        private static int _proximoId = 3;

        [HttpGet]
        public IActionResult BuscarTodos()
        {
            return Ok(_listaChamados);

        }
        [HttpGet("{id}")]

        public IActionResult BuscarPorId(int id)
        {
            var chamado = _listaChamados.FirstOrDefault(item => item.Id == id);

            if (chamado == null)
            {
                return NotFound();
            }
            return Ok(chamado);
        }
        [HttpPost]


        [HttpPut("{id}")]

        public IActionResult Atualizar(int id, [FromBody] chamadoDto novoChamado)


        {

            var chamado = _listaChamados.FirstOrDefault(item => item.Id == id);

            if (chamado == null)
            {
                return NotFound();
            }
            chamado.Id = _proximoId++;
            chamado.Status = "Aberto";


            _listaChamados.Add(chamado);
            return Created("", chamado);
        }
        [HttpDelete("{id}")]

        public IActionResult DeletarPorId(int id)
        {
            var chamado = _listaChamados.FirstOrDefault(item => item.Id == id);

            if (chamado == null)
            {
                return NotFound();
            }

            _listaChamados.Remove(chamado);

            return NoContent();
        }

        [HttpPut("{id}/fechamento")]

        public IActionResult Fechar(int id)
        {
            {
                var chamado = _listaChamados.FirstOrDefault(item => item.Id == id);
                chamado.Status = "Fechado";
                return Ok();
            }

        }
    }
}








   

