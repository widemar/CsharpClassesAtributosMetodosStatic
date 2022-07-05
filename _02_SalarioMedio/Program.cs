using System.Globalization;
using _02_SalarioMedio.entidades;

CultureInfo info = CultureInfo.InvariantCulture;

Console.WriteLine("Dados do primeiro funcionário:");
Console.Write("Nome: ");
string nomeUm = Console.ReadLine()!;
Console.Write("Salário: ");
double salarioUm = double.Parse(Console.ReadLine()!, info);
Funcionario funcionarioUm = new Funcionario(nomeUm, salarioUm);

Console.WriteLine("Dados do segundo funcionário:");
Console.Write("Nome: ");
string nomeDois = Console.ReadLine()!;
Console.Write("Salário: ");
double salarioDois = double.Parse(Console.ReadLine()!, info);
Funcionario funcionarioDois = new Funcionario(nomeDois, salarioDois);

double salarioMedio = (funcionarioUm.Salario + funcionarioDois.Salario) / 2;
Console.WriteLine($"Salário médio = {salarioMedio.ToString("F2", info)}");