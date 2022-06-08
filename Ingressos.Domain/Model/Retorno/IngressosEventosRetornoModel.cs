using Ingressos.Domain.Entities.EventoIngresso;


namespace Ingressos.Domain.Model.Retorno
{
    public class IngressosEventosRetornoModel
    {

        public string Mensagem { get; set; } = "Sucesso";
        public bool IsSucesso { get; set; } = true;
        public IngressosEventos IngressosEventos { get; set; }

        public static implicit operator IngressosEventosRetornoModel(IngressosEventos IngressosEvento)
        {
            return new IngressosEventosRetornoModel()
            {
                IngressosEventos = IngressosEvento
            };
  
        }
    }
}
