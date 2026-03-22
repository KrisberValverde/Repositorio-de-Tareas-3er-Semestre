using System;

// Implementación de un Arbol Binario de Busqueda (BST)
public class ArbolBinarioBusqueda
{
    // Nodo raiz del arbol
    public Nodo Raiz { get; set; }

    // Constructor: inicia el arbol vacio
    public ArbolBinarioBusqueda()
    {
        Raiz = null;
    }

    // INSERCION

    // Metodo publico para insertar un valor
    public void Insertar(int valor)
    {
        Raiz = InsertarRecursivo(Raiz, valor);
    }

    // Inserta un valor respetando la propiedad del BST:
    // izquierda < nodo < derecha
    private Nodo InsertarRecursivo(Nodo nodo, int valor)
    {
        // Si el nodo esta vacio, se crea uno nuevo
        if (nodo == null)
            return new Nodo(valor);

        // Se decide en que lado insertar
        if (valor < nodo.Valor)
            nodo.Izquierdo = InsertarRecursivo(nodo.Izquierdo, valor);
        else if (valor > nodo.Valor)
            nodo.Derecho = InsertarRecursivo(nodo.Derecho, valor);

        return nodo;
    }

    // BUSQUEDA

    // Metodo publico para buscar un valor
    public bool Buscar(int valor)
    {
        return BuscarRecursivo(Raiz, valor);
    }

    // Recorre el arbol comparando valores
    private bool BuscarRecursivo(Nodo nodo, int valor)
    {
        // Si se llega a null, el valor no existe
        if (nodo == null)
            return false;

        // Si coincide, se encontro
        if (valor == nodo.Valor)
            return true;

        // Se continua la busqueda segun el valor
        if (valor < nodo.Valor)
            return BuscarRecursivo(nodo.Izquierdo, valor);
        else
            return BuscarRecursivo(nodo.Derecho, valor);
    }

    // ELIMINACION

    // Metodo publico para eliminar un valor
    public void Eliminar(int valor)
    {
        Raiz = EliminarRecursivo(Raiz, valor);
    }

    // Elimina un nodo considerando los 3 casos posibles
    private Nodo EliminarRecursivo(Nodo nodo, int valor)
    {
        if (nodo == null)
            return nodo;

        if (valor < nodo.Valor)
            nodo.Izquierdo = EliminarRecursivo(nodo.Izquierdo, valor);
        else if (valor > nodo.Valor)
            nodo.Derecho = EliminarRecursivo(nodo.Derecho, valor);
        else
        {
            // Caso 1: nodo sin hijos
            if (nodo.Izquierdo == null && nodo.Derecho == null)
                return null;

            // Caso 2: un solo hijo
            if (nodo.Izquierdo == null)
                return nodo.Derecho;
            if (nodo.Derecho == null)
                return nodo.Izquierdo;

            // Caso 3: dos hijos
            // Se reemplaza por el menor del subarbol derecho
            Nodo temp = EncontrarMinimo(nodo.Derecho);
            nodo.Valor = temp.Valor;

            // Se elimina el nodo duplicado
            nodo.Derecho = EliminarRecursivo(nodo.Derecho, temp.Valor);
        }

        return nodo;
    }

    // MINIMO Y MAXIMO

    // Obtiene el nodo con el valor minimo
    private Nodo EncontrarMinimo(Nodo nodo)
    {
        while (nodo.Izquierdo != null)
            nodo = nodo.Izquierdo;

        return nodo;
    }

    public int ValorMinimo()
    {
        if (Raiz == null)
            throw new InvalidOperationException("El arbol esta vacio.");

        return EncontrarMinimo(Raiz).Valor;
    }

    public int ValorMaximo()
    {
        if (Raiz == null)
            throw new InvalidOperationException("El arbol esta vacio.");

        Nodo nodo = Raiz;
        while (nodo.Derecho != null)
            nodo = nodo.Derecho;

        return nodo.Valor;
    }

    // RECORRIDOS

    // Preorden: Raiz - Izquierda - Derecha
    public void Preorden()
    {
        PreordenRecursivo(Raiz);
    }

    private void PreordenRecursivo(Nodo nodo)
    {
        if (nodo != null)
        {
            Console.Write(nodo.Valor + " ");
            PreordenRecursivo(nodo.Izquierdo);
            PreordenRecursivo(nodo.Derecho);
        }
    }

    // Inorden: Izquierda - Raiz - Derecha
    public void Inorden()
    {
        InordenRecursivo(Raiz);
    }

    private void InordenRecursivo(Nodo nodo)
    {
        if (nodo != null)
        {
            InordenRecursivo(nodo.Izquierdo);
            Console.Write(nodo.Valor + " ");
            InordenRecursivo(nodo.Derecho);
        }
    }

    // Postorden: Izquierda - Derecha - Raiz
    public void Postorden()
    {
        PostordenRecursivo(Raiz);
    }

    private void PostordenRecursivo(Nodo nodo)
    {
        if (nodo != null)
        {
            PostordenRecursivo(nodo.Izquierdo);
            PostordenRecursivo(nodo.Derecho);
            Console.Write(nodo.Valor + " ");
        }
    }

    // ALTURA

    // Calcula la altura del arbol
    public int Altura()
    {
        return AlturaRecursivo(Raiz);
    }

    private int AlturaRecursivo(Nodo nodo)
    {
        if (nodo == null)
            return -1;

        return 1 + Math.Max(
            AlturaRecursivo(nodo.Izquierdo),
            AlturaRecursivo(nodo.Derecho)
        );
    }

    // LIMPIAR ARBOL

    // Elimina todos los nodos del arbol
    public void Limpiar()
    {
        Raiz = null;
    }
}
