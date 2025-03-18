using System;
class aula12{
    static void Main(){

        int nota1 = 0;
        int nota2 = 0;
        int nota3 = 0;
        int nota4 = 0;
        int soma = 0;
        string resultado = "Reprovado";

        Console.WriteLine("Digite a primeira nota: "); 
        nota1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a segunda nota: ");
        nota2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a terceira nota: ");
        nota3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a quarta nota: ");
        nota4 = int.Parse(Console.ReadLine());

        soma = nota1 + nota2 + nota3 + nota4;


        if(soma >= 60){
            resultado = "Aprovado";
        }

        Console.WriteLine("Nota: {0} - Resultado: {1}", soma,resultado);
    }

}