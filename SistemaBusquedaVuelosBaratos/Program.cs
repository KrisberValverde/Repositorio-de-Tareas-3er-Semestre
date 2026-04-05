using System;
using SistemaBusquedaVuelosBaratos.Grafo;
using SistemaBusquedaVuelosBaratos.Arbol;

class Program
{
    static void Main()
    {
        GrafoRutas grafo = new GrafoRutas();
        ArbolVuelos arbol = new ArbolVuelos();

        // Carga datos desde archivo
        grafo.CargarDesdeArchivo("Datos/datos.txt");

        // Mostrar grafo
        grafo.MostrarMapa();

        // Obtener conexiones para llenar el árbol
        var conexiones = grafo.ObtenerConexiones();

        // Insertar vuelos en el árbol
        foreach (var ciudad in conexiones)
        {
            foreach (var destino in ciudad.Value)
            {
                arbol.Insertar(new Vuelo(ciudad.Key, destino.destino, destino.precio));
            }
        }

        // Mostrar vuelos ordenados
        Console.WriteLine("\nVuelos ordenados por precio:");
        arbol.MostrarInOrden(arbol.Raiz);

        // Buscar vuelo más barato
        Console.WriteLine("\nIngrese ciudad origen:");
        string origen = Console.ReadLine();

        Console.WriteLine("Ingrese ciudad destino:");
        string destinoFinal = Console.ReadLine();

        grafo.VueloMasBarato(origen, destinoFinal);

        Console.ReadKey();
    }
}
