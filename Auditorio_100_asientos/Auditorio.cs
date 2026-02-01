using System;

// Clase principal que gestiona el auditorio
public class Auditorio
{
    private Cola_para_Personas cola_personas;
    private Cola_para_Asientos cola_asientos;

    // Constructor del auditorio
    public Auditorio(int cantidad_asientos)
    {
        cola_personas = new Cola_para_Personas();
        cola_asientos = new Cola_para_Asientos();

        // Crear los asientos del auditorio
        for (int i = 1; i <= cantidad_asientos; i++)
        {
            cola_asientos.Enqueue(new Asiento(i));
        }
    }

    // Registra una persona en la cola de ingreso
    public void Registrar_Persona(Persona persona)
    {
        cola_personas.Enqueue(persona);
        Console.WriteLine($"{persona.Nombre} fue registrada correctamente.");
    }

    // Asigna un asiento respetando el orden de llegada
    public void Asignar_Asiento()
    {
        if (!cola_personas.Esta_Vacia())
        {
            if (cola_asientos.Hay_Asientos())
            {
                Persona persona = cola_personas.Dequeue();
                Asiento asiento = cola_asientos.Dequeue();
                asiento.Ocupado = true;

                Console.WriteLine($"Asiento {asiento.Numero} asignado a {persona.Nombre}");
            }
            else
            {
                Console.WriteLine("No hay asientos disponibles.");
            }
        }
    }
}
