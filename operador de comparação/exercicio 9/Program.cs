
Console.WriteLine( "insira nota A : ");
int A = int.Parse(Console.ReadLine());

Console.WriteLine( "insira nota B : ");
int B = int.Parse(Console.ReadLine());

int C;

if (A == B)
{
    C = A + B;
    Console.WriteLine("Variável C é igual a: " + C);
}

else
{
    C = A * B;
    Console.WriteLine("Variável C é igual a: " + C);
}