using System.Globalization;
using _05_Alunos.Entidades;

Console.WriteLine("Informe o nome e as notas do aluno:");
string nome = Console.ReadLine()!;
double notaUm = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
double notaDois = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
double notaTres = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

Aluno aluno = new Aluno(nome, notaUm, notaDois, notaTres);

Console.WriteLine(aluno);