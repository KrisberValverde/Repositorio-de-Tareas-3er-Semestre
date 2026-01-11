using System;

// Clase que representa una asignatura con su nombre y la nota obtenida
public class asignatura
{
    // Nombre de la asignatura
    public string Nombre { get; set; }

    // Nota obtenida en la asignatura
    public double Nota { get; set; }

    // Constructor que inicializa la asignatura
    public asignatura(string nombre)
    {
        Nombre = nombre;
        Nota = 0;
    }

    // Solicita al usuario la nota de la asignatura
    // Valida que la nota esté entre 0 y 10
    public void Solicitar_la_nota()
    {
        double nota; // Variable declarada fuera del while

        Console.Write($"Introduce la nota de {Nombre}: ");

        while (!double.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 10)
        {
            Console.Write("Nota inválida. Introduce una nota entre 0 y 10: ");
        }

        // Se asigna la nota válida a la propiedad
        Nota = nota;
    }

    // Verifica si la asignatura está aprobada
    // Retorna true si la nota es mayor o igual a 7
    public bool Nota_aprobada()
    {
        return Nota >= 7;
    }
}
