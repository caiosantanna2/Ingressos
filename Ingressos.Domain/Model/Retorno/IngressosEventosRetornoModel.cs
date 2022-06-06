using Ingressos.Domain.Entities.EventoIngresso;


namespace Ingressos.Domain.Model.Retorno
{
    public class IngressosEventosRetornoModel
    {

        public string Mensagem { get; set; }
        public bool IsSucesso { get; set; }
        public IngressosEventos IngressosEventos { get; set; }

        public static implicit operator IngressosEventosRetornoModel(IngressosEventos IngressosEvento)
        {
            return new IngressosEventosRetornoModel()
            {
                IsSucesso = true,
                Mensagem = "Sucesso",
                IngressosEventos = IngressosEvento
            };
  
        }
    }
}
