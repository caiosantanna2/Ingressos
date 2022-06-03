using Ingressos.Domain.Entities.Empresa;
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
        [Route("/Empresa/Consultar/")]
        public IActionResult ConsultarPessoa(Empresa empresa)
        {
            var response = _empresaService.ConsultarEmpresa(empresa);
            return Ok(response);
        }

        [HttpPost()]
        [ProducesResponseType(typeof(Empresa), 200)]
        [Route("/Empresa/Cadastrar/")]
        public IActionResult CadastrarPessoa(Empresa empresa)
        {
            var response = _empresaService.CadastrarEmpresa(empresa);
            return Ok(response);
        }

        [HttpPost()]
        [ProducesResponseType(typeof(Empresa), 200)]
        [Route("/Empresa/Editar/{idPessoa}")]
        public IActionResult EditarPessoa(Empresa empresa)
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
