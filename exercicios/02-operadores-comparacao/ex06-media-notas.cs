// Exercício 06 - Média das Notas
// Lê três notas, calcula a média e informa se o aluno foi aprovado ou reprovado.
// CORREÇÃO: trocado int por double para suportar notas decimais (ex: 7.5).

Console.Write("Insira a nota 1: ");
if (!double.TryParse(Console.ReadLine(), out double nota1))
{
    Console.WriteLine("Nota inválida.");
    return;
}

Console.Write("Insira a nota 2: ");
if (!double.TryParse(Console.ReadLine(), out double nota2))
{
    Console.WriteLine("Nota inválida.");
    return;
}

Console.Write("Insira a nota 3: ");
if (!double.TryParse(Console.ReadLine(), out double nota3))
{
    Console.WriteLine("Nota inválida.");
    return;
}

double media = (nota1 + nota2 + nota3) / 3.0;

if (media >= 6)
    Console.WriteLine($"Aluno APROVADO com média: {media:F2}");
else
    Console.WriteLine($"Aluno REPROVADO com média: {media:F2}");
