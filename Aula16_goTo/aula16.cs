using System;
class aula15{
    static void Main(){
        
        int tempoViagem = 0;
        
        inicio:
        Console.Clear();

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
                Console.WriteLine("Transporte não encontrado, tente novamente!");
                break;
        }
        Console.WriteLine("Para o transporte escolhido o tempo de viagem é: {0} hora(s)", tempoViagem);
        Console.WriteLine("\n");
        Console.WriteLine("\nDeseja continuar? [s]Sim | [n]Não");
        char continuar = char.Parse(Console.ReadLine());
        if(continuar == 's' || continuar == 'S'){
            goto inicio;
        }else if(continuar == 'n' || continuar == 'N'){
            Console.Clear();
            Console.WriteLine("Fim do programa!");
            Console.WriteLine("Obrigado por usar o programa!");  
        }else{
            Console.WriteLine("Opção inválida! Tente novamente.");
            goto inicio;
        }
    }
}