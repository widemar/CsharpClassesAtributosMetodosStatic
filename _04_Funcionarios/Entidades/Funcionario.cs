using System.Globalization;

namespace _04_Funcionarios.Entidades;

public class Funcionario
{
    private string Nome { get; set; }
    private double SalarioBruto { get; set; }
    private double Imposto { get; set; }

    public Funcionario(string nome, double salarioBruto, double imposto)
    {
        Nome = nome;
        SalarioBruto = salarioBruto;
        Imposto = imposto;
    }

    private double SalarioLiquido() => SalarioBruto - Imposto;
    public void AumentarSalario(double porcentagem) => SalarioBruto += SalarioBruto * (porcentagem / 100);

    public override string ToString()
    {
        return $"{Nome}, R${SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}";
    }
}