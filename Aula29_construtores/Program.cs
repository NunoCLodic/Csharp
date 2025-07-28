using System;

public class Jogador
{
    public int energia;
    public bool vivo;
    public string nome;

    public Jogador(string n)//construtor 
    {
        energia = 100;
        vivo = true;
        nome = n;
    }
    ~Jogador()//Destrutor, destroi dados do construtor quando ja nao é necessario
    {
        Console.WriteLine("Jogador {0} foi destruido", nome);
    }
    

}
class Programs
{
    static void Main()
    {
        Console.WriteLine("Digite o nome:");
        string nome = Console.ReadLine();

        Jogador j1 = new Jogador(nome);
        Jogador j2 = new Jogador("Nyara");


        Console.WriteLine("Energia do(a) Jogador(a) {0} é {1}", j1.nome, j1.energia);
        Console.WriteLine("Energia do(a) Jogador(a) {0} é {1}", j2.nome, j2.energia);

        // Tornando os objetos elegíveis para coleta
        j1 = null;
        j2 = null;

        // Forçando o garbage collector
        GC.Collect();
        GC.WaitForPendingFinalizers();

        System.Threading.Thread.Sleep(1000);

        Console.WriteLine("Finalizado.");


    }
    

}