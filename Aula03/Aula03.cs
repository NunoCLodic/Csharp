using System;
class Aula03
{
    static void Main()
    {
       byte n1 = 10; // 0 a 255
       int num = 0;
       int valor1 = 10, valor2 = 2, soma = valor1+valor2;
       char letra = 'c';
       float valor = 5.3f;
       string nome = "Gustavo";

       var aux = letra; // O compilador vai definir o tipo da variável

       Console.WriteLine("O valor de n1 é: {0}", n1);
       Console.WriteLine("A nossa Variavel magica é: {0}", aux);
       Console.WriteLine("O valor da soma é: {0}", soma);
    }
}