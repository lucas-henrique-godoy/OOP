using System;

// Define o namespace do projeto
namespace _03ExercicioEscolar
{
    // Classe principal do programa
    class Program
    {
        // Método de entrada do programa
        static void Main(string[] args)
        {
            // Instanciar um objeto da classe Aluno
            Aluno a = new Aluno();

            // Atribuir um nome ao aluno
            a.nome = "Lucas";

            // Atribuir notas ao aluno
            a.nota1 = 5;  // Primeira nota
            a.nota2 = 3;  // Segunda nota

            // Chama o método mensagem() para exibir a situação do aluno
            a.mensagem();      
        }
    }
}
