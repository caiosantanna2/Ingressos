using Ingressos.Domain.Entities.Instituicao;


namespace Ingressos.Domain.Model.Retorno
{
    public class EmpresaRetornoModel
    {

        public string Mensagem { get; set; } = "Sucesso";
        public bool IsSucesso { get; set; } = true;
        public Empresa Empresa { get; set; }

        public static implicit operator EmpresaRetornoModel(Empresa empresa)
        {
            return new EmpresaRetornoModel()
            {
                Empresa = empresa
            };
          
        }
    }

}
