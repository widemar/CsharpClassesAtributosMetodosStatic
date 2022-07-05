using System.Globalization;
using _04_Funcionarios.Entidades;

Console.Write("Nome: ");
string nome = Console.ReadLine()!;
Console.Write("Salário Bruto: ");
double salarioBruto = double.Parse(Console.ReadLine()!,CultureInfo.InvariantCulture);
Console.Write("Imposto: ");
double imposto = double.Parse(Console.ReadLine()!,CultureInfo.InvariantCulture);

Funcionario funcionario = new Funcionario(nome, salarioBruto, imposto);

Console.WriteLine($"Funcionário: {funcionario}");

Console.Write("Qual a porcentagem para aumentar o salário? ");
double porcentagem = double.Parse(Console.ReadLine()!,CultureInfo.InvariantCulture);
funcionario.AumentarSalario(porcentagem);

Console.WriteLine($"Dados atualizados: {funcionario}");