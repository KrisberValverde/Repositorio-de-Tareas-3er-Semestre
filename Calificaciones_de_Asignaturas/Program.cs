using System;
using System.Collections.Generic;

// Clase principal del programa
class Program
{
    // Se ejecuta el programa
    static void Main(string[] args)
    {
        Console.WriteLine("Ejercicio 3: El programa muestra las notas obtenidas en cada asignatura");
        Console.WriteLine();

        // Se crea una lista de cada asignatura del curso
        List<Asignatura> asignaturas = new List<Asignatura>
        {
            new Asignatura("Metodologías de la Investigación"),
            new Asignatura("Instalaciones Eléctricas y de Cableado Estructurado"),
            new Asignatura("Fundamentos de Sistemas Digitales"),
            new Asignatura("Estructura de Datos"),
            new Asignatura("Administración de SO")
        };

        // Se solicita al usuario la nota de cada asignatura
        foreach (Asignatura asignatura in asignaturas)
        {
            asignatura.Peticion_de_la_nota();
        }

        // Se muestran las notas ingresadas
        Console.WriteLine("\nNotas:");
        foreach (Asignatura asignatura in asignaturas)
        {
            asignatura.Mostrar_nota();
        }
    }
}
