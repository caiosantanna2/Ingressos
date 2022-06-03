using Ingressos.Domain.Entities.Cliente;
using Ingressos.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

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
        [ProducesResponseType(typeof(List<Pessoa>), 200)]
        [Route("/Pessoa/Consultar/")]
        public IActionResult ConsultarPessoa(Pessoa pessoa)
        {
            var response = _pessoaService.ConsltarPessoa(pessoa);
            return Ok(response);
        }

        [HttpPost()]
        [ProducesResponseType(typeof(Pessoa), 200)]
        [Route("/Pessoa/Cadastrar/")]
        public IActionResult CadastrarPessoa(Pessoa pessoa)
        {
            var response = _pessoaService.CadastrarPessoa(pessoa);
            return Ok(response);
        }

        [HttpPost()]
        [ProducesResponseType(typeof(Pessoa), 200)]
        [Route("/Pessoa/Editar/{idPessoa}")]
        public IActionResult EditarPessoa(Pessoa pessoa)
        {
            var response = _pessoaService.AlterarPessoa(pessoa);
            return Ok(response);
        }

        [HttpPost()]
        [ProducesResponseType(typeof(Pessoa), 200)]
        [Route("/Pessoa/Excluir/{idPessoa}")]
        public IActionResult ExcluirPessoa(Guid idPessoa)
        {
            var response = _pessoaService.ExcluirPessoa(idPessoa);
            return Ok(response);
        }
    }
}
