namespace _02_SalarioMedio.Entidades;

public class Funcionario
{
    public string Nome { get; private set; }
    public double Salario { get; private set; }

    public Funcionario(string nome, double salario)
    {
        Nome = nome;
        Salario = salario;
    }
}