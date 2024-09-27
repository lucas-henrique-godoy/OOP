using System;

class Aluno 
{
    // Atributos da classe Aluno
    public string nome;      // Nome do aluno
    public double nota1;     // Primeira nota do aluno
    public double nota2;     // Segunda nota do aluno

    // Método para calcular a média das notas
    public double media()
    {
        // Retorna a média aritmética das duas notas
        return (nota1 + nota2) / 2;
    }

    // Método para determinar a situação do aluno com base na média
    public string situacao(double media)
    {
        // Retorna "Aprovado" se a média for maior ou igual a 7,
        // caso contrário, retorna "Reprovado". Usa operador ternário.
        return media >= 7 ? "Aprovado" : "Reprovado";
    }

    // Método para exibir uma mensagem com a situação do aluno
    public void mensagem()
    {
        // Chama o método media() para calcular a média e armazena o resultado
        double obterMedia = media();

        // Chama o método situacao() passando a média para determinar a situação do aluno
        string obterSituacao = situacao(obterMedia);

        // Exibe a mensagem com o nome do aluno, sua situação e média
        Console.WriteLine(nome + " está " + obterSituacao + " com média " + obterMedia);
    }
}
