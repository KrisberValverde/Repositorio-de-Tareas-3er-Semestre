using System;

// Clase que administra la lista enlazada de vehículos
public class Lista_Vehiculos
{
    // Apunta al primer nodo de la lista
    public Nodo_Vehiculo Inicio { get; set; }

    // Constructor de la lista
    public Lista_Vehiculos()
    {
        Inicio = null;
    }

    // Agrega un vehículo al final de la lista
    public void Agregar_Vehiculo(string placa, string marca, string modelo, int año, double precio)
    {
        Nodo_Vehiculo nuevo = new Nodo_Vehiculo(placa, marca, modelo, año, precio);

        // Si la lista está vacía, el nuevo nodo será el primero
        if (Inicio == null)
        {
            Inicio = nuevo;
        }
        else
        {
            // Se recorre la lista hasta llegar al último nodo
            Nodo_Vehiculo actual = Inicio;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;
        }
    }

    // Busca un vehículo por su placa
    public Nodo_Vehiculo Buscar_Vehiculo(string placa)
    {
        Nodo_Vehiculo actual = Inicio;

        while (actual != null)
        {
            if (actual.Placa == placa)
                return actual;

            actual = actual.Siguiente;
        }

        return null;
    }

    // Muestra los vehículos que coincidan con un año específico
    public void Ver_Vehiculos_Por_Año(int año)
    {
        Nodo_Vehiculo actual = Inicio;
        bool encontrado = false;

        while (actual != null)
        {
            if (actual.Año == año)
            {
                Console.WriteLine($"Placa: {actual.Placa}, Marca: {actual.Marca}, Modelo: {actual.Modelo}, Año: {actual.Año}, Precio: {actual.Precio}");
                encontrado = true;
            }
            actual = actual.Siguiente;
        }

        if (!encontrado)
        {
            Console.WriteLine("No se encontraron vehículos para el año indicado");
        }
    }

    // Muestra todos los vehículos registrados
    public void Ver_Todos_Los_Vehiculos()
    {
        Nodo_Vehiculo actual = Inicio;

        if (actual == null)
        {
            Console.WriteLine("No hay vehículos registrados");
            return;
        }

        while (actual != null)
        {
            Console.WriteLine($"Placa: {actual.Placa}, Marca: {actual.Marca}, Modelo: {actual.Modelo}, Año: {actual.Año}, Precio: {actual.Precio}");
            actual = actual.Siguiente;
        }
    }

    // Elimina un vehículo de la lista según la placa
    public void Eliminar_Vehiculo(string placa)
    {
        if (Inicio == null)
        {
            Console.WriteLine("La lista está vacía");
            return;
        }

        // Si el vehículo a eliminar es el primero
        if (Inicio.Placa == placa)
        {
            Inicio = Inicio.Siguiente;
            Console.WriteLine("Vehículo eliminado correctamente");
            return;
        }

        Nodo_Vehiculo anterior = Inicio;
        Nodo_Vehiculo actual = Inicio.Siguiente;

        while (actual != null)
        {
            if (actual.Placa == placa)
            {
                anterior.Siguiente = actual.Siguiente;
                Console.WriteLine("Vehículo eliminado correctamente");
                return;
            }

            anterior = actual;
            actual = actual.Siguiente;
        }

        Console.WriteLine("Vehículo no encontrado");
    }
}
