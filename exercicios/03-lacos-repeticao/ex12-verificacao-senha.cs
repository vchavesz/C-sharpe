// Exercício 12 - Verificação de Senha
// Pede uma senha de 4 dígitos e repete até o usuário acertar.
// CORREÇÃO: adicionado TryParse para evitar crash se o usuário digitar letras.

const int senhaCorreta = 1234;

int tentativas = 0;
int senhaUsuario;

do
{
    Console.Write("Digite a senha de 4 dígitos: ");
    
    if (!int.TryParse(Console.ReadLine(), out senhaUsuario))
    {
        Console.WriteLine("Entrada inválida. Use apenas números.");
        continue;
    }

    tentativas++;

    if (senhaUsuario != senhaCorreta)
        Console.WriteLine("Senha incorreta. Tente novamente.");

} while (senhaUsuario != senhaCorreta);

Console.WriteLine($"Senha correta! Você acertou em {tentativas} tentativa(s).");
