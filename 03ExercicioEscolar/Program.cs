using System;

namespace _03ExercicioEscolar;

class Program
{
    static void Main(string[] args)
    {
       // Instanciar obejto da classe Aluno
       Aluno a = new Aluno();
       a.nome = "Lucas";
       a.nota1 = 8;
       a.nota2 = 10;
       a.mensagem();      
    }
}
