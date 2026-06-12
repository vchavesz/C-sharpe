// Exercício 09 - Variável C Condicional
// Se A == B, C = A + B. Caso contrário, C = A * B.

Console.Write("Insira o valor de A: ");
if (!int.TryParse(Console.ReadLine(), out int A)) { Console.WriteLine("Valor inválido."); return; }

Console.Write("Insira o valor de B: ");
if (!int.TryParse(Console.ReadLine(), out int B)) { Console.WriteLine("Valor inválido."); return; }

int C;

if (A == B)
{
    C = A + B;
    Console.WriteLine($"A ({A}) == B ({B}) → C = A + B = {C}");
}
else
{
    C = A * B;
    Console.WriteLine($"A ({A}) ≠ B ({B}) → C = A × B = {C}");
}
