//Renan Bezerra Fernandes Morato
using System;

class Program
{
    static void Main()
    {
        // Declaração de variáveis
        string nome;
        double peso, altura, imc;

        Console.WriteLine("--- SISTEMA DE CÁLCULO DE IMC ---");

        // Entrada de dados
        Console.Write("Digite o seu nome: ");
        nome = Console.ReadLine();

        Console.Write("Digite o seu peso (kg): ");
        peso = double.Parse(Console.ReadLine());

        Console.Write("Digite a sua altura (m) - Ex: 1,75: ");
        altura = double.Parse(Console.ReadLine());

        // Processamento (Cálculo)
        // altura * altura é o mesmo que altura ao quadrado
        imc = peso / (altura * altura);

        // Saída de dados
        Console.WriteLine("\nOlá, " + nome + "!");
        Console.WriteLine("Seu IMC atual é: " + imc.ToString("F2")); // "F2" limita a 2 casas decimais

        // Classificação usando Switch (com filtros de comparação)
        Console.Write("Classificação: ");

        // No C# moderno, podemos usar o switch assim:
        string resultado = imc switch
        {
            < 18.5 => "Abaixo do peso",
            < 25 => "Peso normal",
            < 30 => "Sobrepeso",
            _ => "Obesidade"
        };

        Console.WriteLine(resultado);
        Console.WriteLine("---------------------------------");
    }
}
