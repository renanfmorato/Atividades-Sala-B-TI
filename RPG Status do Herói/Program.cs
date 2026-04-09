//Renan Bezerra Fernandes Morato
using System;

class Program
{
    static void Main()
    {
        // --- 1. Declaração do Herói ---
        string nomeHeroi = "Aragorn";

        // --- 2. Soma (Ataque Total) ---
        int ataqueBase = 15;
        int bonusArma = 10;
        int ataqueTotal = ataqueBase + bonusArma;

        // --- 3. Subtração (Dano Sofrido) ---
        double vidaInimigo = 150.5;
        double danoSofrito = 50.5;
        double vidaRestante = vidaInimigo - danoSofrito;

        // --- 4. Multiplicação (Moedas de Ouro) usando VAR ---
        float moedasIniciais = 25.50f;
        // O compilador entende que 'moedasFinais' é float por causa do cálculo
        var moedasFinais = moedasIniciais * 2f;

        // --- 5. Divisão (Média de XP) ---
        long xpTotal = 9000000000; // Um valor bem alto para justificar o long
        long xpMediaPorNivel = xpTotal / 2;

        // --- 6. Validação ---
        bool entendiMateria = true;

        // --- SAÍDA: Contando a história no Console ---
        Console.WriteLine("=== STATUS DO HERÓI: " + nomeHeroi + " ===");
        Console.WriteLine("O ataque total do herói é: " + ataqueTotal);
        Console.WriteLine("A vida restante do inimigo após o golpe é: " + vidaRestante);
        Console.WriteLine("O herói agora possui " + moedasFinais + " moedas de ouro (Bônus de Vitória!).");
        Console.WriteLine("A média de XP por nível acumulada é de: " + xpMediaPorNivel);

        Console.WriteLine("---");

        // Verificação final
        if (entendiMateria)
        {
            Console.WriteLine("Resultado do Aluno: Missão Cumprida! Aprendi os tipos de dados.");
        }
        else
        {
            Console.WriteLine("Resultado do Aluno: Preciso de mais poções de conhecimento...");
        }

        // Manter o console aberto
        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
