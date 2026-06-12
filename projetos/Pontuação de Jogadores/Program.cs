string[] jogadores = new string[8];
int contador = 0;

while ( contador <= 7 ) {
    Console.WriteLine($"Insira o apelido do jogador {contador + 1}");
    jogadores[contador] = Console.ReadLine();
    Console.Clear();
    contador = contador + 1; // contador++
}

int[] vitorias = new int[8];

for (int contador2 = 0; contador2 <= 7; contador2++) {
    Console.WriteLine($"Insira o número de vitórias do jogador {contador2 + 1}");
    vitorias[contador2] = int.Parse(Console.ReadLine()); // Converter entrada em int
    Console.Clear();
}

int[] derrotas = new int[8]; // Array com 8 elementos
int contador3 = 0;

do {
    Console.WriteLine($"Insira o número de derrotas do jogador {contador3 + 1}");
    derrotas[contador3] = int.Parse(Console.ReadLine());
    Console.Clear();
    contador3 += 1; // contador3 = contador3 + 1; ou contador3++;
} while( contador3 <= 7 );

int[] saldo = new int[8];

for(int contador4 = 0; contador4 <= 7; contador4++ ) {
    saldo[contador4] = vitorias[contador4] - derrotas[contador4];
    Console.WriteLine($"Saldo do jogador {contador4 + 1} : {saldo[contador4]}");
}

Console.Clear();

// Declaração do método ExibeCabecalho
void ExibeCabecalho() {
    // Bloco de código do método
    Console.WriteLine("-----------------------------------------------");
    Console.WriteLine("| APELIDO       | VITÓRIAS | DERROTAS | SALDO |");
    Console.WriteLine("| --------------|----------|----------|-------|");
}

ExibeCabecalho(); // Invocação do método ExibeCabecalho

contador = 0; // Retornar o contador para zero

while ( contador <= 7 ) {
    Console.Write($"| {jogadores[contador]} ");
    Console.Write($"|   {vitorias[contador] }   ");
    Console.Write($"|   {derrotas[contador] }   ");
    Console.WriteLine($"|   {saldo[contador] }   |");
    contador++;
}