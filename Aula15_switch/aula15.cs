using System;
class aula15{
    static void Main(){
        
        int tempoViagem = 0;
        
        Console.WriteLine("Lisboa a Porto");
        Console.WriteLine("escolha o transporte: [a]Avião | [c]Carro | [o]Autocarro");
        char transporte = char.Parse(Console.ReadLine()); 
        
        switch(transporte){
            case 'a':
            case 'A':
                tempoViagem = 1;
                break;
            case 'c':
            case 'C':
                tempoViagem = 4;
                break;
            case 'o':
            case 'O':
                tempoViagem = 6;
                break;
            default:
                Console.WriteLine("Transporte não encontrado");
                break;
        }
         Console.WriteLine("Para o transporte escolhido o tempo de viagem é: {0} hora(s)", tempoViagem);
    }
}