//Renan Bezerra Fernandes Morato
using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("--- 🏦 SIMULADOR DE JUROS SIMPLES ---");

        // Entrada de dados com TryParse para segurança
        Console.Write("Digite o Capital Inicial (R$): ");
        float.TryParse(Console.ReadLine(), out float capital);

        Console.Write("Digite a Taxa de Juros Mensal (%): ");
        float.TryParse(Console.ReadLine(), out float taxaPercentual);

        Console.Write("Digite o Tempo (meses): ");
        int.TryParse(Console.ReadLine(), out int tempo);

        // Convertendo a taxa de porcentagem para decimal (ex: 5% vira 0,05)
        float taxaDecimal = taxaPercentual / 100;

        // Cálculo dos juros totais
        float jurosTotais = capital * taxaDecimal * tempo;
        float montanteFinal = capital + jurosTotais;

        Console.WriteLine("\n--- 📈 EVOLUÇÃO MÊS A MÊS ---");

        // Usando o laço 'for' para mostrar o crescimento
        for (int mes = 1; mes <= tempo; mes++)
        {
            float jurosAcumulados = capital * taxaDecimal * mes;
            float saldoAtual = capital + jurosAcumulados;

            Console.WriteLine($"Mês {mes}: Juros: R$ {jurosAcumulados:F2} | Saldo: R$ {saldoAtual:F2}");
        }

        Console.WriteLine("-------------------------------------");
        Console.WriteLine($"💰 Valor Final Total: R$ {montanteFinal:F2}");
        Console.WriteLine("-------------------------------------");

        Console.ReadKey();
    }
}
