using System;

class Aula24 {
    static void Main() {
        int v1, v2, result;
        Console.Write("Digite um numero: ");
        v1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite um numero: ");
        v2 = Convert.ToInt32(Console.ReadLine());
        result = soma2(v1,v2);
        Console.WriteLine("A soma de {0} e {1} é {2}", v1, v2, result);
    }

    // static void soma(int n1, int n2) {
    //     int res = n1+n2;
    //     Console.WriteLine("A soma de {0} e {1} é {2}", n1, n2, res);
    // }

    static int soma2(int n1, int n2) {
        int res = n1+n2;
        return res;
    }
}