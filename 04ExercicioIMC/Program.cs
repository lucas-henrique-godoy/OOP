using System;

namespace ExercicioIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar objeto da classe Pessoa
            Pessoa pessoa = new Pessoa
            {
                Peso = 67.25,  // Usando a propriedade Peso para definir o peso da pessoa
                Altura = 1.80  // Usando a propriedade Altura para definir a altura da pessoa
            };

            // Chama o método ExibirMensagem da classe Pessoa
            // Este método calcula o IMC e exibe a situação correspondente
            pessoa.ExibirMensagem();
        }
    }
}
