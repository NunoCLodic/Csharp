using System;

class Aula22
{
    static void Main(string[] args)
    {
        // Array of integers
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Using foreach to iterate through the array
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine("");

        // Array of strings
        string[] names = { "Alice", "Bob", "Charlie" };

        // Using foreach to iterate through the array
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}