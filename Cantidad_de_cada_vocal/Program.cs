using System;

// Clase principal que contiene el punto de entrada del programa
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ejercicio 9: Programa que muestra el numero de veces que una palabra contiene cada vocal");
        Console.WriteLine();

        // Se solicita al usuario que ingrese una palabra
        Console.Write("Introduce una palabra: ");
        string palabra = Console.ReadLine();

        // Se crea el objeto de la clase Conteo_de_vocales
        Conteo_de_vocales contador = new Conteo_de_vocales(palabra);

        // Se llama al método que calcula las vocales
        contador.Calculo_de_vocales();

        // Se muestran los resultados
        contador.MostrarResultado();
    }
}
