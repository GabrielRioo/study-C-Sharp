using System;

class Aula22 {
    static void Main() {
        int[] num = new int[3] {11, 12, 13};

        // for(int i = 0; i <= num.Length-1; i++) {
        //     Console.WriteLine(num[i]);
        // }

        foreach(int item in num) {
            Console.WriteLine(item);
        }
    }
}