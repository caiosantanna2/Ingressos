
using Ingressos.Domain.Entities.Vendas;

namespace Ingressos.Domain.Model.Retorno
{
    public class VendaRetornoModel
    {
       
        public string Mensagem { get; set; }
        public bool IsSucesso { get; set; }
        public Venda Venda { get; set; }

        public static implicit operator VendaRetornoModel(Venda venda)
        {
            return new VendaRetornoModel()
            {
                IsSucesso = true,
                Mensagem = "Sucesso",
                Venda = venda
            };

        }
    }
   
}
