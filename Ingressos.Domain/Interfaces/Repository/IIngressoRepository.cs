using Ingressos.Domain.Entities.Cliente;
using Ingressos.Domain.Entities.EventoIngresso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingressos.Domain.Interfaces.Repository
{
    public interface IIngressoRepository
    {

        IngressosEventos CadastrarIngressoEvento(IngressosEventos evento);
        List<IngressosPessoas> ConsultarIngressosPessoaEvento(Guid idPessoa, Guid idEvento);
        List<IngressosPessoas> ConsultarIngressosPessoa(Guid idPessoa);
        IngressosEventos ConsultaIngresosPorId(Guid idIngresso);
        List<IngressosEventos> ConsultaIngresosPorEvento(Guid idEvento);
        string ExcluirIngressoEvento(Guid idEvento);
        IngressosPessoas EditarIngressoPessoa(IngressosPessoas ingressoPessoa);
        IngressosPessoas ConsultarIngressoPessoa(Guid idIngressoPessoa);
        IngressosEventos AlterarIngresosEvento(IngressosEventos evento);

    }
}