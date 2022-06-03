using Ingressos.Domain.Entities.Cliente;
using Ingressos.Domain.Entities.EventoIngresso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingressos.Domain.Interfaces.Services
{
    public interface IEventoService
    {
        List<Evento> ConsultarEventos();
        Evento CadastrarEvento(Evento evento);
        Evento ConsultarPorId(Guid idEvento);
        Evento AlterarEvento(Evento evento);
        string ExcluirEvento(Guid idEvento);
    }
}
