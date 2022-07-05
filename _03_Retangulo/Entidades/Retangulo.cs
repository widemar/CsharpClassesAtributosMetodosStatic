using System.Globalization;

namespace _03_Retangulo.Entidades;

public class Retangulo
{
    private double Largura { get; set; }
    private double Altura { get; set; }

    public Retangulo(double largura, double altura)
    {
        Largura = largura;
        Altura = altura;
    }

    private double Area() => Largura * Altura;
    private double Perimetro() => 2 * (Largura + Altura);
    private double Diagonal() => Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));

    public override string ToString()
    {
        return $"AREA = {Area().ToString("F2", CultureInfo.InvariantCulture)}\n" +
               $"PERÍMETRO = {Perimetro().ToString("F2", CultureInfo.InvariantCulture)}\n" +
               $"DIAGONAL = {Diagonal().ToString("F2", CultureInfo.InvariantCulture)}\n";
    }
}