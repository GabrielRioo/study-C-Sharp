using System;

class Aula19 {
    static void Main() {
        int[] num = new int[10];

        for(int i = 0; i < num.Length; i++) {
            Console.Write("Digite o {0}º numero: ", i);
            num[i] = Convert.ToInt32(Console.ReadLine());
        }

        for(int i = 0; i < num.Length; i++) {
            Console.WriteLine("Valor da posição {0} é: {1}",i , num[i]);
        }
    }
}