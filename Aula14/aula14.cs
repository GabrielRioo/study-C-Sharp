using System;

class Aula12 {
    static void Main() {
        int n1,n2,n3,n4, res;
        n1=n2=n3=n4=res=0;

        Console.Write("Digite a nota 1: ");
        n1 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 2: ");
        n2 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 3: ");
        n3 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 4: ");
        n4 = int.Parse(Console.ReadLine());

        res= n1 + n2+ n3+ n4;
        
        string resultado = "Reprovado";

        if(res >= 60){
            if(res >= 90) {
                Console.WriteLine("Aprovado com louvor");
            }
            else {
                Console.WriteLine("Aprovado");
            }
        }
        else {
            if(res >= 40) {
                Console.WriteLine("Recuperação");
            }
            else {
                Console.WriteLine("Reprovado");
            }
        }

    }
}