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
        List<IngressosEventos> ConsultaIngresosPorEvento(Guid idEvento);
       // List<IngressosEventos> ConsultaIngresosPorPessoa(Guid idPessoa);
        string ExcluirIngressoEvento(Guid idEvento);
        IngressosEventos AlterarIngresosEvento(IngressosEventos evento);

    }
}