using System;
namespace _02Métodos;

class Program
{
    static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa();
        pessoa.apresentar();
        pessoa.apresentar("Lucas");
        pessoa.apresentar("Lucas", 27);
    }
}
