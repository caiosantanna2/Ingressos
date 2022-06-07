using Ingressos.Domain.Entities.EventoIngresso;
using Ingressos.Domain.Interfaces.Services;
using Ingressos.Domain.Model.Entrada;
using Ingressos.Domain.Model.Retorno;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Ingressos.Controllers
{
    public class IngressosController : Controller
    {
        private readonly IIngressoService _ingresssoService;
        public IngressosController(IIngressoService ingresssoService)
        {
            _ingresssoService = ingresssoService;

        }
        [HttpGet()]
        [ProducesResponseType(typeof(IngressosEventosListRetornoModel), 200)]
        [Route("/Ingressos/Consultar/Pessoa/{idPessoa}")]
        public IActionResult ConsultarIngressosPorPessoa(Guid idPessoa)
        {
            if (idPessoa == Guid.Empty)
            {
                return BadRequest();
            }

            try
            {
                return Ok(_ingresssoService.ConsultarIngressosPessoa(idPessoa));
            }
            catch (Exception)
            {
                //log
                return StatusCode(500, "Falha ao consultar ingressos");

            }
           
        }
        [HttpGet()]
        [ProducesResponseType(typeof(IngressosEventosListRetornoModel), 200)]
        [Route("/Ingressos/Consultar/Pessoa/{idPessoa}/Evento/{idEvento}")]
        public IActionResult ConsultarIngressosPorPessoaEvento(Guid idPessoa, Guid idEvento)
        {
            if (idPessoa == Guid.Empty || idEvento == Guid.Empty)
            {
                return BadRequest();
            }

            try
            {
                return Ok(_ingresssoService.ConsultarIngressosPessoaEvento(idPessoa, idEvento));
            }
            catch (Exception)
            {
                //log
                return StatusCode(500, "Falha ao consultar ingressos");
            }

        }

        [HttpGet()]
        [ProducesResponseType(typeof(IngressosEventosListRetornoModel), 200)]
        [Route("/Ingressos/Consultar/Evento/{idEvento}")]
        public IActionResult ConsultarIngressosPorEvento(Guid idEvento)
        {
            if (idEvento == Guid.Empty)
            {
                return BadRequest();
            }

            try
            {
                return Ok(_ingresssoService.ConsultaIngresosPorEvento(idEvento));
            }
            catch (Exception)
            {

                //log
                return StatusCode(500, "Falha ao consultar ingressos");
            }

        }
        [HttpPost()]
        [ProducesResponseType(typeof(IngressosEventosRetornoModel), 200)]
        [Route("/Ingressos/Cadastrar/")]
        public IActionResult CadastrarIngressos([FromBody] IngressosModel ingressos)
        {

            if (ingressos == null)
            {
                return BadRequest();
            }

            try
            {
                return Ok(_ingresssoService.CadastrarIngressoEvento(ingressos));
            }
            catch (Exception)
            {
                //log
                return StatusCode(500, "Falha ao cadastrar ingressos");
            }

          
        }

        
        [HttpPost()]
        [ProducesResponseType(typeof(IngressosEventosRetornoModel), 200)]
        [Route("/Ingressos/Editar/{idEvento}")]
        public IActionResult EditarIngresso([FromBody] IngressosEventos ingressoEvento)
        {

            if (ingressoEvento == null)
            {
                return BadRequest();
            }

            try
            {
                return Ok(_ingresssoService.AlterarIngresosEvento(ingressoEvento));
            }
            catch (Exception)
            {

                //log
                return StatusCode(500, "Falha ao alterar ingressos");
            }
           
        }

        [HttpPost()]
        [ProducesResponseType(typeof(IngressosEventosRetornoModel), 200)]
        [Route("/Ingressos/Excluir/{idIngressos}")]
        public IActionResult ExcluirEvento(Guid idIngressos)
        {
            if (idIngressos == Guid.Empty)
            {
                return BadRequest();
            }

            try
            {
                return Ok(_ingresssoService.ExcluirIngressoEvento(idIngressos));
            }
            catch (Exception)
            {
                //log
                return StatusCode(500, "Falha ao excluir ingressos");
            }
          
        }
    }
}
