using System.Globalization;

namespace _05_Alunos.Entidades;

public class Aluno
{
    public string Nome { get; private set; }
    public double NotaUm { get; private set; }
    public double NotaDois { get; private set; }
    public double NotaTres { get; private set; }

    public Aluno(string nome, double notaUm, double notaDois, double notaTres)
    {
        Nome = nome;
        NotaUm = notaUm;
        NotaDois = notaDois;
        NotaTres = notaTres;
    }

    public double NotaFinal() => NotaUm + NotaDois + NotaTres;

    public string SituacaoAluno()
    {
        string mensagem = NotaFinal() >= 60.0
            ? "PASS"
            : $"FAILED\nFALTARAM {(60 - NotaFinal()).ToString("F2", CultureInfo.InvariantCulture)} PONTOS.";
        return mensagem;
    }

    public override string ToString()
    {
        return $"NOTA FINAL = {NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}\n" +
               $"{SituacaoAluno()}";
    }
}