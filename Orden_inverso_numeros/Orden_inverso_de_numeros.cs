using System;
using System.Collections.Generic;

// Clase que representa el manejo de una lista de números y se encarga de mostrarlos en orden inverso
class Orden_inverso_de_numeros
{
    // Atributo privado que almacena los números del 1 al 10
    private List<int> numeros;

    // Constructor de la clase
    public Orden_inverso_de_numeros()
    {
        // Inicialización de la lista
        numeros = new List<int>();

        // Se agregan los números del 1 al 10 a la lista
        for (int i = 1; i <= 10; i++)
        {
            numeros.Add(i);
        }
    }

    // Método que invierte el orden de los números y los muestra por pantalla separados por comas
    public void MostrarInverso()
    {
        // Se invierte el orden de los elementos de la lista
        numeros.Reverse();

        // Se imprime la lista en una sola línea separada por comas
        Console.WriteLine(string.Join(", ", numeros));
    }
}
