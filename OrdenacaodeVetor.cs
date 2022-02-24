using System;

namespace OrdenacaoDeVetor
{
    int[] numeros = new int[5] { 29, 10, 14, 37, 14 };

    int tmp, j;

    //ordem crescente
    for (int i = 1; i < numeros.Length; i++)
    {
        tmp = numeros[i];
        for (j = i-1; j >= 0 && tmp < numeros[j]; j--)
        {
            numeros[j+1] = numeros[j];
        }
        numeros[j + 1] = tmp;
    }

    Console.WriteLine("Em ordem crescente: ");
    for (int i = 0; i < numeros.Length; i++)
    {
        Console.Write($"{numeros[i]}, ");
    }

    Console.WriteLine();

    //ordem decrescente
    for (int i = 1; i < numeros.Length; i++)
    {
        tmp = numeros[i];
        for (j = i - 1; j >= 0 && tmp > numeros[j]; j--)
        {
            numeros[j + 1] = numeros[j];
        }
        numeros[j + 1] = tmp;
    }

    Console.WriteLine("Em ordem decrescente: ");
    for (int i = 0; i < numeros.Length; i++)
    {
        Console.Write($"{numeros[i]}, ");
    }  
}
