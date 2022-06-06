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
            try
            {
                return Ok(_pessoaService.ConsultarPessoas());
            }
            catch (Exception e)
            {

                //incluirLog
                return StatusCode(500, "Falha ao consultar pessoas");
            }
           
        }

        [HttpGet()]
        [ProducesResponseType(typeof(List<Pessoa>), 200)]
        [Route("/Pessoa/Consultar/{idPessoa}")]
        public IActionResult ConsultarPessoa(Guid idPessoa)
        {
            if (idPessoa == null || idPessoa == Guid.Empty)
            {
                return BadRequest();
            }

            try
            {
               return Ok(_pessoaService.ConsultarPorId(idPessoa));
            }
            catch (Exception e)
            {
                //incluirLog
                return StatusCode(500, "Falha ao consultar pessoa");
            }
           
        }

        [HttpPost()]
        [ProducesResponseType(typeof(Pessoa), 200)]
        [Route("/Pessoa/Cadastrar/")]
        public IActionResult CadastrarPessoa([FromBody] Pessoa pessoa)
        {
            if (pessoa == null)
            {
                return BadRequest();
            }
            try
            {
                return Ok(_pessoaService.CadastrarPessoa(pessoa));
            }
            catch (Exception e)
            {

                //incluirLog
                return StatusCode(500, "Falha ao cadastrar pessoa");
            }
           
        }

        [HttpPost()]
        [ProducesResponseType(typeof(Pessoa), 200)]
        [Route("/Pessoa/Editar/{idPessoa}")]
        public IActionResult EditarPessoa([FromBody] Pessoa pessoa)
        {
            if (pessoa == null)
            {
                return BadRequest();
            }
            try
            {
                return Ok(_pessoaService.AlterarPessoa(pessoa));
            }
            catch (Exception e)
            {

                //incluirLog
                return StatusCode(500, "Falha ao alterar pessoa");
            }
          
        }

        [HttpPost()]
        [ProducesResponseType(typeof(Pessoa), 200)]
        [Route("/Pessoa/Excluir/{idPessoa}")]
        public IActionResult ExcluirPessoa(Guid idPessoa)
        {
            if (idPessoa == null || idPessoa == Guid.Empty)
            {
                return BadRequest();
            }

            try
            {
                return Ok(_pessoaService.ExcluirPessoa(idPessoa));
            }
            catch (Exception e)
            {
                //incluirLog
                return StatusCode(500, "Falha ao excluir pessoa");
            }
           
        }

    }
}
