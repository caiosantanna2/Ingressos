using Ingressos.Domain.Entities.EventoIngresso;
using Ingressos.Domain.Interfaces.Services;
using Ingressos.Domain.Model.Entrada;
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
        [ProducesResponseType(typeof(List<IngressosEventos>), 200)]
        [Route("/Ingressos/Consultar/Pessoa/{idPessoa}")]
        public IActionResult ConsultarIngressosPorPessoa(Guid idPessoa)
        {
            if (idPessoa == null || idPessoa == Guid.Empty)
            {
                return BadRequest();
            }

            try
            {
                return Ok(_ingresssoService.ConsultarIngressosPessoa(idPessoa));
            }
            catch (Exception e)
            {
                //log
                return StatusCode(500, "Falha ao consultar ingressos");

            }
           
        }

        [HttpPost()]
        [ProducesResponseType(typeof(IngressosModel), 200)]
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
            catch (Exception e)
            {
                //log
                return StatusCode(500, "Falha ao cadastrar ingressos");
            }

          
        }

        
        [HttpGet()]
        [ProducesResponseType(typeof(List<IngressosEventos>), 200)]
        [Route("/Ingressos/Consultar/Pessoa/{idPessoa}/Evento/{idEvento}")]
        public IActionResult ConsultarIngressosPorPessoaEvento(Guid idPessoa, Guid idEvento)
        {
            if (idPessoa == null || idPessoa == Guid.Empty || idEvento == null || idEvento == Guid.Empty)
            {
                return BadRequest();
            }

            try
            {
                return Ok(_ingresssoService.ConsultarIngressosPessoaEvento(idPessoa, idEvento));
            }
            catch (Exception e)
            {
                //log
                return StatusCode(500, "Falha ao consultar ingressos");
            }
            
        }

        [HttpGet()]
        [ProducesResponseType(typeof(List<IngressosEventos>), 200)]
        [Route("/Ingressos/Consultar/Evento/{idEvento}")]
        public IActionResult ConsultarIngressosPorEvento(Guid idEvento)
        {
            if (idEvento == null || idEvento == Guid.Empty)
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
        [ProducesResponseType(typeof(Evento), 200)]
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
            catch (Exception e)
            {

                //log
                return StatusCode(500, "Falha ao alterar ingressos");
            }
           
        }

        [HttpPost()]
        [ProducesResponseType(typeof(Evento), 200)]
        [Route("/Ingressos/Excluir/{idIngressos}")]
        public IActionResult ExcluirEvento(Guid idIngressos)
        {
            if (idIngressos == null || idIngressos == Guid.Empty)
            {
                return BadRequest();
            }

            try
            {
                return Ok(_ingresssoService.ExcluirIngressoEvento(idIngressos));
            }
            catch (Exception e)
            {
                //log
                return StatusCode(500, "Falha ao excluir ingressos");
            }
          
        }
    }
}
