
using Ingressos.Domain.Entities.Instituicao;
using Ingressos.Domain.Interfaces.Services;
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
        [ProducesResponseType(typeof(List<Empresa>), 200)]
        [Route("/Empresa/Consultar/Todos")]
        public IActionResult ConsultarPessoa()
        {
            var response = _empresaService.ConsultarEmpresas();
            return Ok(response);
        }

        [HttpGet()]
        [ProducesResponseType(typeof(List<Empresa>), 200)]
        [Route("/Empresa/Consultar/{idEmpresa}")]
        public IActionResult ConsultarPessoa(Guid idEmpresa)
        {
            var response = _empresaService.ConsultarPorId(idEmpresa);
            return Ok(response);
        }

        [HttpPost()]
        [ProducesResponseType(typeof(Empresa), 200)]
        [Route("/Empresa/Cadastrar/")]
        public IActionResult CadastrarPessoa([FromBody] Empresa empresa)
        {
            var response = _empresaService.CadastrarEmpresa(empresa);
            return Ok(response);
        }

        [HttpPost()]
        [ProducesResponseType(typeof(Empresa), 200)]
        [Route("/Empresa/Editar/{idPessoa}")]
        public IActionResult EditarPessoa([FromBody] Empresa empresa)
        {
            var response = _empresaService.AlterarEmpresa(empresa);
            return Ok(response);
        }

        [HttpPost()]
        [ProducesResponseType(typeof(Empresa), 200)]
        [Route("/Empresa/Excluir/{idPessoa}")]
        public IActionResult ExcluirPessoa(Guid idEmpresa)
        {
            var response = _empresaService.ExcluirEmpresa(idEmpresa);
            return Ok(response);
        }
    }
}
