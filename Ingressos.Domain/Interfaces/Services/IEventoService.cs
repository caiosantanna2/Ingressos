using Ingressos.Domain.Entities.Cliente;
using Ingressos.Domain.Entities.EventoEntites;
using Ingressos.Domain.Model.Entrada;
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
        EventoRetornoModel CadastrarEvento(EventoModel evento);
        EventoRetornoModel ConsultarPorId(Guid idEvento);
        EventoRetornoModel AlterarEvento(Evento evento);
        EventoRetornoModel ExcluirEvento(Guid idEvento);
    }
}
