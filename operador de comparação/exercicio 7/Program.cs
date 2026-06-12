// See https://aka.ms/new-console-template for more information
Console.WriteLine(" insira nome de uma fruta: ");
string frutaA = (Console.ReadLine());

Console.WriteLine(" insira nome de uma fruta: ");
string frutaB = (Console.ReadLine());

if (frutaA == frutaB)
{
    Console.WriteLine(" As frutas são iguais. ");
}

else if(frutaA != frutaB)
{
    Console.WriteLine(" As frutas são diferentes. ");
}