using Ingressos.Domain.Entities.EventoIngresso;


namespace Ingressos.Domain.Model.Retorno
{
    public class IngressosPessoasRetornoModel
    {

        public string Mensagem { get; set; }
        public bool IsSucesso { get; set; }
        public IngressosPessoas IngressosPessoas { get; set; }

        public static implicit operator IngressosPessoasRetornoModel(IngressosPessoas evento)
        {
            return new IngressosPessoasRetornoModel()
            {
                IsSucesso = true,
                Mensagem = "Sucesso",
                IngressosPessoas = evento
            };
            
        }
    }
}
