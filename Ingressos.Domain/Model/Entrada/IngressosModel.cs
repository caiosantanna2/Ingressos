using Ingressos.Domain.Entities.EventoIngresso;
using Ingressos.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingressos.Domain.Model.Entrada
{
    public class IngressosModel
    {
       
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }
        public Guid IdEvento { get; set; }

        public static implicit operator IngressosEventos(IngressosModel ingressos)
        {
            return new IngressosEventos()
            {
                Descricao = ingressos.Descricao,
                Valor = ingressos.Valor,
                Quantidade = ingressos.Quantidade,
            };
        }
    }

}
