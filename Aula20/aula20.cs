using System;

class Aula20 {
    static void Main() {

        int i = 1;
        int[] num = new int[10];

        while(i < num.Length){
            num[i] = i+1;
            Console.WriteLine(num[i]);

            i ++;
        }
    }
}