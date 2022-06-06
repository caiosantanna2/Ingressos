using Ingressos.Domain.Entities.Cliente;
using Ingressos.Domain.Entities.EventoIngresso;
using Ingressos.Domain.Model.Entrada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingressos.Domain.Interfaces.Services
{
    public interface IIngressoService
    {

       
        List<IngressosEventos> ConsultaIngresosPorEvento(Guid idEvento);
        List<IngressosPessoas> ConsultarIngressosPessoaEvento(Guid idPessoa, Guid idEvento);
        List<IngressosPessoas> ConsultarIngressosPessoa(Guid idPessoa);
        IngressosEventos ConsultaIngresosPorId(Guid idIngresso);

        IngressosEventos CadastrarIngressoEvento(IngressosModel evento);
        string ExcluirIngressoEvento(Guid idEvento);
        IngressosEventos AlterarIngresosEvento(IngressosEventos evento);


    }
}
