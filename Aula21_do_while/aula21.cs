using System;
class Aula19
{
    static void Main(string[] args)
    {
        string senha = "1234";
        string senhaDigitada = "";
        int tentativas = 0;
        int tentativaRestantes = 3;

        Console.Clear();
        Console.WriteLine("Bem-vindo ao sistema de autenticação!");

        do
        {
            Console.WriteLine("Digite a senha: ");
            senhaDigitada = Console.ReadLine();
            tentativas++;
            tentativaRestantes--;

            if (senhaDigitada != senha)
            { 
                Console.Clear();
                Console.WriteLine("Senha incorreta. Você tem (" + tentativaRestantes + ") tentativas restantes.");
            }
        } while (senhaDigitada != senha && tentativas < 3);

        if (senhaDigitada == senha)
        {
            Console.Clear();
            Console.WriteLine("Acesso permitido! " + tentativas + " tentativas!.");
        }
        else 
        {
            Console.Clear();
            Console.WriteLine("Número máximo de tentativas atingido. Acesso negado.");
        }
    }
}