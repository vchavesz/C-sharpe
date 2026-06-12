// Exercício 11 - Soma de 1 até N
// Lê um número inteiro positivo N e exibe a soma de todos os números de 1 até N.
// CORREÇÃO: adicionado TryParse para evitar crash em entrada inválida.

Console.Write("Digite um número inteiro positivo: ");
if (!int.TryParse(Console.ReadLine(), out int N) || N <= 0)
{
    Console.WriteLine("Número inválido. Informe um inteiro positivo.");
    return;
}

int soma = 0;
for (int i = 1; i <= N; i++)
{
    soma += i;
}

Console.WriteLine($"A soma dos números de 1 até {N} é: {soma}");
