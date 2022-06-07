using Ingressos.Domain.Entities.EventoIngresso;
using System.Collections.Generic;

namespace Ingressos.Domain.Model.Retorno
{
    public class IngressosEventosListRetornoModel
    {

        public string Mensagem { get; set; }
        public bool IsSucesso { get; set; }
        public List<IngressosEventos> IngressosEventos { get; set; }

        public static implicit operator IngressosEventosListRetornoModel(List<IngressosEventos> IngressosEvento)
        {
            return new IngressosEventosListRetornoModel()
            {
                IsSucesso = true,
                Mensagem = "Sucesso",
                IngressosEventos = IngressosEvento
            };
  
        }
    }
}
