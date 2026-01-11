using System;
using System.Collections.Generic;

// Clase principal del programa
class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Ejercicio 6: Programa que muestra si el estudiante aprobó todas las asigaturas o cuales debe repetir");
        Console.WriteLine();
        
        // Lista que almacena las asignaturas del curso
        List<asignatura> asignaturas = new List<asignatura>
        {
            new asignatura("Metodologías de la Investigación"),
            new asignatura("Instalaciones Eléctricas y de Cableado Estructurado"),
            new asignatura("Fundamentos de Sistemas Digitales"),
            new asignatura("Estructura de Datos"),
            new asignatura("Administración de SO")
        };

        // Solicita al usuario la nota de cada asignatura
        foreach (var a in asignaturas)
        {
            a.Solicitar_la_nota();
        }

        // Elimina de la lista las asignaturas aprobadas
        asignaturas.RemoveAll(a => a.Nota_aprobada());

        // Muestra las asignaturas que el estudiante debe repetir
        if (asignaturas.Count == 0)
        {
            Console.WriteLine("¡Felicidades! Has aprobado todas las asignaturas.");
        }
        else
        {
            Console.WriteLine("Asignaturas que debes repetir:");
            foreach (var a in asignaturas)
            {
                Console.WriteLine(a.Nombre);
            }
        }
    }
}
