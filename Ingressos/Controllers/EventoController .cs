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
            try
            {
                return Ok(_eventoService.ConsultarEventos());
            }
            catch (Exception e)
            {
                //incluirLog
                return StatusCode(500, "Falha ao consular eventos");
            }

        }

        [HttpGet()]
        [ProducesResponseType(typeof(List<Evento>), 200)]
        [Route("/Evento/Consultar/{idEvento}")]
        public IActionResult ConsultarEvento(Guid idEvento)
        {
            if (idEvento == null || idEvento == Guid.Empty)
            {
                return BadRequest();
            }

            try
            {
                return Ok(_eventoService.ConsultarPorId(idEvento));

            }
            catch (Exception e)
            {
                //incluirLog
                return StatusCode(500, "Falha ao consultar evento");
            }
           
        }

        [HttpPost()]
        [ProducesResponseType(typeof(Evento), 200)]
        [Route("/Evento/Cadastrar/")]
        public IActionResult CadastrarEvento([FromBody] Evento evento)
        {
            if (evento == null)
            {
                return BadRequest();
            }

            try
            {
                return Ok(_eventoService.CadastrarEvento(evento));
            }
            catch (Exception e)
            {
                //incluirLog
                return StatusCode(500, "Falha ao cadastrar evento");
            }

        }

        [HttpPost()]
        [ProducesResponseType(typeof(Evento), 200)]
        [Route("/Evento/Editar/{idEvento}")]
        public IActionResult EditarEvento([FromBody] Evento evento)
        {
            if (evento == null)
            {
                return BadRequest();
            }

            try
            {
                return Ok(_eventoService.AlterarEvento(evento));
            }
            catch (Exception e)
            {
                //incluirLog
                return StatusCode(500, "Falha ao editar evento");
            }
            
        }

        [HttpPost()]
        [ProducesResponseType(typeof(Evento), 200)]
        [Route("/Evento/Excluir/{idEvento}")]
        public IActionResult ExcluirEvento(Guid idEvento)
        {
            if (idEvento == null || idEvento == Guid.Empty)
            {
                return BadRequest();
            }

            try
            {
                return Ok(_eventoService.ExcluirEvento(idEvento));
            }
            catch (Exception e)
            {
                //incluirLog
                return StatusCode(500, "Falha ao excluir evento");
            }
           
        }
    }
}
