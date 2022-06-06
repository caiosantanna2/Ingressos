using Ingressos.Domain.Entities.EventoIngresso;
using System.Collections.Generic;


namespace Ingressos.Domain.Model.Retorno
{
    public class EventoListRetornoModel
    {

        public string Mensagem { get; set; }
        public bool IsSucesso { get; set; }
        public List<Evento> Evento { get; set; }

        public static implicit operator EventoListRetornoModel(List<Evento> evento)
        {
            return new EventoListRetornoModel()
            {
                IsSucesso = true,
                Mensagem = "Sucesso",
                Evento = evento
            };
        }
    }

}
