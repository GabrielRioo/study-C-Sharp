using System;

class Aula17 {
    static void Main() {

        int[,] matriz = new int [3,5]; // 3 linhas e 5 colunas

        matriz[0,0] = 10;
        matriz[0,1] = 20;
        matriz[0,2] = 30;
        matriz[0,3] = 40;
        matriz[0,4] = 50;

        matriz[1,0] = 60;
        matriz[1,1] = 70;
        matriz[1,2] = 80;
        matriz[1,3] = 90;
        matriz[1,4] = 15;

        matriz[2,0] = 25;
        matriz[2,1] = 35;
        matriz[2,2] = 45;
        matriz[2,3] = 55;
        matriz[2,4] = 65;
        
        Console.WriteLine(matriz[0,0]);
        

    }
    
}