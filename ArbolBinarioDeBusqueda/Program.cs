using System;

class Program
{
    static void Main()
    {
        // Se crea una instancia del arbol
        var bst = new ArbolBinarioBusqueda();
        int opcion;

        do
        {
            Console.WriteLine("\n----- MENU BST -----");
            Console.WriteLine("1. Insertar valor");
            Console.WriteLine("2. Buscar valor");
            Console.WriteLine("3. Eliminar valor");
            Console.WriteLine("4. Mostrar recorridos");
            Console.WriteLine("5. Mostrar minimo, maximo y altura");
            Console.WriteLine("6. Limpiar arbol");
            Console.WriteLine("7. Salir");
            Console.Write("Seleccione una opcion: ");

            // Validacion de la opcion ingresada
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Entrada invalida.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    Console.Write("Valor a insertar: ");
                    if (int.TryParse(Console.ReadLine(), out int valorInsertar))
                    {
                        bst.Insertar(valorInsertar);
                        Console.WriteLine("Valor insertado correctamente.");
                    }
                    else
                    {
                        Console.WriteLine("Entrada invalida.");
                    }
                    break;

                case 2:
                    Console.Write("Valor a buscar: ");
                    if (int.TryParse(Console.ReadLine(), out int valorBuscar))
                    {
                        Console.WriteLine(
                            bst.Buscar(valorBuscar)
                            ? "Valor encontrado."
                            : "Valor no encontrado."
                        );
                    }
                    break;

                case 3:
                    Console.Write("Valor a eliminar: ");
                    if (int.TryParse(Console.ReadLine(), out int valorEliminar))
                    {
                        bst.Eliminar(valorEliminar);
                        Console.WriteLine("Operacion realizada.");
                    }
                    break;

                case 4:
                    if (bst.Raiz == null)
                    {
                        Console.WriteLine("El arbol esta vacio.");
                    }
                    else
                    {
                        Console.WriteLine("Preorden:");
                        bst.Preorden();

                        Console.WriteLine("\nInorden:");
                        bst.Inorden();

                        Console.WriteLine("\nPostorden:");
                        bst.Postorden();

                        Console.WriteLine();
                    }
                    break;

                case 5:
                    if (bst.Raiz == null)
                    {
                        Console.WriteLine("El arbol esta vacio.");
                    }
                    else
                    {
                        Console.WriteLine($"Minimo: {bst.ValorMinimo()}");
                        Console.WriteLine($"Maximo: {bst.ValorMaximo()}");
                        Console.WriteLine($"Altura: {bst.Altura()}");
                    }
                    break;

                case 6:
                    bst.Limpiar();
                    Console.WriteLine("Arbol eliminado.");
                    break;

                case 7:
                    Console.WriteLine("Fin del programa.");
                    break;

                default:
                    Console.WriteLine("Opcion no valida.");
                    break;
            }

        } while (opcion != 7);
    }
}
