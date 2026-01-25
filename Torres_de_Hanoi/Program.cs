using System;
using System.Collections.Generic;

public class Torres_De_Hanoi
{
    // Método recursivo que resuelve el problema de las Torres de Hanoi
    // Utilizamos pilas para representar cada torre
    static void ResolverHanoi(
        int n,
        Stack<int> origen,
        Stack<int> destino,
        Stack<int> auxiliar,
        string nombreOrigen,
        string nombreDestino,
        string nombreAuxiliar)
    {
        // Caso base: si solo hay un disco, se mueve directamente
        if (n == 1)
        {
            int disco = origen.Pop();   // Se retira el disco de la torre origen
            destino.Push(disco);        // Se coloca el disco en la torre destino
            Console.WriteLine($"Mover disco {disco} de {nombreOrigen} a {nombreDestino}");
            return;
        }

        // Paso 1: mover n-1 discos desde origen hacia la torre auxiliar
        ResolverHanoi(n - 1, origen, auxiliar, destino,
                      nombreOrigen, nombreAuxiliar, nombreDestino);

        // Paso 2: mover el disco más grande hacia la torre destino
        int discoActual = origen.Pop();
        destino.Push(discoActual);
        Console.WriteLine($"Mover disco {discoActual} de {nombreOrigen} a {nombreDestino}");

        // Paso 3: mover los n-1 discos desde auxiliar hacia destino
        ResolverHanoi(n - 1, auxiliar, destino, origen,
                      nombreAuxiliar, nombreDestino, nombreOrigen);
    }

    // Método principal del programa
    public static void Main(string[] args)
    {
        int n = 3; // Número de discos

        // Se crean las pilas que representan las torres
        Stack<int> origen = new Stack<int>();
        Stack<int> destino = new Stack<int>();
        Stack<int> auxiliar = new Stack<int>();

        // Se cargan los discos en la torre de origen del mayor al menor.
        for (int i = n; i > 0; i--)
        {
            origen.Push(i);
        }

        Console.WriteLine("Resolviendo Torres de Hanoi...\n");

        // Llamada al método que resuelve el problema
        ResolverHanoi(n, origen, destino, auxiliar, "Origen", "Destino", "Auxiliar");
    }
}
