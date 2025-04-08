using System;
class Aula17
{
    static void Main(string[] args)
    {
        // Declaração de um vetor de inteiros com 10 posições
        int[] vetor = new int[10];

        // Preenchendo o vetor com valores de 0 a 9
        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = i;
        }

        // Exibindo os valores do vetor
        Console.WriteLine("Valores do vetor:");
        foreach (int valor in vetor)
        {
            Console.WriteLine(valor);
        }
    }
}