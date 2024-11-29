namespace Core.Samples
{
    public abstract class Pessoa
    {
        protected string _nome;
        protected string _documento;

        public string NomePessoa { get { return _nome; } }
        public string Documento { get { return _documento; }
            set { _documento = value; }
        }


        public Pessoa(string nome, string documento)
        {
            _nome = nome;
            _documento = documento;
        }

        List<Conta> contas = new List<Conta>();

        public string GetDocumento() { return _documento; }

        public string SetDocumento(string documento) { return _documento = documento; }
    }
}
