using Ingressos.Domain.Entities.Instituicao;


namespace Ingressos.Domain.Model.Retorno
{
    public class EmpresaRetornoModel
    {

        public string Mensagem { get; set; }
        public bool IsSucesso { get; set; } = true;
        public Empresa Empresa { get; set; }

        public static implicit operator EmpresaRetornoModel(Empresa empresa)
        {
            return new EmpresaRetornoModel()
            {
                IsSucesso = true,
                Mensagem = "Sucesso",
                Empresa = empresa
            };
          
        }
    }

}
