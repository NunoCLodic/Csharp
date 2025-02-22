using System;
class Aula04//Escopo de variaveis, Globais e locais
{
    static int numGlobal = 10;

    static void Main()
    {
       int num = 12;  
       Console.WriteLine("O valor de num é: {0}", numGlobal);  
    }

    void teste()
    {
        int num = 20;
        Console.WriteLine("O valor de num é: {0}", num);
    }
}