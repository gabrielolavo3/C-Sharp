﻿using System;

class Program
{
    static void Main(string[] args)
    {
        /* Declaração de arrays - tipo[] <nome> = new tipo[<quantidade de variaveis>]; */

        int[] array1 = new int[3];
        string[] array2 = {
            "Kill Bill",
            "Bastardos Inglórios"
        };
        char[] array3 = new char[1] {
            'a'
        };
        float[] array4 = new float[2];

        array4[0] = 10.10F;
        array4[1] = 21.78F;

        Console.Write("Digite o 1º valor: ");
        array1[0] = int.Parse(Console.ReadLine());
        Console.Write("Digite o 2º valor: ");
        array1[1] = int.Parse(Console.ReadLine());
        Console.Write("Digite o 3º valor: ");
        array1[2] = int.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("Array 1: ");
        Console.WriteLine($"{array1[0]} | {array1[1]} | {array1[2]}");
        Console.WriteLine("\nArray 2: ");
        Console.WriteLine($"{array2[0]} | {array2[1]}");
        Console.WriteLine("\nArray 3: ");
        Console.WriteLine($"{array3[0]}");
        Console.WriteLine("\nArray 4: ");
        Console.WriteLine($"{array4[0]} | {array4[1]}");
    }
}