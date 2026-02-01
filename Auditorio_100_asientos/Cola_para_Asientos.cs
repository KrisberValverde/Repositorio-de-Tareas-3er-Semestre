using System.Collections.Generic;

// Cola que administra los asientos disponibles en orden FIFO
public class Cola_para_Asientos
{
    private Queue<Asiento> asientos;

    // Constructor
    public Cola_para_Asientos()
    {
        asientos = new Queue<Asiento>();
    }

    // Agrega un asiento disponible
    public void Enqueue(Asiento asiento)
    {
        asientos.Enqueue(asiento);
    }

    // Asigna el siguiente asiento disponible
    public Asiento Dequeue()
    {
        if (asientos.Count > 0)
            return asientos.Dequeue();

        return null;
    }

    // Verifica si aún hay asientos disponibles
    public bool Hay_Asientos()
    {
        return asientos.Count > 0;
    }
}
