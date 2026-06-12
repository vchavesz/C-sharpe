// Exercício 08 - Comparar Soma com Terceiro Número
// Lê A, B e C e compara a soma de A+B com C.

Console.Write("Insira o valor de A: ");
if (!int.TryParse(Console.ReadLine(), out int A)) { Console.WriteLine("Valor inválido."); return; }

Console.Write("Insira o valor de B: ");
if (!int.TryParse(Console.ReadLine(), out int B)) { Console.WriteLine("Valor inválido."); return; }

Console.Write("Insira o valor de C: ");
if (!int.TryParse(Console.ReadLine(), out int C)) { Console.WriteLine("Valor inválido."); return; }

int soma = A + B;
Console.WriteLine($"A + B = {soma}");

if (soma > C)
    Console.WriteLine($"A soma de A+B ({soma}) é MAIOR que C ({C}).");
else if (soma < C)
    Console.WriteLine($"A soma de A+B ({soma}) é MENOR que C ({C}).");
else
    Console.WriteLine($"A soma de A+B ({soma}) é IGUAL a C ({C}).");
