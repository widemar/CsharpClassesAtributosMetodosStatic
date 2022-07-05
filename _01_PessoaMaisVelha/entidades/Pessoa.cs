namespace _01_PessoaMaisVelha.entidades;

public class Pessoa
{
    public string Nome { get; private set; }
    public int Idade { get; private set; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}