using Ingressos.Domain.Entities.EventoIngresso;
using System.Collections.Generic;

namespace Ingressos.Domain.Model.Retorno
{
    public class IngressosPessoasListRetornoModel
    {

        public string Mensagem { get; set; }
        public bool IsSucesso { get; set; }
        public List<IngressosPessoas> IngressosPessoas { get; set; }

        public static implicit operator IngressosPessoasListRetornoModel(List<IngressosPessoas> ingressos)
        {
            return new IngressosPessoasListRetornoModel()
            {
                IsSucesso = true,
                Mensagem = "Sucesso",
                IngressosPessoas = ingressos
            };
            
        }
    }
}
