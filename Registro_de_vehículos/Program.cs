using System;

class Program
{
    static void Main(string[] args)
    {
        // Mensaje inicial del programa
        Console.WriteLine("Ejercicio que muestra un Registro de vehículos del estacionamiento del Área de Ingeniería de Sistemas");
        Console.WriteLine();

        Lista_Vehiculos lista = new Lista_Vehiculos();
        int opcion;

        do
        {
            // Menú principal
            Console.WriteLine("1. Agregar vehículo");
            Console.WriteLine("2. Buscar vehículo por placa");
            Console.WriteLine("3. Ver vehículos por año");
            Console.WriteLine("4. Ver todos los vehículos");
            Console.WriteLine("5. Eliminar vehículo");
            Console.WriteLine("6. Salir");
            Console.Write("Ingrese opción: ");

            opcion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (opcion)
            {
                case 1:
                    Console.Write("Placa: ");
                    string placa = Console.ReadLine();
                    Console.Write("Marca: ");
                    string marca = Console.ReadLine();
                    Console.Write("Modelo: ");
                    string modelo = Console.ReadLine();
                    Console.Write("Año: ");
                    int año = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Precio: ");
                    double precio = Convert.ToDouble(Console.ReadLine());

                    lista.Agregar_Vehiculo(placa, marca, modelo, año, precio);
                    break;

                case 2:
                    Console.Write("Ingrese placa: ");
                    string placaBuscar = Console.ReadLine();
                    Nodo_Vehiculo vehiculo = lista.Buscar_Vehiculo(placaBuscar);

                    if (vehiculo != null)
                    {
                        Console.WriteLine($"Placa: {vehiculo.Placa}, Marca: {vehiculo.Marca}, Modelo: {vehiculo.Modelo}, Año: {vehiculo.Año}, Precio: {vehiculo.Precio}");
                    }
                    else
                    {
                        Console.WriteLine("Vehículo no encontrado");
                    }
                    break;

                case 3:
                    Console.Write("Ingrese año: ");
                    int añoBuscar = Convert.ToInt32(Console.ReadLine());
                    lista.Ver_Vehiculos_Por_Año(añoBuscar);
                    break;

                case 4:
                    lista.Ver_Todos_Los_Vehiculos();
                    break;

                case 5:
                    Console.Write("Ingrese placa a eliminar: ");
                    string placaEliminar = Console.ReadLine();
                    lista.Eliminar_Vehiculo(placaEliminar);
                    break;

                case 6:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }

            Console.WriteLine();

        } while (opcion != 6);
    }
}
