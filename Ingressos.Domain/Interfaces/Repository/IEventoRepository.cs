
using Ingressos.Domain.Entities.EventoEntites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingressos.Domain.Interfaces.Repository
{
    public interface IEventoRepository
    {
        List<Evento> ConsultarEvento();
        Evento ConsultarPorId(Guid idEvento);
        Evento CadastrarEvento(Evento evento);
        Evento AlterarEvento(Evento evento);
        string ExcluirEvento(Guid idEvento);
    }
}
