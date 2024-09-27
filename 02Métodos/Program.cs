using System;
namespace _02Métodos;

class Program
{
    static void Main(string[] args)
    {
        Pessoa obj = new Pessoa();
        obj.apresentar();
        obj.apresentar("Lucas");
        obj.apresentar("Lucas", 27);
    }
}
