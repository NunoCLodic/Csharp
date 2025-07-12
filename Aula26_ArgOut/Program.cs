using System;

class Aula24
{ 
    static void Main(string[] args)
    {
        Console.WriteLine("Qual valor do dividendo? ");
        int dividendo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Qual valor do divisor? ");
        int divisor = Convert.ToInt32(Console.ReadLine());
        int quociente;
        int resto;
        quociente = divide(dividendo, divisor, out resto); 

        Console.WriteLine("*******************************************");
        Console.WriteLine("{0}/{1} ",dividendo, divisor);
        Console.WriteLine("Quociente: " + quociente);
        Console.WriteLine("Resto: " + resto);

        Console.WriteLine("Pressione qualquer tecla para sair...");


    }
    static int divide(int dividendo, int divisor, out int resto)// o out é um argumento de saida
    {
        int quociente = dividendo / divisor;
        resto = dividendo % divisor;
        return quociente;

    }

}