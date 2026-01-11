using System;
// Clase principal del programa
class Program
{
    // Método Main encargado de ejecutar el codigo
    static void Main(string[] args)
    {
        // Se crea un objeto de la clase Orden_inverso_de_numeros
        Orden_inverso_de_numeros lista = new Orden_inverso_de_numeros();

        Console.WriteLine("Ejercicio 5: programa muestra el orden inverso de los números");
        Console.WriteLine();
        
        // Se llama al método que muestra los números en orden inverso
        lista.MostrarInverso();
    }
}
