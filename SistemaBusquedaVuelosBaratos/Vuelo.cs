namespace SistemaBusquedaVuelosBaratos.Arbol
{
    // Nodo del árbol binario
    public class Vuelo
    {
        public string Origen;
        public string Destino;
        public int Precio;

        public Vuelo Izquierdo;
        public Vuelo Derecho;

        public Vuelo(string origen, string destino, int precio)
        {
            Origen = origen;
            Destino = destino;
            Precio = precio;
            Izquierdo = Derecho = null;
        }
    }
}
