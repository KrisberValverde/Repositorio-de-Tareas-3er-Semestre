using System;

// Clase que representa un nodo de la lista enlazada.
// Cada nodo almacena la información de un vehículo
// y una referencia al siguiente nodo.
public class Nodo_Vehiculo
{
    public string Placa { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Año { get; set; }
    public double Precio { get; set; }

    // Referencia al siguiente nodo de la lista
    public Nodo_Vehiculo Siguiente { get; set; }

    // Constructor que inicializa los datos del vehículo
    public Nodo_Vehiculo(string placa, string marca, string modelo, int año, double precio)
    {
        Placa = placa;
        Marca = marca;
        Modelo = modelo;
        Año = año;
        Precio = precio;
        Siguiente = null;
    }
}
