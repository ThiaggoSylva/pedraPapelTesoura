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
    if (jogada == 1) 
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
    else if (jogada == 2) 
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
    else 
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
