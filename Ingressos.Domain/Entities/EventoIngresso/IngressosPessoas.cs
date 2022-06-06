﻿
using Ingressos.Domain.Entities.Cliente;
using Ingressos.Domain.Entities.EventoIngresso;
using Ingressos.Domain.Entities.Vendas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingressos.Domain.Entities.EventoIngresso
{
    public class IngressosPessoas
    {
        public Guid Id { get; set; }
        public IngressosEventos Ingresso { get; set; }    
        public Pessoa Pessoa { get; set; }
        //public Guid VendasId { get; set; }
        //public Venda Venda { get; set; }

    }
}
