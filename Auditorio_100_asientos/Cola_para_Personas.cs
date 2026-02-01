using System.Collections.Generic;

// Cola que maneja el orden de llegada de las personas, se usa el método FIFO
public class Cola_para_Personas
{
    private Queue<Persona> personas;

    // Constructor
    public Cola_para_Personas()
    {
        personas = new Queue<Persona>();
    }

    // Agrega una persona a la cola
    public void Enqueue(Persona persona)
    {
        personas.Enqueue(persona);
    }

    // Retira a la siguiente persona de la cola
    public Persona Dequeue()
    {
        if (personas.Count > 0)
            return personas.Dequeue();

        return null;
    }

    // Verifica si la cola está vacía
    public bool Esta_Vacia()
    {
        return personas.Count == 0;
    }
}
