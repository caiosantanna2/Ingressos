
using Ingressos.Domain.Entities.Instituicao;
using Ingressos.Domain.Interfaces.Services;
using Ingressos.Domain.Model.Retorno;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Ingressos.Controllers
{

    public class EmpresaController : Controller
    {
        private readonly IEmpresaService _empresaService;
        public EmpresaController(IEmpresaService empresaService)
        {
            _empresaService = empresaService;

        }

        [HttpGet()]
        [ProducesResponseType(typeof(EmpresaListRetornoModel), 200)]
        [Route("/Empresa/Consultar/Todos")]
        public IActionResult ConsultarEmpresas()
        {
            try
            {
                return Ok(_empresaService.ConsultarEmpresas());

            }
            catch (Exception)
            {
                //incluirLog
                return StatusCode(500, "Falha ao consular empresas");
            }
         
        }

        [HttpGet()]
        [ProducesResponseType(typeof(EmpresaListRetornoModel), 200)]
        [Route("/Empresa/Consultar/{idEmpresa}")]
        public IActionResult ConsultarEmpresa(Guid idEmpresa)
        {
            if (idEmpresa == Guid.Empty)
            {
                return BadRequest();
            }

            try
            {
                var response = _empresaService.ConsultarPorId(idEmpresa);
                return Ok(response);
            }
            catch (Exception)
            {

                //incluirLog
                return StatusCode(500, "Falha ao consutlar empresa");
            }
           
        }

        [HttpPost()]
        [ProducesResponseType(typeof(EmpresaRetornoModel), 200)]
        [Route("/Empresa/Cadastrar/")]
        public IActionResult CadastrarEmpresa([FromBody] Empresa empresa)
        {
            if (empresa == null)
            {
                return BadRequest();
            }

            try
            {
                return Ok(_empresaService.CadastrarEmpresa(empresa));

            }
            catch (Exception)
            {
                //incluirLog
                return StatusCode(500, "Falha ao cadastrar empresa");
            }
           
        }

        [HttpPut()]
        [ProducesResponseType(typeof(EmpresaRetornoModel), 200)]
        [Route("/Empresa/Editar/{idEmpresa}")]
        public IActionResult EditarEmpresa([FromBody] Empresa empresa)
        {
            if(empresa == null)
            {
                return BadRequest();
            }

            try
            {
                return Ok(_empresaService.AlterarEmpresa(empresa));
            }
            catch (Exception)
            {

                //incluirLog
                return StatusCode(500, "Falha ao editar empresa");
            }
            
        }

        [HttpDelete()]
        [ProducesResponseType(typeof(EmpresaRetornoModel), 200)]
        [Route("/Empresa/Excluir/{idEmpresa}")]
        public IActionResult ExcluirEmpresa(Guid idEmpresa)
        {
            if (idEmpresa == Guid.Empty)
            {
                return BadRequest();
            }

            try
            {
                return Ok(_empresaService.ExcluirEmpresa(idEmpresa));
            }
            catch (Exception)
            {

                //incluirLog
                return StatusCode(500, "Falha ao excluir empresa");
            }
           
        }
    }
}
