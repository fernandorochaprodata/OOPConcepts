// See https://aka.ms/new-console-template for more information
using Core;
using Core.Samples;

PessoaFisica pessoaFisica = new PessoaFisica("12345678901", "João da Silva");
PessoaJuridica pessoaJuridica = new PessoaJuridica("12345678901234", "Empresa da Silva");
PessoaJuridica pessoaJuridica2 = new PessoaJuridica("", "Não Existe");
PessoaJuridica pessoaJuridica3= new PessoaJuridica("                   ", "Em branco");
PessoaJuridica pessoaJuridica4= new PessoaJuridica("12345678901234", "Empresa da Silva");
new PessoaFisica("", "");
List<PessoaFisica> pessoaFisicasList = new List<PessoaFisica>() { pessoaFisica };
List<PessoaJuridica> pessoaJuridicasList = new List<PessoaJuridica>() { pessoaJuridica, pessoaJuridica2, pessoaJuridica3, pessoaJuridica4, null };
List<Pessoa> pessoas = new List<Pessoa>() { pessoaFisica, pessoaJuridica, pessoaJuridica2, pessoaJuridica3, pessoaJuridica4, null } ;
pessoas.Add(null);
pessoas.Add(null);
pessoas.Add(null);
pessoas.Add(null);
pessoas.Add(null);
pessoas.Add(null);
pessoas.Add(null);


Int32 i = 0;
short s = 0;
int y = 0;
i = y;

Conta conta = new Conta(pessoaFisica);
Conta contaJuridica = new Conta(pessoaJuridica);

foreach (var item in pessoas)
{    
    Console.WriteLine("Nome: {0} - Valido: {1}", (item)?.NomePessoa, ValidarPessoa(item));
}



//Console.Write("Validador de Passagem");
//var card = new Card(10.0f, 5.0f, 1024, "SamA");
//var transaction = card.AdicionarDinheiro(5.0M);



static bool ValidarPessoa(Pessoa pessoa)
{
    if (pessoa == null) return false;
    if (string.IsNullOrEmpty(pessoa.Documento) || string.IsNullOrWhiteSpace(pessoa.Documento)) return false;

    return true;
}


//transaction.Valor = 10.0M;

//Console.WriteLine($"Transação realizada com sucesso. Valor: {transaction.Valor} Data: {transaction.Data} Tipo: {transaction.Type}");