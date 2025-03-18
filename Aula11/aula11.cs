using System;
class aula11{
    static void Main(){
        int n1 = 10;
        float n2 = n1;

        float n3 = 11.5f;
        int n4 = (int)n3;// operador de cast para converter o float em int.

        int vInt = 12;
        long vLong = vInt;

        int vInt2 = 15;
        short vShort = (short)vInt2;

        Console.WriteLine(n2);
        Console.WriteLine(n4);
        Console.WriteLine(vLong);
        Console.WriteLine(vShort);

    }
}