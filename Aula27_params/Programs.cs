using System;
class Aula27
{
    static void Main(string[] args)
    {
        Soma();
        Soma(10);
        Soma(10, 20);
        Soma(10, 20, 30);
        Soma(5, 10, 15, 20, 25, 30);
        Soma(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
        Soma(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);
        Soma(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);
        Soma(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13);
        Soma(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);
        Soma(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);
        Soma(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
        Soma(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17);
        Soma(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18);
        Soma(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19);
        Soma(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20);
        Soma(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21);
        Soma(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22);

    }

    static void Soma(params int[] numeros)
    {
        int soma = 0;
        int resultado = 0;

        if (numeros.Length == 0)
        {
            Console.WriteLine("Nenhum número foi passado.");
        }
        else if (numeros.Length == 1)
        {
            Console.WriteLine("Valor insuficiente para soma: " + numeros[0]);
        }
        else
        {
            /*quando precisar de controle total sobre os índices ou manipulação da*/
            /*for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }
            Console.WriteLine("(com for) A soma é: " + soma);*/

            /*quando apenas precisar iterar pelos elementos da coleção de forma limpa e direta.*/
            foreach (int numero in numeros)
            {
                resultado += numero;
            }
            Console.WriteLine("(com foreach) A soma é: " + resultado);
        }

    }
}
/*DOTNET NEW CONSOLE - NOVO PROJETO COM TODOS FICHEIROS*/
/*DOTNET BUILD - NOVA FORMA DE COMPILAR O PROJETO*/
/*DOTNET RUN - NOVA FORMA DE EXECUTAR O PROJETO*/