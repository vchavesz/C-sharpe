// See https://aka.ms/new-console-template for more information

Console.WriteLine( "Insira o primeiro número: ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine( "Insira o segundo número: ");
int y = int.Parse(Console.ReadLine());


if (x > y)
{
    Console.WriteLine("O primeiro numero e maior que o segundo. ");
}

else if (x == y)
{
    Console.WriteLine(" Os dois numeros são iguais. ");
}

else 
{
    Console.WriteLine("O segundo numero é maior que o primeiro. ");
}
