using System;

public static class Jogo
{
    public static void Iniciar()
    {
        Console.Clear();
        Console.WriteLine("=== Pedra, Papel ou Tesoura ===\n");

        int modoJogo = EscolherModoJogo();
        int limiteVitorias = EscolherModoSerie();

        int pontos1 = 0;
        int pontos2 = 0;

        while (pontos1 < limiteVitorias && pontos2 < limiteVitorias)
        {
            int jogador1 = LerJogada("Jogador 1");

            int jogador2 = modoJogo == 1
                ? GerarJogadaComputador()
                : LerJogada("Jogador 2");

            ExibirJogadas(jogador1, jogador2, modoJogo);

            string resultado = ResultadoHelper.VerificarVencedor(jogador1, jogador2);

            if (resultado == "Jogador 1 venceu!")
                pontos1++;
            else if (resultado == "Jogador 2 venceu!")
                pontos2++;

            ExibirResultadoColorido(resultado);
            ExibirPlacar(pontos1, pontos2);
        }

        string campeao = pontos1 > pontos2 ? "Jogador 1" : "Jogador 2";

        Console.WriteLine($"\n🏆 {campeao} venceu a partida!");

        RankingHelper.SalvarResultado(campeao);
    }

    private static int EscolherModoJogo()
    {
        while (true)
        {
            Console.WriteLine("Modo de jogo:");
            Console.WriteLine("1 - Contra Computador");
            Console.WriteLine("2 - 2 Jogadores");

            string op = Console.ReadLine()!;

            if (op == "1" || op == "2")
                return int.Parse(op);

            Console.WriteLine("Opção inválida!\n");
        }
    }

    private static int EscolherModoSerie()
    {
        while (true)
        {
            Console.WriteLine("\nModo de série:");
            Console.WriteLine("1 - Melhor de 3");
            Console.WriteLine("2 - Melhor de 5");

            string op = Console.ReadLine()!;

            if (op == "1") return 2;
            if (op == "2") return 3;

            Console.WriteLine("Opção inválida!\n");
        }
    }

    private static int LerJogada(string jogador)
    {
        while (true)
        {
            Console.WriteLine($"\n{jogador}, escolha:");
            Console.WriteLine("1 - Pedra");
            Console.WriteLine("2 - Papel");
            Console.WriteLine("3 - Tesoura");

            string entrada = Console.ReadLine()!;

            if (int.TryParse(entrada, out int jogada) && jogada >= 1 && jogada <= 3)
                return jogada;

            Console.WriteLine("Entrada inválida!");
        }
    }

    private static int GerarJogadaComputador()
    {
        return new Random().Next(1, 4);
    }

    private static void ExibirJogadas(int j1, int j2, int modo)
    {
        Console.WriteLine($"\nJogador 1: {JogadaHelper.ObterNome(j1)}");
        JogadaHelper.ExibirDesenho(j1);

        if (modo == 1)
            {Console.WriteLine($"Computador: {JogadaHelper.ObterNome(j2)}");
            JogadaHelper.ExibirDesenho(j2);
            }
        else
        {
            Console.WriteLine($"Jogador 2: {JogadaHelper.ObterNome(j2)}");
            JogadaHelper.ExibirDesenho(j2);
        }
    }

    

    // 🎨 Resultado com cor
    private static void ExibirResultadoColorido(string resultado)
    {
        if (resultado.Contains("1"))
            Console.ForegroundColor = ConsoleColor.Green;
        else if (resultado.Contains("2"))
            Console.ForegroundColor = ConsoleColor.Red;
        else
            Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine(resultado);
        Console.ResetColor();
    }

    private static void ExibirPlacar(int p1, int p2)
    {
        Console.WriteLine($"Placar: {p1} x {p2}\n");
    }
}