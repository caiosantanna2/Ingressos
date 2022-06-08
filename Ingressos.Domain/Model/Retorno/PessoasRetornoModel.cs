using Ingressos.Domain.Entities.Cliente;


namespace Ingressos.Domain.Model.Retorno
{
    public class PessoasRetornoModel
    {
       
        public string Mensagem { get; set; } = "Sucesso";
        public bool IsSucesso { get; set; } = true;
        public Pessoa Pessoa { get; set; }

        public static implicit operator PessoasRetornoModel(Pessoa pessoa)
        {
            return new PessoasRetornoModel()
            {
                Pessoa = pessoa
            };
           
        }
    }
   
}
