int senhaCorreta = 1234;
int senhaUsuario;

do
{
    Console.WriteLine("digite uma senha de 4 digitos: ");
    senhaUsuario = int.Parse(Console.ReadLine());

    if (senhaUsuario != senhaCorreta)
    {
        Console.WriteLine("Senha incorreta, digite a senha novamente. ");
    }

} while (senhaUsuario != senhaCorreta); 
    Console.WriteLine("Senha correta! ");
