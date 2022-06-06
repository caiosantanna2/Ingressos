using Ingressos.Domain.Entities.Cliente;
using Ingressos.Domain.Entities.EventoIngresso;
using Ingressos.Domain.Model.Retorno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingressos.Domain.Interfaces.Services
{
    public interface IEventoService
    {
        EventoListRetornoModel ConsultarEventos();
        EventoRetornoModel CadastrarEvento(Evento evento);
        EventoRetornoModel ConsultarPorId(Guid idEvento);
        EventoRetornoModel AlterarEvento(Evento evento);
        EventoRetornoModel ExcluirEvento(Guid idEvento);
    }
}
