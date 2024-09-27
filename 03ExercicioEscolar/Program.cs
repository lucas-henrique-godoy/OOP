using System;

namespace _03ExercicioEscolar;

class Program
{
    static void Main(string[] args)
    {
       // Instanciar obejto da classe Aluno
       Aluno a = new Aluno();
       a.nome = "Lucas";
       a.nota1 = 5;
       a.nota2 = 3;
       a.mensagem();      
    }
}
