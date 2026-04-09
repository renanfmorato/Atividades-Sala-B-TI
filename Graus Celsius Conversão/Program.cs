//Renan Bezerra Fernandes Morato
using System;

class Program
{
    static void Main()
    {
        // 1. Configuração para aceitar Emojis e acentos
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("--- 🌡️ SISTEMA DE CONVERSÃO TÉRMICA 🌡️ ---");
        Console.WriteLine("Escolha a unidade de ORIGEM:");
        Console.WriteLine("1 - Celsius (°C)");
        Console.WriteLine("2 - Fahrenheit (°F)");
        Console.WriteLine("3 - Kelvin (K)");
        Console.Write("\nOpção desejada: ");

        string opcao = Console.ReadLine();

        Console.Write("Digite o valor da temperatura: ");

        // 2. Combo TryParse + If para leitura segura
        if (float.TryParse(Console.ReadLine(), out float temp))
        {
            Console.WriteLine("\n--- 📈 Resultados da Conversão ---");

            // 3. Estrutura Switch para decidir qual fórmula usar
            switch (opcao)
            {
                case "1": // De Celsius para outros
                    float cParaF = (temp * 9 / 5) + 32;
                    float cParaK = temp + 273.15f;
                    Console.WriteLine($"✅ {temp}°C equivale a:");
                    Console.WriteLine($"🔥 {cParaF:F2}°F");
                    Console.WriteLine($"❄️ {cParaK:F2}K");
                    break;

                case "2": // De Fahrenheit para outros
                    float fParaC = (temp - 32) * 5 / 9;
                    float fParaK = (temp - 32) * 5 / 9 + 273.15f;
                    Console.WriteLine($"✅ {temp}°F equivale a:");
                    Console.WriteLine($"❄️ {fParaC:F2}°C");
                    Console.WriteLine($"🌌 {fParaK:F2}K");
                    break;

                case "3": // De Kelvin para outros
                    float kParaC = temp - 273.15f;
                    float kParaF = (temp - 273.15f) * 9 / 5 + 32;
                    Console.WriteLine($"✅ {temp}K equivale a:");
                    Console.WriteLine($"❄️ {kParaC:F2}°C");
                    Console.WriteLine($"🔥 {kParaF:F2}°F");
                    break;

                default:
                    Console.WriteLine("❌ Opção de menu inválida!");
                    break;
            }
        }
        else
        {
            // 4. Tratamento de erro se o usuário digitar letras
            Console.WriteLine("⚠️ Erro: Por favor, digite um número válido (use vírgula para decimais).");
        }

        Console.WriteLine("\n-------------------------------------------");
        Console.WriteLine("Pressione qualquer tecla para encerrar...");
        Console.ReadKey();
    }
}
