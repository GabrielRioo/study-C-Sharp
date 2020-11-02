using System;

class Aula06 {
    static void Main() {
        double valorCompra = 5.50;
        double valorVenda;
        double lucro = 0.1;
        string produto = "Pastel";

        valorVenda = valorCompra + (valorCompra*lucro); 

        Console.WriteLine("Produto.......:{0, 10}", produto); // o 15 se refere a quantidade de espaços
        Console.WriteLine("Val.Compra....:{0, 10:c}", valorCompra); // o "c" significa valor monetario
        Console.WriteLine(".Lucro........:{0, 10:p}", lucro); // porcentagem
        Console.WriteLine("Val.Venda.....:{0, 10:c}", valorVenda); 

        // int n1, n2, n3;

        // n1 = 10;
        // n2 = 20;
        // n3 = 30;

        // Console.WriteLine(n1 + ", " + n2 + ", " + n3);
        // Console.WriteLine(String.Format("n1 = {0}, n2 = {1}, n3 = {2}", n1, n2, n3));
        // Console.WriteLine("\n1 =\t{0} \n2 =\t{1} \n3 =\t{2}", n1, n2, n3);
    }
}