// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("--- 📐 CALCULADORA DE RAIZ QUADRADA ---");

        Console.Write("Digite um número para descobrir sua raiz: ");

        // Lendo a entrada do usuário
        if (double.TryParse(Console.ReadLine(), out double numero))
        {
            // Verificação lógica: o número não pode ser negativo
            if (numero >= 0)
            {
                // Cálculo usando a biblioteca Math
                double raiz = Math.Sqrt(numero);

                Console.WriteLine($"\n✅ A raiz quadrada de {numero} é: {raiz:F2}");

                // Prova real (Opcional)
                Console.WriteLine($"💡 Prova real: {raiz:F2} * {raiz:F2} = {raiz * raiz:F2}");
            }
            else
            {
                Console.WriteLine("❌ Erro: Não existe raiz quadrada real para números negativos!");
            }
        }
        else
        {
            Console.WriteLine("⚠️ Erro: Digite um número válido.");
        }

        Console.WriteLine("\n---------------------------------------");
        Console.ReadKey();
    }
}
