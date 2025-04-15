using System;

class Aula24
{
    static void Main(string[] args)
    {
  
    // Chamada de metodo com imput do usuário
        Console.WriteLine("Digite o primeiro número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        
        somarT(num1, num2);
     

    }

    // Método que soma dois números inteiros
    static int somarT(int numero3, int numero4 = 0)
    {
        int resultado = numero3 + numero4;
        Console.WriteLine("Resultado de {0} e {1} é: {2} " , numero3, numero4, resultado);
        return resultado;
    }
}