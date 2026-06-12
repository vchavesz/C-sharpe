string titulo = @"
   ___       _                          
  |_  |     | |                         
    | | ___ | | _____ _ __  _ __   ___  
    | |/ _ \| |/ / _ \ '_ \| '_ \ / _ \ 
/\__/ / (_) |   <  __/ | | | |_) | (_) |
\____/ \___/|_|\_\___|_| |_| .__/ \___/ 
                           | |          
                           |_|     
";

string opcoes = @"
0 = Pedra
1 = Papel
2 = Tesoura
";

Console.WriteLine(titulo);

int jogadorA = LerJogada("Jogador A");
Console.Clear();

int jogadorB = LerJogada("Jogador B");
Console.Clear();

if ((jogadorA == 0 && jogadorB == 2) ||
    (jogadorA == 1 && jogadorB == 0) ||
    (jogadorA == 2 && jogadorB == 1))
{
    Console.WriteLine("Parabens! O jogador A venceu.");
}
else if (jogadorA != jogadorB)
{
    Console.WriteLine("Parabens! O jogador B venceu.");
}
else
{
    Console.WriteLine("O jogo empatou.");
}

int LerJogada(string jogador)
{
    while (true)
    {
        Console.WriteLine($"{jogador}, insira sua jogada:");
        Console.WriteLine(opcoes);
        Console.Write("Opcao: ");

        if (int.TryParse(Console.ReadLine(), out int jogada) && jogada >= 0 && jogada <= 2)
            return jogada;

        Console.WriteLine("Jogada invalida. Escolha 0, 1 ou 2.");
    }
}
