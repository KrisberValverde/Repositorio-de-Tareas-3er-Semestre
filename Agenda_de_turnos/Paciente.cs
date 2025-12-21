namespace Agenda_de_turnos
{
    // Clase Paciente que hereda de la clase Persona
    public class Paciente : Persona
    {
        // Propiedad adicional propia del paciente
        public string Especialidad { get; set; }

        // Constructor del paciente
        // Llama al constructor de la clase base (Persona) usando base
        public Paciente(string nombre, string cedula, string especialidad)
            : base(nombre, cedula)
        {
            Especialidad = especialidad;
        }

        // Sobrescritura del método GetInfo (polimorfismo)
        // Agrega la especialidad a la información del paciente
        public override string GetInfo()
        {
            return base.GetInfo() + $" | Especialidad: {Especialidad}";
        }
    }
}
