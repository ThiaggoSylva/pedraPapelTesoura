using System;
using System.IO;

public static class RankingHelper
{
    private static string caminho = "ranking.txt";

    public static void SalvarResultado(string vencedor)
    {
        string linha = $"{DateTime.Now} - {vencedor}";
        File.AppendAllText(caminho, linha + Environment.NewLine);

        Console.WriteLine("\nResultado salvo no ranking!");
    }
}