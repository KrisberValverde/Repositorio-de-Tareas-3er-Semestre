// Namespace del proyecto, esto agrupa todas las clases de la aplicación
namespace Agenda_de_turnos
{
    // Clase Persona: representa a una persona genérica
    // Sirve como clase base para otras clases (herencia)
    public class Persona
    {
        // Propiedad que almacena el nombre de la persona
        public string Nombre { get; set; }

        // Propiedad que almacena la cédula de la persona
        public string Cedula { get; set; }

        // Constructor: se ejecuta cuando se crea un objeto Persona
        public Persona(string nombre, string cedula)
        {
            Nombre = nombre;
            Cedula = cedula;
        }

        // Método virtual que devuelve la información básica de la persona
        // Es virtual para que pueda ser sobrescrito en clases hijas
        public virtual string GetInfo()
        {
            return $"Nombre: {Nombre} | Cédula: {Cedula}";
        }
    }
}
