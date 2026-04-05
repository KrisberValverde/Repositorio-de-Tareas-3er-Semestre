using System;

namespace SistemaBusquedaVuelosBaratos.Arbol
{
    public class ArbolVuelos
    {
        public Vuelo Raiz;

        // Inserta vuelos ordenados por precio
        public void Insertar(Vuelo nuevo)
        {
            Raiz = InsertarRec(Raiz, nuevo);
        }

        private Vuelo InsertarRec(Vuelo raiz, Vuelo nuevo)
        {
            if (raiz == null)
                return nuevo;

            // Ordenar por precio (menor a la izquierda)
            if (nuevo.Precio < raiz.Precio)
                raiz.Izquierdo = InsertarRec(raiz.Izquierdo, nuevo);
            else
                raiz.Derecho = InsertarRec(raiz.Derecho, nuevo);

            return raiz;
        }

        // Mostrar vuelos ordenados (InOrden)
        public void MostrarInOrden(Vuelo nodo)
        {
            if (nodo == null) return;

            MostrarInOrden(nodo.Izquierdo);

            Console.WriteLine($"{nodo.Origen} -> {nodo.Destino} : ${nodo.Precio}");

            MostrarInOrden(nodo.Derecho);
        }
    }
}
