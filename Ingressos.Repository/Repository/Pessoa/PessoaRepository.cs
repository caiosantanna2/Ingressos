using Ingressos.Domain.Interfaces.Services;
using Ingressos.Domain.Entities.Cliente;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ingressos.Data.Context;

namespace Ingressos.Data.Repository.Pessoa
{
    public class EmpresaRepository : IPessoaRepository
    {

        private readonly IngresssosContext _context;

        public EmpresaRepository(IngresssosContext context)
        {

            _context = context;
        }
        public Task<Domain.Entities.Cliente.Pessoa> AlterarPessoa(Domain.Entities.Cliente.Pessoa pessoa)
        {
            throw new NotImplementedException();
        }

        public Task<Domain.Entities.Cliente.Pessoa> CadastrarPessoa(Domain.Entities.Cliente.Pessoa pessoa)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Entities.Cliente.Pessoa> ConsultarPessoa(Domain.Entities.Cliente.Pessoa pessoa)
        {

            var response = _context.Pessoas.ToList();
            //public async Task<TbLogMni> ObterLogPorId(int id)
            //{

            //    var logMni = await _context.TbLogMni
            //       .FirstOrDefaultAsync(x => x.CodLogMni == id);

            //    return logMni;



            //}
            return response;

        }

        public Task<Guid> ExcluirPessoa(Guid IdPessoa)
        {
            throw new NotImplementedException();
        }
    }
}
