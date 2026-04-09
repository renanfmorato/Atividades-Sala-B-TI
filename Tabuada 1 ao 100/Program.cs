using System;
using System.Text;

class Program
{
    static void Main()
    {
        // 1. Configuração para suportar símbolos e organização visual
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("==========================================");
        Console.WriteLine("   🚀 SUPER TABUADA PROFISSIONAL (1-100)  ");
        Console.WriteLine("==========================================\n");

        // LAÇO EXTERNO (i): Define qual tabuada estamos calculando (do 1 até o 100)
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine($"--- 🔢 TABUADA DO {i} ---");

            // LAÇO INTERNO (j): Define o multiplicador (de 1 a 10)
            // Para cada volta do 'i', este laço executa 10 vezes.
            for (int j = 1; j <= 10; j++)
            {
                int resultado = i * j;

                // Exibição formatada: i x j = resultado
                Console.WriteLine($"{i} x {j} = {resultado}");
            }

            // Espaço visual entre as tabuadas para facilitar a leitura
            Console.WriteLine();
        }

        Console.WriteLine("==========================================");
        Console.WriteLine("✅ Fim do processamento de 1000 operações!");
        Console.WriteLine("==========================================");

        // Mantém o console aberto
        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
