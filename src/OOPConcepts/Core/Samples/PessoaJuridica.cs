
namespace Core.Samples
{
    public class PessoaJuridica : Pessoa
    {
        public string CNPJ { get { return _documento;  } }
        public string RazaoSocial { get { return _nome; } }

        public PessoaJuridica(string cnpj, string razaoSocial) : base(razaoSocial, cnpj)
        {            
        }
    }
}
