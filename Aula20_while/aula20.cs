using System;
class Aula19
{
    static void Main(string[] args)
    {
        int i = 0;
        while (i < 10)
        {
            Console.WriteLine(i);
            i++;
        }
        Console.WriteLine("Fim do loop while");
        Console.ReadKey();
        // Exemplo de loop while com decremento
        int j = 10;
        while (j > 0)
        {
            Console.WriteLine(j);
            j--;
        }
        Console.WriteLine("Fim do loop while com decremento");
        Console.ReadKey();

    }
}