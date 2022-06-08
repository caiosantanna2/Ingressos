using Ingressos.Domain.Entities.EventoIngresso;
using System.Collections.Generic;

namespace Ingressos.Domain.Model.Retorno
{
    public class IngressosEventosListRetornoModel
    {

        public string Mensagem { get; set; } = "Sucesso";
        public bool IsSucesso { get; set; } = true;
        public List<IngressosEventos> IngressosEventos { get; set; }

        public static implicit operator IngressosEventosListRetornoModel(List<IngressosEventos> IngressosEvento)
        {
            return new IngressosEventosListRetornoModel()
            {
                IngressosEventos = IngressosEvento
            };
  
        }
    }
}
