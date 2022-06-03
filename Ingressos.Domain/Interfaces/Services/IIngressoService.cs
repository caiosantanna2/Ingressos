using Ingressos.Domain.Entities.Cliente;
using Ingressos.Domain.Entities.EventoIngresso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingressos.Domain.Interfaces.Services
{
    public interface IIngressoService
    {

        IngressosEventos CadastrarIngressoEvento();
        List<IngressosEventos> ConsultaIngresosPorEvento(Guid idEvento);
        List<IngressosEventos> ConsultaIngresosPorPessoa(Guid idPessoa);
        string ExcluirIngressoEvento(Guid idEvento);
        IngressosEventos ConsultarIngresosEventoPorId(Guid idEvento);
        IngressosEventos AlterarIngresosEvento(IngressosEventos evento);

      
    }
}
