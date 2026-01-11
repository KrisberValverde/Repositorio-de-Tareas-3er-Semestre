using System;

// Clase principal que contiene el punto de entrada del programa
class Program
{
    // Ejecución del programa
    static void Main(string[] args)
    {
        Console.WriteLine("Ejercicio 8: Programa que detecta si una palabra es un palindromo");
        Console.WriteLine();

        // Solicita al usuario que ingrese una palabra
        Console.Write("Introduce una palabra: ");
        string palabra = Console.ReadLine();

        // Se crea un objeto de la clase Detectar_palindromo pasando la palabra ingresada como parámetro
        Detectar_palindromo detector = new Detectar_palindromo(palabra);

        // Se verifica si la palabra es un palíndromo
        if (detector.Es_un_Palindromo())
        {
            // Mensaje por si la palabra es un palíndromo
            Console.WriteLine($"La palabra '{palabra}' es un palíndromo.");
        }
        else
        {
            // Mensaje por si la palabra no es un palíndromo
            Console.WriteLine($"La palabra '{palabra}' no es un palíndromo.");
        }
    }
}
