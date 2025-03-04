using System;

static class Program {
    static void Main() {

        double valorCompra = 5.50;
        double lucro = 0.35;
        string produto = "Pastel de nata";
        double valorVenda;


  

        valorVenda = valorCompra + (valorCompra * lucro);

        Console.WriteLine("\nProduto:............:{0,15}", produto);
        Console.WriteLine("\n");
        Console.WriteLine("Valor de Compra.....:{0,15:c}", valorCompra);
        Console.WriteLine("Lucro...............:{0,15:p}", lucro);
        Console.WriteLine("Valor de Venda......:{0,15:c}", valorVenda);


        //manupulando uma constante

        coms string canal = "Curso de C#";
        cons double pi = 3.14159265359;


        Console.WriteLine("Canal: {0}", canal);

    }
}