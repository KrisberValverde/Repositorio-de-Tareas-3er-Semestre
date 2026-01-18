using System;

// Clase principal del programa
class Program
{
    static void Main(string[] args)
    {
        // Muestra el título del ejercicio al iniciar el programa
        Console.WriteLine("Ejercicio que muestra el registro de los estudiantes de la unidad curricular de Redes III utilizando listas enlazadas");
        Console.WriteLine(); 

        // Se crea el objeto lista que manejará la lista enlazada de estudiantes
        Lista_Estudiantes lista = new Lista_Estudiantes();

        int opcion; // Variable para almacenar la opción del menú seleccionada por el usuario

        // Ciclo do-while que mantiene el menú activo hasta que el usuario elija salir
        do
        {
            // Menú de opciones disponibles
            Console.WriteLine("1. Agregar estudiante");
            Console.WriteLine("2. Buscar estudiante");
            Console.WriteLine("3. Eliminar estudiante");
            Console.WriteLine("4. Total aprobados");
            Console.WriteLine("5. Total reprobados");
            Console.WriteLine("6. Imprimir lista");
            Console.WriteLine("7. Salir");
            Console.Write("Ingrese opción: ");

            // Se lee la opción ingresada por el usuario
            opcion = Convert.ToInt32(Console.ReadLine());

            // Estructura switch para ejecutar la opción seleccionada
            switch (opcion)
            {
                case 1:
                    // Opción para agregar un estudiante
                    Console.Write("Cédula: ");
                    string cedula = Console.ReadLine();

                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();

                    Console.Write("Apellido: ");
                    string apellido = Console.ReadLine();

                    Console.Write("Correo: ");
                    string correo = Console.ReadLine();

                    Console.Write("Nota: ");
                    double nota = Convert.ToDouble(Console.ReadLine());

                    // Se llama al método que agrega el estudiante a la lista
                    lista.Agregar_Estudiante(cedula, nombre, apellido, correo, nota);
                    break;

                case 2:
                    // Opción para buscar un estudiante por su cédula
                    Console.Write("Ingrese cédula: ");
                    Nodo_Estudiante estudiante = lista.Buscar_Estudiante(Console.ReadLine());

                    if (estudiante != null)
                    {
                        Console.WriteLine(
                            $"Cédula: {estudiante.Cedula}, Nombre: {estudiante.Nombre}, Apellido: {estudiante.Apellido}, Nota: {estudiante.Nota}"
                        );
                    }
                    else
                    {
                        Console.WriteLine("Estudiante no encontrado.");
                    }
                    break;

                case 3:
                    // Opción para eliminar un estudiante por su cédula
                    Console.Write("Ingrese cédula: ");
                    lista.Eliminar_Estudiante(Console.ReadLine());
                    break;

                case 4:
                    // Muestra el total de estudiantes aprobados
                    Console.WriteLine($"Total aprobados: {lista.Total_Aprobados()}");
                    break;

                case 5:
                    // Muestra el total de estudiantes reprobados
                    Console.WriteLine($"Total reprobados: {lista.Total_Reprobados()}");
                    break;

                case 6:
                    // Imprime la lista completa de estudiantes (opción adicional)
                    lista.Imprimir_Lista();
                    break;

                case 7:
                    // Finaliza la ejecución del programa
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    // Mensaje para opciones no válidas
                    Console.WriteLine("Opción inválida. Intente nuevamente.");
                    break;
            }

            Console.WriteLine(); // Línea en blanco para separar cada operación

        } while (opcion != 7); // El ciclo termina cuando el usuario elige salir
    }
}
