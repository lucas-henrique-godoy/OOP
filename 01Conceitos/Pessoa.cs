using System;

    class Pessoa 
    {
        // Atributos
        public string nome = string.Empty;
        public int idade; 

        // Métodos
        public void mensagem() // Mudado para void
        {
            Console.WriteLine("Olá " + nome + ", você tem " + idade + " anos.");
        }
    }

    

