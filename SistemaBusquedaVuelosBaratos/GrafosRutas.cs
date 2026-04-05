using System;
using System.Collections.Generic;
using System.IO;

namespace SistemaBusquedaVuelosBaratos.Grafo
{
    public class GrafoRutas
    {
        // Diccionario que almacena:
        // Ciudad -> Lista de destinos con precio
        private Dictionary<string, List<(string destino, int precio)>> conexiones;

        public GrafoRutas()
        {
            conexiones = new Dictionary<string, List<(string, int)>>();
        }

        // Agrega una ciudad si no existe en el diccionario
        private void AgregarCiudad(string ciudad)
        {
            if (!conexiones.ContainsKey(ciudad))
                conexiones[ciudad] = new List<(string, int)>();
        }

        // Agrega una ruta con precio entre dos ciudades
        public void AgregarRuta(string origen, string destino, int precio)
        {
            AgregarCiudad(origen);
            AgregarCiudad(destino);

            // Grafo no dirigido (ida y vuelta)
            conexiones[origen].Add((destino, precio));
            conexiones[destino].Add((origen, precio));
        }

        // Cargar datos desde archivo de texto
        public void CargarDesdeArchivo(string archivo)
        {
            foreach (var linea in File.ReadAllLines(archivo))
            {
                string[] datos = linea.Split(' ');

                string origen = datos[0];
                string destino = datos[1];
                int precio = int.Parse(datos[2]);

                AgregarRuta(origen, destino, precio);
            }
        }

        // Mostrar todas las conexiones del grafo
        public void MostrarMapa()
        {
            Console.WriteLine("\nMapa de vuelos:\n");

            foreach (var ciudad in conexiones)
            {
                Console.Write(ciudad.Key + " conecta con: ");

                foreach (var destino in ciudad.Value)
                {
                    Console.Write($"{destino.destino} (${destino.precio}) ");
                }

                Console.WriteLine();
            }
        }

        // Método para obtener todas las rutas (sirve para reutilizar en el árbol)
        public Dictionary<string, List<(string destino, int precio)>> ObtenerConexiones()
        {
            return conexiones;
        }

        // Algoritmo de Dijkstra simplificado
        public void VueloMasBarato(string origen, string destino)
        {
            var costos = new Dictionary<string, int>();
            var visitados = new HashSet<string>();

            // Inicializar costos
            foreach (var ciudad in conexiones.Keys)
                costos[ciudad] = int.MaxValue;

            costos[origen] = 0;

            while (visitados.Count < conexiones.Count)
            {
                string actual = null;
                int menorCosto = int.MaxValue;

                // Buscar nodo con menor costo
                foreach (var ciudad in costos)
                {
                    if (!visitados.Contains(ciudad.Key) && ciudad.Value < menorCosto)
                    {
                        menorCosto = ciudad.Value;
                        actual = ciudad.Key;
                    }
                }

                if (actual == null) break;

                visitados.Add(actual);

                // Revisar vecinos
                foreach (var vecino in conexiones[actual])
                {
                    int nuevoCosto = costos[actual] + vecino.precio;

                    if (nuevoCosto < costos[vecino.destino])
                    {
                        costos[vecino.destino] = nuevoCosto;
                    }
                }
            }

            Console.WriteLine($"\nEl vuelo más barato de {origen} a {destino} cuesta: ${costos[destino]}");
        }
    }
}
