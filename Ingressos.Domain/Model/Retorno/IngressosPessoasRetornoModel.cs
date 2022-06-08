using Ingressos.Domain.Entities.EventoIngresso;
using System.Collections.Generic;

namespace Ingressos.Domain.Model.Retorno
{
    public class IngressosPessoasRetornoModel
    {

        public string Mensagem { get; set; } = "Sucesso";
        public bool IsSucesso { get; set; } = true;
        public IngressosPessoas IngressosPessoas { get; set; }

        public static implicit operator IngressosPessoasRetornoModel(IngressosPessoas ingressos)
        {
            return new IngressosPessoasRetornoModel()
            {
                IngressosPessoas = ingressos
            };
            
        }
    }
}
