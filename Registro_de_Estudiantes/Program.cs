// using System sirve para poder usar cosas básicas de C#, como Console, que nos permite escribir y leer datos desde la consola
using System;

// Esta clase guarda toda la información del estudiante
class Registro_Estudiante
{
    // Aquí se guarda el ID del estudiante
    public string ID { get; set; }

    // Aquí se guardan los nombres del estudiante
    public string Nombres { get; set; }

    // Aquí se guardan los apellidos del estudiante
    public string Apellidos { get; set; }

    // Aquí se guarda la dirección del estudiante
    public string Direccion { get; set; }

    // Arreglo donde se guardan los 3 números de teléfono
    public string[] Telefonos { get; set; }

    // Este constructor se ejecuta cuando se crea el objeto y prepara el arreglo para los teléfonos
    public Registro_Estudiante()
    {
        Telefonos = new string[3];
    }
}

// Esta es la clase principal del programa
class Program
{
    // Aquí empieza a ejecutarse el programa
    static void Main(string[] args)
    {
        // Se crea un objeto estudiante para guardar los datos
        Registro_Estudiante estudiante = new Registro_Estudiante();

        // Se pide el ID y se guarda
        Console.Write("Ingrese el ID del estudiante: ");
        estudiante.ID = Console.ReadLine();

        // Se piden los nombres y se guardan
        Console.Write("Ingrese los nombres del estudiante: ");
        estudiante.Nombres = Console.ReadLine();

        // Se piden los apellidos y se guardan
        Console.Write("Ingrese los apellidos del estudiante: ");
        estudiante.Apellidos = Console.ReadLine();

        // Se pide la dirección y se guarda
        Console.Write("Ingrese la dirección del estudiante: ");
        estudiante.Direccion = Console.ReadLine();

        // Con este ciclo se piden los 3 números de teléfono
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Ingrese el número de teléfono {i + 1}: ");
            estudiante.Telefonos[i] = Console.ReadLine();
        }

        // Se muestran en pantalla todos los datos ingresados
        Console.WriteLine("\n--- Datos del estudiante ---");
        Console.WriteLine($"ID: {estudiante.ID}");
        Console.WriteLine($"Nombres: {estudiante.Nombres}");
        Console.WriteLine($"Apellidos: {estudiante.Apellidos}");
        Console.WriteLine($"Dirección: {estudiante.Direccion}");

        // Se muestran los números de teléfono guardados
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Teléfono {i + 1}: {estudiante.Telefonos[i]}");
        }
    }
}
