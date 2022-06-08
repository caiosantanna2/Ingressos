using Ingressos.Domain.Entities.Cliente;
using System.Collections.Generic;


namespace Ingressos.Domain.Model.Retorno
{
    public class PessoasListRetornoModel
    {
       
        public string Mensagem { get; set; } = "Sucesso";
        public bool IsSucesso { get; set; } = true;
        public List<Pessoa> Pessoas { get; set; }

        public static implicit operator PessoasListRetornoModel(List<Pessoa> pessoas)
        {
            return new PessoasListRetornoModel()
            {
                Pessoas = pessoas
            };

        }
    }
   
}
