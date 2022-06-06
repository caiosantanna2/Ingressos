using Ingressos.Domain.Model.Entrada;
using Microsoft.AspNetCore.Mvc;
using System;
using Ingressos.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Ingressos.Controllers
{
    public class VendasController : Controller
    {
        private readonly IVendaService _ingresssoVenda;

        public VendasController(IVendaService ingresssoVenda)
        {
            _ingresssoVenda = ingresssoVenda;

        }
        [HttpPost()]
        [ProducesResponseType(typeof(VendaModel), 200)]
        [Route("/Venda/RealizaVenda/")]
        public IActionResult RealizaVenda([FromBody] VendaModel venda)
        {
            if (venda == null)
            {
                return BadRequest();
            }
            try
            {
                var response = _ingresssoVenda.RealizaVenda(venda);
                return Ok(response);
            }
            catch (Exception)
            {

                return StatusCode(500, "Falha ao realizar venda");
            }
            
        }

        [HttpGet()]
        [ProducesResponseType(typeof(List<VendaModel>), 200)]
        [Route("/Venda/Consultar/{idVenda}")]
        public IActionResult ConsultarVenda(Guid idVenda)
        {
            if (idVenda == null || idVenda == Guid.Empty)
            {
                return BadRequest();
            }

            try
            {
                var response = _ingresssoVenda.ConsultarVenda(idVenda);
                return Ok(response);

            }
            catch (Exception e)
            {

                return StatusCode(500, "Falha ao consultar venda");
            }
           
        }

      

        [HttpGet()]
        [ProducesResponseType(typeof(List<VendaModel>), 200)]
        [Route("/Venda/Cancelar/{idVenda}")]
        public IActionResult CancelarVenda(Guid idVenda)
        {
            if (idVenda == null || idVenda == Guid.Empty)
            {
                return BadRequest();
            }

            try
            {
                var response = _ingresssoVenda.CancelarVenda(idVenda);
                return Ok(response);
            }
            catch (Exception e)
            {

                return StatusCode(500, "Falha ao cancelar venda");
            }
          
        }

        
    }
}
