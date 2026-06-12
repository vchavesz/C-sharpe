// Exercício 16 - Média de Números Decimais
// Lê 4 números decimais (com parte fracionária), exibe todos e calcula a média.

double[] numeros = new double[4];

for (int i = 0; i < numeros.Length; i++)
{
    while (true)
    {
        Console.Write($"Digite o {i + 1}º número decimal: ");
        string entrada = Console.ReadLine() ?? "";

        if (double.TryParse(entrada, out double numero) && numero % 1 != 0)
        {
            numeros[i] = numero;
            break;
        }

        Console.WriteLine("Número inválido ou sem parte decimal. Tente novamente. (ex: 3,5)");
    }
}

Console.WriteLine("\nNúmeros digitados:");
foreach (double n in numeros)
    Console.WriteLine($"  {n}");

double soma = 0;
foreach (double n in numeros)
    soma += n;

double media = soma / numeros.Length;
Console.WriteLine($"\nMédia dos 4 números: {media:F2}");
