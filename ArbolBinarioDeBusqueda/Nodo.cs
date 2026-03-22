using System;

// Representa un nodo dentro del Arbol Binario de Busqueda
public class Nodo
{
    // Valor almacenado en el nodo
    public int Valor { get; set; }

    // Referencia al hijo izquierdo
    public Nodo Izquierdo { get; set; }

    // Referencia al hijo derecho
    public Nodo Derecho { get; set; }

    // Constructor que inicializa el nodo con un valor
    public Nodo(int valor)
    {
        Valor = valor;
        Izquierdo = null;
        Derecho = null;
    }
}
