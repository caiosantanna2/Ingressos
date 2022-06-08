using Ingressos.Domain.Entities.EventoEntites;

namespace Ingressos.Domain.Model.Retorno
{
    public class EventoRetornoModel
    {
       
        public string Mensagem { get; set; } = "Sucesso";
        public bool IsSucesso { get; set; } = true;
        public Evento Evento { get; set; } 

        public static implicit operator EventoRetornoModel(Evento evento)
        {
            return new EventoRetornoModel()
            {
                Evento = evento
            };

        }
    }
   
}
