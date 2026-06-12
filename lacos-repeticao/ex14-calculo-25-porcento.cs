// Exercício 14 - Cálculo de 25%
// Lê valores até o usuário digitar 0. Para cada valor, calcula e exibe 25%.
// CORREÇÃO: trocado double.Parse por TryParse para evitar crash em entrada inválida.

double valor;

do
{
    Console.Write("Digite um valor (ou 0 para sair): ");

    if (!double.TryParse(Console.ReadLine(), out valor))
    {
        Console.WriteLine("Valor inválido. Tente novamente.");
        valor = -1; // garante que o loop não encerra
        continue;
    }

    if (valor != 0)
    {
        double resultado = valor * 0.25;
        Console.WriteLine($"25% de {valor:F2} é: {resultado:F2}");
    }

} while (valor != 0);

Console.WriteLine("Programa encerrado.");
