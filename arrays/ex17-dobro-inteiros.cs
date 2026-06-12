// Exercício 17 - Dobro de Números Inteiros
// Lê 6 números inteiros, exibe cada um com seu dobro.

int[] numeros = new int[6];

for (int i = 0; i < numeros.Length; i++)
{
    while (true)
    {
        Console.Write($"Digite o {i + 1}º número inteiro: ");
        string entrada = Console.ReadLine() ?? "";

        if (int.TryParse(entrada, out int numero))
        {
            numeros[i] = numero;
            break;
        }

        Console.WriteLine("Entrada inválida. Digite um número inteiro.");
    }
}

Console.WriteLine("\nNúmero → Dobro:");
foreach (int n in numeros)
{
    Console.WriteLine($"  {n} → {n * 2}");
}
