using Ingressos.Domain.Entities.EventoEntites;
using System;

namespace Ingressos.Domain.Entities.EventoIngresso
{
    public class IngressosEventos
    {

        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }
        public int QuantidadeDisponivel { get; set; }
        public Evento Evento { get; set; }
    }
}
