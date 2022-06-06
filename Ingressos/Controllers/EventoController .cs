using Ingressos.Domain.Entities.EventoIngresso;
using Ingressos.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Ingressos.Controllers
{
    public class EventoController : Controller
    {
        private readonly IEventoService _eventoService;
        public EventoController(IEventoService eventoService)
        {
            _eventoService = eventoService;

        }

        [HttpGet()]
        [ProducesResponseType(typeof(List<Evento>), 200)]
        [Route("/Evento/Consultar/Todos")]
        public IActionResult ConsultarEvento()
        {
            var response = _eventoService.ConsultarEventos();
            return Ok(response);
        }

        [HttpGet()]
        [ProducesResponseType(typeof(List<Evento>), 200)]
        [Route("/Evento/Consultar/{idEvento}")]
        public IActionResult ConsultarEvento(Guid idEvento)
        {
            var response = _eventoService.ConsultarPorId(idEvento);
            return Ok(response);
        }

        [HttpPost()]
        [ProducesResponseType(typeof(Evento), 200)]
        [Route("/Evento/Cadastrar/")]
        public IActionResult CadastrarEvento([FromBody] Evento evento)
        {
            var response = _eventoService.CadastrarEvento(evento);
            return Ok(response);
        }

        [HttpPost()]
        [ProducesResponseType(typeof(Evento), 200)]
        [Route("/Evento/Editar/{idEvento}")]
        public IActionResult EditarEvento([FromBody] Evento evento)
        {
            var response = _eventoService.AlterarEvento(evento);
            return Ok(response);
        }

        [HttpPost()]
        [ProducesResponseType(typeof(Evento), 200)]
        [Route("/Evento/Excluir/{idEvento}")]
        public IActionResult ExcluirEvento(Guid idEvento)
        {
            var response = _eventoService.ExcluirEvento(idEvento);
            return Ok(response);
        }
    }
}
