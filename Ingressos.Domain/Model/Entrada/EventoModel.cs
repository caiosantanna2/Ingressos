using Ingressos.Domain.Entities.Enderecos;
using Ingressos.Domain.Entities.EventoEntites;
using System;

namespace Ingressos.Domain.Model.Entrada
{
    public class EventoModel
    {
        
        public string Name { get; set; }
        public Endereco Endereco { get; set; }
        public DateTime DataEvento { get; set; }
        public Guid IdEmpresa { get; set; }
        

        public static implicit operator Evento(EventoModel evento)
        {
            return new Evento()
            {
                Name = evento.Name,
                DataEvento = evento.DataEvento,
                Endereco = evento.Endereco,
                
            };
            
          
        }
    }
   
}
