using System;

class Pessoa 
{
    // Atributos
    public double Peso { get; set; }  // Propriedade para armazenar o peso da pessoa
    public double Altura { get; set; } // Propriedade para armazenar a altura da pessoa

    // Método para calcular o IMC (Índice de Massa Corporal)
    public double CalcularIMC()
    {
        // Retorna o valor do IMC calculado usando a fórmula: peso / (altura * altura)
        return Peso / (Altura * Altura);
    }

    // Método para retornar a situação do IMC
    public string ObterSituacao() 
    {
        // Chama o método CalcularIMC e armazena o resultado na variável imc
        double imc = CalcularIMC();

        // Verifica a faixa do IMC e retorna a situação correspondente
        if (imc < 18.5)
        {
            return "Abaixo do peso"; // Peso inferior ao normal
        }
        else if (imc >= 18.5 && imc < 25)
        {
            return "Peso normal"; // Peso saudável
        }
        else if (imc >= 25 && imc < 30)
        {
            return "Acima do peso"; // Peso levemente superior ao normal
        }
        else if (imc >= 30 && imc < 35)
        {
            return "Obesidade 1"; // Obesidade leve
        }
        else if (imc >= 35 && imc < 40)
        {
            return "Obesidade 2"; // Obesidade moderada
        }
        else
        {
            return "Obesidade 3 - Mórbida!"; // Obesidade severa
        }
    }

    // Método para exibir a mensagem do IMC e sua situação
    public void ExibirMensagem()
    {
        // Obtém o valor do IMC chamando o método CalcularIMC
        double imc = CalcularIMC();
        
        // Obtém a situação do IMC chamando o método ObterSituacao
        string situacao = ObterSituacao();
        
        // Exibe o resultado formatado com duas casas decimais
        Console.WriteLine("IMC: " + imc.ToString("F2") + " Situação: " + situacao);
    }
}
