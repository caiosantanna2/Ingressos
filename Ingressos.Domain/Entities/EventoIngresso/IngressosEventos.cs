
using Ingressos.Domain.Entities.EventoIngresso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingressos.Domain.Entities.EventoIngresso
{
    public class IngressosEventos
    {
        public Guid Id { get; set; }
        public float Valor { get; set; }
        public int Quantidade { get; set; } 
        public TipoIngressos TipoIngressos  { get; set; }
        public Evento Evento { get; set; }
    }
}
