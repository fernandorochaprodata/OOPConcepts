
namespace Core.Samples
{
    public class PessoaFisica : Pessoa
    {
        public string CPF { get { return _documento; } }
        public string Nome { get { return _nome; }  }

        public PessoaFisica(string cpf, string nome) : base(nome, cpf)
        {            
        }
    }
}
