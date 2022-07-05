using _01_PessoaMaisVelha.entidades;

Console.WriteLine("Dados da primeira pessoa: ");
Console.Write("Nome: ");
string nomeUm = Console.ReadLine()!;
Console.Write("Idade: ");
int idadeUm = int.Parse(Console.ReadLine()!);
Pessoa pessoaUm = new Pessoa(nomeUm, idadeUm);

Console.WriteLine("Dados da segunda pessoa: ");
Console.Write("Nome: ");
string nomeDois = Console.ReadLine()!;
Console.Write("Idade: ");
int idadeDois = int.Parse(Console.ReadLine()!);
Pessoa pessoaDois = new Pessoa(nomeDois, idadeDois);

string pessoaMaisVelha = pessoaUm.Idade > pessoaDois.Idade ? pessoaUm.Nome : pessoaDois.Nome;

Console.WriteLine($"Pessoa mais velha: {pessoaMaisVelha}");
