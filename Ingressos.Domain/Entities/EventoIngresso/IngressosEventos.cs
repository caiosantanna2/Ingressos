
using Ingressos.Domain.Entities.EventoIngresso;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingressos.Domain.Entities.EventoIngresso
{
    public class IngressosEventos
    {
    
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; } 
        public Evento Evento { get; set; }
    }
}
