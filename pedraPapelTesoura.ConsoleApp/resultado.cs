public static class Resultado
{
    public static string VerificarVencedor(int j1, int j2)
    {
        if (j1 == j2)
            return "Empate!";

        if (
            (j1 == 1 && j2 == 3) ||
            (j1 == 3 && j2 == 2) ||
            (j1 == 2 && j2 == 1)
        )
            return "Jogador 1 venceu!";

        return "Jogador 2 venceu!";
    }
}