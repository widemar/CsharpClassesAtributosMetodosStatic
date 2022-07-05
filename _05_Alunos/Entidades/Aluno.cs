using System.Globalization;

namespace _05_Alunos.Entidades;

public class Aluno
{
    private string Nome { get; set; }
    private double NotaUm { get; set; }
    private double NotaDois { get; set; }
    private double NotaTres { get; set; }

    public Aluno(string nome, double notaUm, double notaDois, double notaTres)
    {
        Nome = nome;
        NotaUm = notaUm;
        NotaDois = notaDois;
        NotaTres = notaTres;
    }

    private double NotaFinal() => NotaUm + NotaDois + NotaTres;

    private string SituacaoAluno()
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