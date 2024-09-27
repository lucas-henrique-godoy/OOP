using System;

class Pessoa 
{
    // Atributos
    public string nome = string.Empty; // Inicializa 'nome' com uma string vazia para evitar o aviso CS8618 sobre valor não nulo.
    public int idade;     

    // Métodos
    public void Mensagem()
    {
        Console.WriteLine("Olá " + nome + ", você tem " + idade + " anos.");
    }
}

// Exemplo de uso
class Program
{
    static void Main()
    {
        Pessoa pessoa = new Pessoa();
        pessoa.nome = "Lucas";
        pessoa.idade = 27;
        pessoa.Mensagem(); // Saída: Olá Lucas, você tem 27 anos.
    }
}
