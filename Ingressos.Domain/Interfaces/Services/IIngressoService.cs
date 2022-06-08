﻿using Ingressos.Domain.Entities.Cliente;
using Ingressos.Domain.Entities.EventoIngresso;
using Ingressos.Domain.Model.Entrada;
using Ingressos.Domain.Model.Retorno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingressos.Domain.Interfaces.Services
{
    public interface IIngressoService
    {


        IngressosEventosListRetornoModel ConsultaIngresosPorEvento(Guid idEvento);
        IngressosPessoasListRetornoModel ConsultarIngressosPessoaEvento(Guid idPessoa, Guid idEvento);
        IngressosPessoasListRetornoModel ConsultarIngressosPessoa(Guid idPessoa);
        IngressosPessoasRetornoModel ConsultarIngressoPessoa(Guid idIngressoPessoa);
        IngressosEventosRetornoModel ConsultaIngresosPorId(Guid idIngresso);
        IngressosEventosRetornoModel CadastrarIngressoEvento(IngressosModel evento);
        IngressosEventosRetornoModel ExcluirIngressoEvento(Guid idEvento);
        IngressosPessoasRetornoModel CancelarIngressoPessoa(Guid idIngressoPessoa);
        IngressosPessoasRetornoModel UtilizarIngressoPessoa(Guid idIngressoPessoa);
        IngressosEventosRetornoModel AlterarIngresosEvento(IngressosEventos evento);


    }
}
