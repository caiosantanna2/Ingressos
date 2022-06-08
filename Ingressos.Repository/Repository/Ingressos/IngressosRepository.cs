
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ingressos.Data.Context;
using Microsoft.EntityFrameworkCore;
using Ingressos.Domain.Interfaces.Repository;
using Ingressos.Domain.Entities.EventoIngresso;
using Ingressos.Domain.Entities.EventoEntites;

namespace Ingressos.Data.Repository.Instituicao
{
    public class IngressosRepository : IIngressoRepository
    {
        private readonly IngresssosContext _context;

        public IngressosRepository(IngresssosContext context)
        {
            _context = context;
        }
        public Evento AlterarEvento(Evento empresa)
        {
            _context.Entry(empresa).State = EntityState.Modified;
            _context.Update(empresa);
            _context.SaveChanges();

            return empresa;
        }

        public IngressosEventos AlterarIngresosEvento(IngressosEventos evento)
        {
            _context.Entry(evento).State = EntityState.Modified;
            _context.Update(evento);
            _context.SaveChanges();

            return evento;
        }

        public Evento CadastrarEvento(Evento evento)
        {
            _context.Add(evento);
            _context.SaveChanges();
            return evento;
        }

        public IngressosEventos CadastrarIngressoEvento(IngressosEventos ingressos)
        {
            _context.Add(ingressos);
            _context.SaveChanges();
            return ingressos;
        }

        public IngressosPessoas EditarIngressoPessoa(IngressosPessoas ingressoPessoa)
        {
            _context.Entry(ingressoPessoa).State = EntityState.Modified;
            _context.Update(ingressoPessoa);
            _context.SaveChanges();
            return ingressoPessoa;
        }

        public List<IngressosEventos> ConsultaIngresosPorEvento(Guid idEvento)
        {
            var response = _context.Ingressos.Include(x => x.Evento).ThenInclude(x => x.Instituicao).ThenInclude(x => x.Endereco).
                                              Include(x => x.Evento).ThenInclude(x => x.Endereco).
                                              Where(x => x.Evento.Id == idEvento).ToList();

            return response;
        }



        public IngressosEventos ConsultaIngresosPorId(Guid idIngresso)
        {
            var response = _context.Ingressos.Include(x => x.Evento).
                                              ThenInclude(x => x.Instituicao).ThenInclude(x => x.Endereco).FirstOrDefault(x => x.Id == idIngresso);

            return response;

        }

        public IngressosPessoas ConsultarIngressoPessoa(Guid idIngressoPessoa)
        {
            var response = _context.IngressosPessoas.Include(x=> x.Ingresso).ThenInclude(x=>x.Evento).
                                                     Include(x => x.Pessoa).FirstOrDefault(x => x.Id == idIngressoPessoa);
            return response;
        }

        public List<IngressosPessoas> ConsultarIngressosPessoa(Guid idPessoa)
        {
            var response = _context.IngressosPessoas.Include(x => x.Ingresso).ThenInclude(x => x.Evento).
                            Include(x => x.Pessoa).Where(x => x.Pessoa.Id == idPessoa).ToList();

            return response;
        }

        public List<IngressosPessoas> ConsultarIngressosPessoaEvento(Guid idPessoa, Guid idEvento)
        {
            var response = _context.IngressosPessoas.Include(x => x.Ingresso).ThenInclude(x => x.Evento).
                           Include(x => x.Pessoa).Where(x => x.Pessoa.Id == idPessoa && x.Ingresso.Evento.Id == idEvento).ToList();

            return response;
        }

        public string ExcluirIngressoEvento(Guid idIngresso)
        {
            var ingresso = ConsultaIngresosPorId(idIngresso);
            if (ingresso != null)
            {
                _context.Ingressos.Remove(ingresso);
                _context.SaveChanges();
                return "Ingresso excluído com sucesso!";
            }
            else
            {
                return "Id informado não encotrado!";
            }
        }
    }
}
