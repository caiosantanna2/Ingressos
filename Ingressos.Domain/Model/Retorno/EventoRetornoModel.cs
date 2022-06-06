using Ingressos.Domain.Entities.EventoIngresso;


namespace Ingressos.Domain.Model.Retorno
{
    public class EventoRetornoModel
    {
       
        public string Mensagem { get; set; }
        public bool IsSucesso { get; set; }
        public Evento Evento { get; set; }

        public static implicit operator EventoRetornoModel(Evento evento)
        {
            return new EventoRetornoModel()
            {
                IsSucesso = true,
                Mensagem = "Sucesso",
                Evento = evento
            };

        }
    }
   
}
