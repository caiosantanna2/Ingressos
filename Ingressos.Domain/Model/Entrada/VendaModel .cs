using Ingressos.Domain.Entities.EventoIngresso;
using Ingressos.Domain.Entities.Vendas;
using Ingressos.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingressos.Domain.Model.Entrada
{
    public class VendaModel
    {
       
        public DateTime? DataVenda { get; set; }
        public List<IngressosVendaModel> Ingressos { get; set; }
        public Guid PessoaId { get; set; }


        public static implicit operator Venda(VendaModel vendaModel)
        {
            return new Venda()
            {
                DataVenda = vendaModel.DataVenda,
             
            };
            
        }
    }
   
}
