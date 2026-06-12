// Exercício 07 - Comparação de Frutas
// Lê dois nomes de frutas e verifica se são iguais (ignora maiúsculas/minúsculas).

Console.Write("Insira o nome da primeira fruta: ");
string frutaA = Console.ReadLine() ?? "";

Console.Write("Insira o nome da segunda fruta: ");
string frutaB = Console.ReadLine() ?? "";

// MELHORIA: StringComparison.OrdinalIgnoreCase evita que "Maçã" ≠ "maçã"
if (frutaA.Equals(frutaB, StringComparison.OrdinalIgnoreCase))
    Console.WriteLine("As frutas são iguais.");
else
    Console.WriteLine($"As frutas são diferentes: \"{frutaA}\" e \"{frutaB}\".");
