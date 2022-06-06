using Ingressos.Domain.Entities.EventoIngresso;
using Ingressos.Domain.Interfaces.Services;
using Ingressos.Domain.Model;
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

        [HttpPost()]
        [ProducesResponseType(typeof(IngressosModel), 200)]
        [Route("/Ingressos/Cadastrar/")]
        public IActionResult CadastrarIngressos([FromBody] IngressosModel ingressos)
        {
            var response = _ingresssoService.CadastrarIngressoEvento(ingressos);
            return Ok(response);
        }

        [HttpGet()]
        [ProducesResponseType(typeof(List<IngressosEventos>), 200)]
        [Route("/Ingressos/Consultar/Pessoa/{idPessoa}")]
        public IActionResult ConsultarIngressosPorPessoa(Guid idPessoa)
        {
            var response = _ingresssoService.ConsultaIngresosPorPessoa(idPessoa);
            return Ok(response);
        }

        [HttpGet()]
        [ProducesResponseType(typeof(List<IngressosEventos>), 200)]
        [Route("/Ingressos/Consultar/Evento/{idEvento}")]
        public IActionResult ConsultarIngressosPorEvento(Guid idEvento)
        {
            var response = _ingresssoService.ConsultaIngresosPorEvento(idEvento);
            return Ok(response);
        }
       
 

        [HttpPost()]
        [ProducesResponseType(typeof(Evento), 200)]
        [Route("/Ingressos/Editar/{idEvento}")]
        public IActionResult EditarIngresso([FromBody] IngressosEventos evento)
        {
            var response = _ingresssoService.AlterarIngresosEvento(evento);
            return Ok(response);
        }

        [HttpPost()]
        [ProducesResponseType(typeof(Evento), 200)]
        [Route("/Ingressos/Excluir/{idIngressos}")]
        public IActionResult ExcluirEvento(Guid idIngressos)
        {
            var response = _ingresssoService.ExcluirIngressoEvento(idIngressos);
            return Ok(response);
        }
    }
}
