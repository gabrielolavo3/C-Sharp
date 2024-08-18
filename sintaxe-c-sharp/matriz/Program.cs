using System;

class Program
{
    static void Main(string[] args)  
    {
        // Matriz -> tipo[,] <nome> = new tipo [quantLinha, quantColuna];
        int[,] numeros = new int[2,3];

        /*   Colunas:
        Linha: 1 2 3
        Linha: 4 5 6

        Linha 1 e Coluna 1 -> Indice 0
        */

        numeros[0,0] = 1; numeros[0,1] = 2; numeros[0,2] = 3;
        
        numeros[1,0] = 4; numeros[1,1] = 5; numeros[1,2] = 6;
    }
}