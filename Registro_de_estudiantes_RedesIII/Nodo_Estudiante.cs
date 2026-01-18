using System;

// Clase que representa un nodo de la lista enlazada.
// Cada nodo almacena la información de un estudiante.
public class Nodo_Estudiante
{
    public string Cedula { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Correo { get; set; }
    public double Nota { get; set; }

    // Referencia al siguiente nodo
    public Nodo_Estudiante Siguiente { get; set; }

    // Constructor del nodo estudiante
    public Nodo_Estudiante(string cedula, string nombre, string apellido, string correo, double nota)
    {
        Cedula = cedula;
        Nombre = nombre;
        Apellido = apellido;
        Correo = correo;
        Nota = nota;
        Siguiente = null;
    }
}
