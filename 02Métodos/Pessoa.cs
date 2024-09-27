using System;

namespace _02Métodos;

class Pessoa  // EXEMPLO DE SOBRECARGA DE MÉTODOS.
{
    // Método 01 - SEM PARÂMETRO
    public void apresentar()
    {
        Console.WriteLine("Olá!!!");
    }


    // Método 02 - COM 1 PARÂMETRO DE NOME
     public void apresentar(string nome)
    {   
        Console.WriteLine("Olá " + nome);
    }


    //Método 03 - COM 2 PARÂMETROS NOME E IDADE
     public void apresentar(string nome, int idade)
    {
        Console.WriteLine("Olá " + nome + " você tem " + idade + " anos! ");
    }
}