using Ingressos.Domain.Entities.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingressos.Domain.Interfaces.Services
{
    public interface IEventoIngresoRepository
    {
        List<Pessoa> ConsultarPessoas();
        Pessoa ConsultarPorId(Guid pessoa);
        Pessoa CadastrarPessoa(Pessoa pessoa);
        Pessoa AlterarPessoa(Pessoa pessoa);
        string ExcluirPessoa(Guid IdPessoa);
    }
}
