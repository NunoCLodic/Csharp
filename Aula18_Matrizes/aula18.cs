using System;
class Aula17
{
    static void Main(string[] args)
    {
        // Declaração de um vetor de inteiros com 10 posições
        int[,] n = new int[3,5];
        /*
        100 101 102 103 104
        200 201 202 203 204
        300 301 302 303 304
        */

        // Preenchendo os valores da matriz
       n[0,0] = 100;
       n[0,1] = 101;
       n[0,2] = 102;
       n[0,3] = 103;
       n[0,4] = 104;

       n[1,0] = 200;
       n[1,1] = 201;
       n[1,2] = 202;
       n[1,3] = 203;
       n[1,4] = 204;

       n[2,0] = 300;
       n[2,1] = 301;
       n[2,2] = 302;
       n[2,3] = 303;
       n[2,4] = 304;

        // Exibindo os valores da matriz
        Console.WriteLine("Valores da matriz:");
        for (int i = 0; i < n.GetLength(0); i++)
        {
            for (int j = 0; j < n.GetLength(1); j++)
            {
                Console.Write(n[i, j] + " ");
            }
            Console.WriteLine();
        }
        // Exibindo os valores da matriz usando foreach
        Console.WriteLine();
        Console.WriteLine("Valores da matriz usando foreach:");
        foreach (int valor in n)
        {
            Console.Write(valor + " ");
        }
        Console.WriteLine();
        //Mostrando apenas o valor 202
        Console.WriteLine();
        Console.WriteLine("Mostrando apenas o valor 202:");
        Console.WriteLine("Linha 1/ Coluna 2: " + n[1,2]);
    }
}