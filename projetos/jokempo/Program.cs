// Declaração das variáveis
int jogadorA; 
int jogadorB;
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
0 = Pedra 🪨
1 = Papel 🧻
2 = Tesoura ✂️
";

string vitoria = @"
    PARABÉNS 🎆🏆🎆!!!
";

Console.WriteLine( titulo );

// Número de 0 a 2: 0 = Pedra, 1 = Papel, 2 = Tesoura
// Laço de repetição para captura de jogada do jogador A
do {
    Console.WriteLine("Jogador A, insira sua jogada");
    Console.WriteLine(opcoes);
    jogadorA = int.Parse(Console.ReadLine());
} while( jogadorA < 0 || jogadorA > 2 );

Console.Clear();

// Laço de repetição para captura de jogada do jogador B
do {
    Console.WriteLine("Jogador B, insira sua jogada [0 = Pedra, 1 = Papel, 2 = Tesoura]:");
    jogadorB = int.Parse(Console.ReadLine());
} while( jogadorB < 0 || jogadorB > 2 );

Console.Clear();

/**
 * 0 = Pedra
 * 1 = Papel
 * 2 = Tesoura
 */
// Verifica se JogadorA é o vencedor
if ( (jogadorA == 0 && jogadorB == 2) || (jogadorA == 1 && jogadorB == 0 ) || (jogadorA == 2 && jogadorB == 1) ) {
    Console.WriteLine(vitoria);
    Console.WriteLine("O jogador A é o vencedor!");
} else if ( jogadorA != jogadorB ) {
    // Se a jogada do jogadorA for diferente da do jogadorB, podemos cravar que não há empate
    // e por exclusão o jogadorB é o vencedor
    Console.WriteLine(vitoria);
    Console.WriteLine("O jogador B é o vencedor!");
} else {
    Console.WriteLine("O jogo empatou!");
}