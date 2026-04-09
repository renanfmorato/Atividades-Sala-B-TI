using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Configurando para suportar emojis e símbolos no console
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("--- 🧮 Teste de Mesa: Laços Aninhados ---");
        Console.WriteLine("Dica: Coloque um Breakpoint (F9) na linha do primeiro 'for'!\n");

        // LAÇO EXTERNO: Controla as linhas (ou o multiplicando)
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"▶️ Iniciando ciclo do i = {i}");

            // LAÇO INTERNO: Controla as repetições dentro de cada linha
            for (int j = 1; j <= 3; j++)
            {
                // Cálculo e exibição
                int resultado = i * j;
                Console.WriteLine($"   {i} * {j} = {resultado}");
            }

            // Linha em branco para separar os blocos de i
            Console.WriteLine("-------------------------");
        }

        Console.WriteLine("\n✅ Fim da execução. O j completou 3 voltas para cada 1 volta de i.");
        Console.ReadKey();
    }
}
