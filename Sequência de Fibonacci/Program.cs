//Renan Bezerra Fernandes Morato
using System;

class Program
{
    static void Main()
    {
        // Usando as linguagens (tipos e comandos) solicitadas
        int quantidade;
        int n1 = 0;
        int n2 = 1;
        int proximo;

        Console.Write("Digite quantos números da sequência você deseja ver: ");

        // Console.ReadLine para capturar a entrada do usuário
        string entrada = Console.ReadLine();
        quantidade = int.Parse(entrada);

        Console.WriteLine("Sequência de Fibonacci:");

        // O 'for' é necessário para automatizar a repetição
        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine(n1);

            // Lógica da soma
            proximo = n1 + n2;
            n1 = n2;
            n2 = proximo;
        }
    }
}
