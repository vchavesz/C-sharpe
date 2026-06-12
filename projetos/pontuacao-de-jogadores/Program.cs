string[] jogadores = new string[8];
int[] vitorias = new int[8];
int[] derrotas = new int[8];
int[] saldo = new int[8];

for (int i = 0; i < jogadores.Length; i++)
{
    Console.Write($"Insira o apelido do jogador {i + 1}: ");
    jogadores[i] = LerTextoObrigatorio();
    Console.Clear();
}

for (int i = 0; i < vitorias.Length; i++)
{
    Console.Write($"Insira o numero de vitorias do jogador {i + 1}: ");
    vitorias[i] = LerInteiroNaoNegativo();
    Console.Clear();
}

for (int i = 0; i < derrotas.Length; i++)
{
    Console.Write($"Insira o numero de derrotas do jogador {i + 1}: ");
    derrotas[i] = LerInteiroNaoNegativo();
    Console.Clear();
}

for (int i = 0; i < saldo.Length; i++)
    saldo[i] = vitorias[i] - derrotas[i];

ExibirCabecalho();

for (int i = 0; i < jogadores.Length; i++)
    Console.WriteLine($"| {jogadores[i],-12} | {vitorias[i],8} | {derrotas[i],8} | {saldo[i],5} |");

void ExibirCabecalho()
{
    Console.WriteLine("-----------------------------------------------");
    Console.WriteLine("| APELIDO       | VITORIAS | DERROTAS | SALDO |");
    Console.WriteLine("| --------------|----------|----------|-------|");
}

string LerTextoObrigatorio()
{
    while (true)
    {
        string texto = Console.ReadLine() ?? "";
        if (!string.IsNullOrWhiteSpace(texto))
            return texto.Trim();

        Console.Write("Entrada vazia. Digite novamente: ");
    }
}

int LerInteiroNaoNegativo()
{
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int valor) && valor >= 0)
            return valor;

        Console.Write("Valor invalido. Digite um numero inteiro maior ou igual a zero: ");
    }
}
