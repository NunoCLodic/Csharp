using System;

class Aula24
{
    static void Main(string[] args)
    {
  
        // Declaração de variáveis
        int valor = 10;
        int resultado = 0;

        // Chamada do método dobrar
        resultado = dobrar(valor);

        // Exibe o resultado
        Console.WriteLine("O dobro sem referencia de {0} é {1}", valor, resultado);
        Console.WriteLine("O dobro com referencia de {0} é {1}", valor, dobrar(ref valor));

    }

    // Método que soma dois números inteiros
    static int dobrar(int valor)
    {
        return valor * 2;
    }
    static int dobrar(ref int valor)
    {
        return valor * 2;
    }
}