// See https://aka.ms/new-console-template for more information
Console.WriteLine( "insira nota A : ");
int A = int.Parse(Console.ReadLine());

Console.WriteLine( "insira nota B : ");
int B = int.Parse(Console.ReadLine());

Console.WriteLine( "insira nota C : ");
int C = int.Parse(Console.ReadLine());

int soma = A + B;

if (A + B > C)
{
    Console.WriteLine(" A soma de A + B e maior que C. " + soma);
} 

else if (A + B < C)
{
    Console.WriteLine(" A soma de A + B e menor que C. " + soma);
}

else
{
    Console.WriteLine(" A soma de A + B e igual a C. " + soma);
}