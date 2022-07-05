using System.Globalization;
using _03_Retangulo.Entidades;

Console.WriteLine("Entre com a largura e altura do retângulo: ");
double largura = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
double altura = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

Retangulo retangulo = new Retangulo(largura, altura);

Console.WriteLine(retangulo);