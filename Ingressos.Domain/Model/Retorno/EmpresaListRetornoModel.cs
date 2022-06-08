using Ingressos.Domain.Entities.Instituicao;
using System.Collections.Generic;

namespace Ingressos.Domain.Model.Retorno
{
    public class EmpresaListRetornoModel
    {
       
        public string Mensagem { get; set; }
        public bool IsSucesso { get; set; } = true;
        public List<Empresa> Empresa { get; set; }

        public static implicit operator EmpresaListRetornoModel(List<Empresa> empresa)
        {
            return new EmpresaListRetornoModel()
            {
               
                Mensagem = "Sucesso",
                Empresa = empresa
            };
          
        }
    }
   
}
