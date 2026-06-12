// Exercício 05 - Comparação de Dois Números
// Lê dois números inteiros e informa qual é o maior, ou se são iguais.

Console.Write("Insira o primeiro número: ");
if (!int.TryParse(Console.ReadLine(), out int x))
{
    Console.WriteLine("Valor inválido.");
    return;
}

Console.Write("Insira o segundo número: ");
if (!int.TryParse(Console.ReadLine(), out int y))
{
    Console.WriteLine("Valor inválido.");
    return;
}

if (x > y)
    Console.WriteLine($"{x} é maior que {y}.");
else if (x == y)
    Console.WriteLine($"Os dois números são iguais ({x}).");
else
    Console.WriteLine($"{y} é maior que {x}.");
