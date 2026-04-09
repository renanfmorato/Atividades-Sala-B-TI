using System;
using System.Text;

class Program
{
    static void Main()
    {
        // 1. Configuração de Saída para Emojis
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("--- 🏰 GUILDA DOS AVENTUREIROS - TRIAGEM DO DRAGÃO 🐉 ---");

        // 2. Coleta de Dados
        Console.Write("Nome do Herói: ");
        string nome = Console.ReadLine();

        Console.Write("Classe (Mago, Clérigo, Guerreiro, Druida, Anão, Elfo ou Troll): ");
        string classe = Console.ReadLine();

        Console.Write("Nível (Inteiro): ");
        int.TryParse(Console.ReadLine(), out int nivel);

        Console.Write("Pontos de Vida (HP): ");
        float.TryParse(Console.ReadLine(), out float hp);

        Console.Write("Pontos de Magia (Mana): ");
        int.TryParse(Console.ReadLine(), out int mana);

        Console.Write("Ouro na Mochila: ");
        float.TryParse(Console.ReadLine(), out float ouro);

        Console.WriteLine("\n--- ⚖️ RESULTADO DO JULGAMENTO ---");

        // 3. Regra da Raça Inimiga (Diferente e Negação)
        if (classe == "Troll" || !(nivel >= 5))
        {
            Console.WriteLine($"🚫 {nome}, você foi expulso da guilda! Ou você é um Troll ou é muito iniciante.");
        }
        else
        {
            // 4. Cálculo do Poder de Combate
            float poderBase = (nivel * 10) + (hp / 2) - 5;
            Console.WriteLine($"⚔️ Poder Base calculado: {poderBase}");

            // 5. Regra do Dano Crítico (Módulo e Igualdade)
            if (poderBase % 2 == 0)
            {
                Console.WriteLine("✨ BÔNUS: Você possui um Ataque Crítico NATURAL!");
            }

            // 6. Teste de Aptidão de Combate
            bool podeLutar = false;

            // Lógica para Classes Mágicas
            if (classe == "Mago" || classe == "Druida" || classe == "Clérigo")
            {
                if (mana >= 30 && nivel <= 100)
                {
                    podeLutar = true;
                    Console.WriteLine("🪄 Magia canalizada! Você está pronto para conjurar.");
                }
                else
                {
                    Console.WriteLine("🪵 Seu cajado falhou! Mana insuficiente ou nível muito alto para controle.");
                }
            }
            // Lógica para Classes Físicas
            else if (classe == "Guerreiro" || classe == "Anão" || classe == "Elfo")
            {
                if (hp > 20 && poderBase > 50)
                {
                    podeLutar = true;
                    Console.WriteLine("🛡️ Armadura ajustada! Seu vigor físico é suficiente.");
                }
                else
                {
                    Console.WriteLine("🩹 Você está muito ferido ou fraco para o combate físico.");
                }
            }

            // 7. Veredito Final ou Suborno
            if (podeLutar)
            {
                Console.WriteLine($"\n🔥 Veredito: {nome}, você está APTO a enfrentar o Dragão!");
            }
            else
            {
                // Regra do Suborno (OU)
                if (ouro > 1000 || classe == "Anão")
                {
                    Console.WriteLine($"\n💰 Você não pode lutar, mas o Dragão aceitou seu suborno! {nome} fugiu com vida.");
                }
                else
                {
                    Console.WriteLine($"\n💀 Veredito: {nome} virou churrasco de Dragão...");
                }
            }
        }

        Console.WriteLine("\n--- FIM DA AVENTURA ---");
        Console.ReadKey();
    }
}
