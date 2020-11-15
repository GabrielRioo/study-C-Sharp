using System;

class Aula22 {
    static void Main() {
        int[] vetor1 = new int[5];
        int[] vetor2 = new int[5];
        int[] vetor3 = new int[5];
        int[,] matriz = new int[2.5] { {1,2,3,4,5}, {6,7,8,9,10} };

        Random random = new Random();
        for(int i = 0; i <vetor1.Length; i++) {
            vetor1[i] = random.Next(50);
        }

        Console.WriteLine("Elementos do vetor 1");
        foreach(int n in vetor1 ) {
            Console.WriteLine(n);
        }

        Console.WriteLine("BinarySearch");
        int procurado = 33;
        int pos = Array.BinarySearch(vetor1, procurado); // (array, valor)
        Console.WriteLine("Valor {0} está na posição {1}", procurado, pos);
        Console.WriteLine("-----------------------------------------------");


        Console.WriteLine("Copy");
        Array.Copy(vetor1, vetor2, vetor1.Length); // (array de origem, array de destino, quantidade de elementos)
        foreach (int n in vetor2)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("-----------------------------------------------");


        Console.WriteLine("CopyTo");
        vetor1.CopyTo(vetor3, 0); // (Array de destino, a partir desta posição)
        foreach (int n in vetor3)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("-----------------------------------------------");


        Console.WriteLine("GetLongLength");
        long qtdeElementosVetor = vetor1.GetLongLength(0);
        Console.WriteLine("Quantidade de elementos {0}", qtdeElementosVetor);
        Console.WriteLine("-----------------------------------------------");


        Console.WriteLine("GetLowerBound");
        int MenorIndiceVetor = vetor1.GetLowerBound(0);
        int MenorIndiceMatriz_D1 = matriz.GetLowerBound(1);
        Console.WriteLine("Menor indice do vetor 1 {0}", MenorIndiceVetor);
        Console.WriteLine("-----------------------------------------------");


        Console.WriteLine("GetUpperBound");
        int MaiorIndiceVetor = vetor1.GetUpperBound(0);
        int MaiorIndiceMatriz_D1 = matriz.GetUpperBound(1);
        Console.WriteLine("Maior indice do vetor 1 {0}", MaiorIndiceVetor);
        Console.WriteLine("-----------------------------------------------");


        Console.WriteLine("GetValue");
        int valor0 = Convert.ToInt32(vetor1.GetValue(3));
        int valor1 = Convert.ToInt32(matriz.GetValue(1,3));
        Console.WriteLine("Valor da posição 3 do vetor 1: {0}", valor0);
        Console.WriteLine("-----------------------------------------------");


        Console.WriteLine("IndexOf");
        int indice1 = Array.IndexOf(vetor1, 3);
        Console.WriteLine("Indice do primeiro valor 3: {0}", indice1);
        Console.WriteLine("-----------------------------------------------");


        Console.WriteLine("LastIndexOf");
        int indice2 = Array.LastIndexOf(vetor1, 3);
        Console.WriteLine("Indice do ultimo valor 33: {0}", indice2);
        Console.WriteLine("-----------------------------------------------");


        Console.WriteLine("Reverse");
        Array.Reverse(vetor1); // (array)
        foreach (int n in vetor1)
        {
            Console.WriteLine(n);
        }


        Console.WriteLine("SetValue");
        vetor2.SetValue(99, 0); //(object valor, long posição)
        for (int i = 0; i < vetor2.Length; i++)
        {
            vetor2.SetValue(0, i);
        }
        Console.WriteLine("Vetor 2");
        foreach (int n in vetor2)
        {
            Console.WriteLine(n);
        }


        Console.WriteLine("Sort");
        Array.Sort(vetor1); // (array)
        Array.Sort(vetor2);
        Array.Sort(vetor3);
        Console.WriteLine("Vetor 1");
        foreach (int n in vetor1)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("\nVetor 2");
        foreach (int n in vetor2)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("\nVetor 3");
        foreach (int n in vetor3)
        {
            Console.WriteLine(n);
        }


    }
}