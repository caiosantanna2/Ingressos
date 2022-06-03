using Ingressos.Domain.Entities.Cliente;
using Ingressos.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Ingressos.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IPessoaService _pessoaService;
        public ClienteController(IPessoaService pessoaService)
        {
            _pessoaService = pessoaService;
        }

        [HttpGet()]
        [ProducesResponseType(typeof(Pessoa), 200)]
        [Route("/pessoa/consultar/{idPessoa}")]
        public IActionResult ConsultarPessoa(Pessoa pessoa)
        {
            var response = _pessoaService.ConsltarPessoa(pessoa);
            return Ok(response);
        }

        [HttpPost()]
        [ProducesResponseType(typeof(Pessoa), 200)]
        [Route("/pessoa/cadastrar/")]
        public IActionResult CadastrarPessoa(Pessoa pessoa)
        {
            var response = _pessoaService.CadastrarPessoa(pessoa);
            return Ok(response);
        }

        [HttpPost()]
        [ProducesResponseType(typeof(Pessoa), 200)]
        [Route("/pessoa/editar/{idPessoa}")]
        public IActionResult EditarPessoa(Pessoa pessoa)
        {
            var response = _pessoaService.AlterarPessoa(pessoa);
            return Ok(response);
        }

        [HttpPost()]
        [ProducesResponseType(typeof(Pessoa), 200)]
        [Route("/pessoa/excluir/{idPessoa}")]
        public IActionResult ExcluirPessoa(Guid idPessoa)
        {
            var response = _pessoaService.ExcluirPessoa(idPessoa);
            return Ok(response);
        }
    }
}
