using System;

public class Jogador
{
    public int energia;
    public bool vivo;
    public string nome;

    //SOBRECARGA DE CONSTRUTORES
    public Jogador()
    {
        energia = 100;
        vivo = true;
        nome = "Jogador";
    }
    public Jogador(string n)
    {
        nome = n;
        energia = 100;
        vivo = true;
        
    }
    public Jogador(string n, int e)
    {
        nome = n;
        energia = e;
        vivo = true;
        
    }
    public Jogador(string n, int e, bool v)
    {
        nome = n;
        energia = e;
        vivo = v;
        
    }
    public void info()
    {
        Console.WriteLine("Nome Jogador.......{0}", nome);
        Console.WriteLine("Energia Jogador....{0}", energia);
        Console.WriteLine("Estado Jogador.....{0}", vivo);
        Console.WriteLine("*************************************");
    }

}
class Programs
{
    static void Main()
    {
        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador("Bruno");
        Jogador j3 = new Jogador("Theo", 100);
        Jogador j4 = new Jogador("Mateus", 0, false);

        j1.info();
        j2.info();
        j3.info();
        j4.info();

    }
    

}