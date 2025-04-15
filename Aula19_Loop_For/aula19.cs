using System;
class Aula19
{
    static void Main(string[] args)
    {
        // Loop for to print numbers from 1 to 10
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("-----------------");
        // Loop for to print even numbers from 2 to 20
        for (int i = 2; i <= 20; i += 2)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("-----------------");

        // Loop for to print odd numbers from 1 to 19
        for (int i = 1; i < 20; i += 2)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("-----------------");
    }
}