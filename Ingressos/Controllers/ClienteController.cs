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
        [Route("/Pessoa/Consultar/Todas")]
        public IActionResult ConsultarPessoa()
        {
            var response = _pessoaService.ConsultarPessoas();
           
            return Ok(response);
        }

        [HttpGet()]
        [ProducesResponseType(typeof(List<Pessoa>), 200)]
        [Route("/Pessoa/Consultar/{idPessoa}")]
        public IActionResult ConsultarPessoa(Guid idPessoa)
        {
            var response = _pessoaService.ConsultarPorId(idPessoa);

            return Ok(response);
        }

        [HttpPost()]
        [ProducesResponseType(typeof(Pessoa), 200)]
        [Route("/Pessoa/Cadastrar/")]
        public IActionResult CadastrarPessoa([FromBody] Pessoa pessoa)
        {
            var response = _pessoaService.CadastrarPessoa(pessoa);
            return Ok(response);
        }

        [HttpPost()]
        [ProducesResponseType(typeof(Pessoa), 200)]
        [Route("/Pessoa/Editar/{idPessoa}")]
        public IActionResult EditarPessoa([FromBody] Pessoa pessoa)
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
