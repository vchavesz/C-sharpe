// See https://aka.ms/new-console-template for more information
Console.WriteLine( "insira nota 1 : ");
int nota1 = int.Parse(Console.ReadLine());

Console.WriteLine( "insira nota 2 : ");
int nota2 = int.Parse(Console.ReadLine());

Console.WriteLine( "insira nota 3 : ");
int nota3 = int.Parse(Console.ReadLine());

int mediaAritmetica = (nota1 + nota2 + nota3) / 3;

if(mediaAritmetica >= 6)
{
    Console.WriteLine("Aluno aprovado com media: " + mediaAritmetica);
}

else if(mediaAritmetica < 6)
{
    Console.WriteLine("Aluno reprovado com media: " + mediaAritmetica);
}