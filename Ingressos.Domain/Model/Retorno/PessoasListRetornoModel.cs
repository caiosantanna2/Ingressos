using Ingressos.Domain.Entities.Cliente;
using System.Collections.Generic;


namespace Ingressos.Domain.Model.Retorno
{
    public class PessoasListRetornoModel
    {
       
        public string Mensagem { get; set; }
        public bool IsSucesso { get; set; }
        public List<Pessoa> Pessoas { get; set; }

        public static implicit operator PessoasListRetornoModel(List<Pessoa> pessoas)
        {
            return new PessoasListRetornoModel()
            {
                IsSucesso = true,
                Mensagem = "Sucesso",
                Pessoas = pessoas
            };

        }
    }
   
}
