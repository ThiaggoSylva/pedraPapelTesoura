public static class JogadaHelper
{
    public static string ObterNome(int jogada)
    {
        if (jogada == 1) return "Pedra";
        if (jogada == 2) return "Papel";
        return "Tesoura";
    }

    public static void ExibirDesenho(int jogada)
{
    if (jogada == 1) // Pedra
    {
        Console.WriteLine(@"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
");
    }
    else if (jogada == 2) // Papel
    {
        Console.WriteLine(@"
     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)
");
    }
    else // Tesoura
    {
        Console.WriteLine(@"
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)
");
    }
}
}
