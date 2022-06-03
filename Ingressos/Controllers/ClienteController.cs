using Ingressos.Domain.Cliente;
using Microsoft.AspNetCore.Mvc;

namespace Ingressos.Controllers
{
    public class ClienteController : Controller
    {
        [HttpGet()]
        [ProducesResponseType(typeof(Pessoa), 200)]
        [Route("/pessoa/consultar/{idPessoa}")]
        public IActionResult consultarPessoa(Pessoa pessoa)
        {
            return View();
        }
        [HttpPost()]
        [ProducesResponseType(typeof(Pessoa), 200)]
        [Route("/pessoa/cadastrar/")]
        public IActionResult cadastrarPessoa(Pessoa pessoa)
        {
            return View();
        }
        [HttpPost()]
        [ProducesResponseType(typeof(Pessoa), 200)]
        [Route("/pessoa/editar/{idPessoa}")]
        public IActionResult editarPessoa(Pessoa pessoa)
        {
            return View();
        }
        [HttpPost()]
        [ProducesResponseType(typeof(Pessoa), 200)]
        [Route("/pessoa/excluir/{idPessoa}")]
        public IActionResult excluirPessoa(Pessoa pessoa)
        {
            return View();
        }
    }
}
