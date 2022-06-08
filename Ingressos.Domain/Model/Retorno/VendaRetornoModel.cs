
using Ingressos.Domain.Entities.Vendas;

namespace Ingressos.Domain.Model.Retorno
{
    public class VendaRetornoModel
    {
       
        public string Mensagem { get; set; } = "Sucesso";
        public bool IsSucesso { get; set; } = true;
        public Venda Venda { get; set; }

        public static implicit operator VendaRetornoModel(Venda venda)
        {
            return new VendaRetornoModel()
            {
                Venda = venda
            };

        }
    }
   
}
