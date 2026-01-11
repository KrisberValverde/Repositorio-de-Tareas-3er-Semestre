using System;

// Clase Asignatura
// Representa una asignatura de un curso con su nombre y su nota
public class Asignatura
{
    // Atributo que almacena el nombre de la asignatura
    public string Nombre { get; set; }

    // Atributo que almacena la nota obtenida en la asignatura
    public double Nota { get; set; }

    // Constructor de la clase
    // Recibe el nombre de la asignatura y asigna una nota inicial
    public Asignatura(string nombre)
    {
        Nombre = nombre;
        Nota = 0;
    }

    // Método que solicita al usuario la nota de la asignatura
    // Valida que la nota esté entre 0 y 10
    public void Peticion_de_la_nota()
    {
        Console.Write($"Introduce la nota de {Nombre}: ");

        double nota;

        // Se repite mientras la entrada no sea válida
        while (!double.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 10)
        {
            Console.Write("Nota inválida. Introduce una nota entre 0 y 10: ");
        }

        // Se asigna la nota válida al atributo Nota
        Nota = nota;
    }

    // Método que muestra por pantalla la nota obtenida
    public void Mostrar_nota()
    {
        Console.WriteLine($"En {Nombre} has sacado {Nota}");
    }
}
