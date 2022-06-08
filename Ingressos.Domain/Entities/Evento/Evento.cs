using Ingressos.Domain.Entities.Enderecos;
using Ingressos.Domain.Entities.Instituicao;
using System;


namespace Ingressos.Domain.Entities.EventoEntites
{
    public class Evento
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Endereco Endereco { get; set; }
        public DateTime DataEvento { get; set; }
        public Empresa Instituicao { get; set; }
        public bool IsAtivo { get; set; }

    }
}
