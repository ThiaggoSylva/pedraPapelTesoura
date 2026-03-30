public static class JogadaHelper
{
    public static string ObterNome(int jogada)
    {
        if (jogada == 1) return "Pedra";
        if (jogada == 2) return "Papel";
        return "Tesoura";
    }
}