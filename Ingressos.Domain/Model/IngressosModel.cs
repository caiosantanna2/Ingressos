using Ingressos.Domain.Entities.EventoIngresso;
using Ingressos.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingressos.Domain.Model
{
    public class IngressosModel
    {
        private readonly IEventoService _eventoService;
       
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }
        public Guid IdEvento { get; set; }

        public static implicit operator IngressosEventos(IngressosModel ingressos)
        {
            IngressosEventos ingressosEventos = new IngressosEventos();
            ingressosEventos.Descricao = ingressos.Descricao;
            ingressosEventos.Quantidade = ingressos.Quantidade;
            ingressosEventos.Valor = ingressos.Valor;
   

           
            return ingressosEventos;
        }
    }
   
}
