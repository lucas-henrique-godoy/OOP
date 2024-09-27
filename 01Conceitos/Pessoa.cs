using System;

class Pessoa 
{
    // Atributos
    public string nome = string.Empty; // Inicializa 'nome' com uma string vazia para evitar o aviso CS8618 sobre valor não nulo.
    public int idade;     

    // Métodos
    public void mensagem()
    {
        Console.WriteLine("Olá " + nome + ", você tem " + idade + " anos.");
    }
}

