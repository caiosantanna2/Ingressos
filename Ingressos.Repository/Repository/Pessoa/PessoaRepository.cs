
using Ingressos.Domain.Entities.Cliente;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ingressos.Data.Context;
using Microsoft.EntityFrameworkCore;
using Ingressos.Domain.Interfaces.Repository;

namespace Ingressos.Data.Repository.Cliente
{
    public class PessoaRepository : IPessoaRepository
    {

        private readonly IngresssosContext _context;

        public PessoaRepository(IngresssosContext context)
        {
            _context = context;
        }
        public Pessoa AlterarPessoa(Pessoa pessoa)
        {
            _context.Entry(pessoa).State = EntityState.Modified;
            _context.Update(pessoa);
            _context.SaveChanges();

            return pessoa;
        }

        public Pessoa CadastrarPessoa(Pessoa pessoa)
        {
            _context.Add(pessoa);
            _context.SaveChanges();
            return pessoa;
        }

        public List<Pessoa> ConsultarPessoas()
        {
            var response = _context.Pessoas.Include(x => x.Endereco).ToList();
            return response;

        }

        public Pessoa ConsultarPorId(Guid id)
        {
            var response = _context.Pessoas.Include(x => x.Endereco).FirstOrDefault(x => x.Id == id);

            return response;
        }

        public string ExcluirPessoa(Guid IdPessoa)
        {
            
            var pessoa = ConsultarPorId(IdPessoa);
            if(pessoa != null)
            {
                _context.Pessoas.Remove(pessoa);
                _context.SaveChanges();
                return "Pessoa excluída com sucesso!";
            }
            else
            {
                return "Id informado não encotrado!";
            }
            
        }

    }
}
