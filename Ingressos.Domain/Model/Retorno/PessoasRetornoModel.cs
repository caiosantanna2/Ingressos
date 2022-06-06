using Ingressos.Domain.Entities.Cliente;


namespace Ingressos.Domain.Model.Retorno
{
    public class PessoasRetornoModel
    {
       
        public string Mensagem { get; set; }
        public bool IsSucesso { get; set; }
        public Pessoa Pessoa { get; set; }

        public static implicit operator PessoasRetornoModel(Pessoa pessoa)
        {
            return new PessoasRetornoModel()
            {
                IsSucesso = true,
                Mensagem = "Sucesso",
                Pessoa = pessoa
            };
           
        }
    }
   
}
