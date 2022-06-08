using Ingressos.Domain.Entities.EventoEntites;
using System.Collections.Generic;


namespace Ingressos.Domain.Model.Retorno
{
    public class EventoListRetornoModel
    {

        public string Mensagem { get; set; } = "Sucesso";
        public bool IsSucesso { get; set; } = true;
        public List<Evento> Evento { get; set; }

        public static implicit operator EventoListRetornoModel(List<Evento> evento)
        {
            return new EventoListRetornoModel()
            {
                Evento = evento
            };
        }
    }

}
