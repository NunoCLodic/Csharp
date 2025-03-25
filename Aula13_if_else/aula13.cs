using System;
class aula13{
    static void Main(){
        int n1, n2, n3, n4, res;
        string resultado;

        Console.Write("Digite a nota 1: ");
        n1 = int.Parse(Console.ReadLine());
        Console.Write("Digite a nota 2: ");
        n2 = int.Parse(Console.ReadLine());
        Console.Write("Digite a nota 3: ");
        n3 = int.Parse(Console.ReadLine());
        Console.Write("Digite a nota 4: ");
        n4 = int.Parse(Console.ReadLine());
        res = n1 + n2 + n3 + n4;
        //if aninhado (if dentro de if).
        /*if(res >= 60){
            if(res >= 90){
                resultado = "Aprovado com louvor";
            }else{
                resultado = "Aprovado";
            }
        }else{
            if(res >= 40){
                resultado = "Recuperação";
            }else{
                resultado = "Reprovado";
            }
        }*/
    //if else encadeado (if else if else).
        if(res>= 90){
            resultado = "Aprovado com louvor";
            }else if(res >= 60){
                resultado = "Aprovado";
            }else if(res >= 40){
                resultado = "Recuperação";
            }else{
                resultado = "Reprovado";
            }
        Console.WriteLine("Nota: {0} - Resultado: {1}", res, resultado);
    
    }
}