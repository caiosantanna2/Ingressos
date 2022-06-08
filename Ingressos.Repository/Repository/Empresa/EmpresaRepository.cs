using Ingressos.Domain.Interfaces.Services;

using Ingressos.Domain.Entities.Instituicao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ingressos.Data.Context;
using Microsoft.EntityFrameworkCore;
using Ingressos.Domain.Interfaces.Repository;

namespace Ingressos.Data.Repository.Instituicao
{
    public class EmpresaRepository : IEmpresaRepository
    {
        private readonly IngresssosContext _context;

        public EmpresaRepository(IngresssosContext context)
        {
            _context = context;
        }
        public Empresa AlterarEmpresa(Empresa empresa)
        {
            _context.Entry(empresa).State = EntityState.Modified;
            _context.Update(empresa);
            _context.SaveChanges();

            return empresa;
        }

        public Empresa CadastrarEmpresa(Empresa empresa)
        {
            _context.Add(empresa);
            _context.SaveChanges();
            return empresa;
        }

        public List<Empresa> ConsultarEmpresas()
        {
            var response = _context.Empresa.Include(x => x.Endereco).ToList();
            return response;

        }

        public Empresa ConsultarPorId(Guid IdEmpresa)
        {
            var response = _context.Empresa.Include(x => x.Endereco).FirstOrDefault(x => x.Id == IdEmpresa);

            return response;

        }

        public string ExcluirEmpresa(Guid IdEmpresa)
        {
            var empresa = ConsultarPorId(IdEmpresa);
            if (empresa != null)
            {
                _context.Empresa.Remove(empresa);
                _context.SaveChanges();
                return "Empresa excluída com sucesso!";
            }
            else
            {
               return "Id informado não encotrado!";
            }
        }
    }
}
