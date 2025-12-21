namespace Agenda_de_turnos
{
    // Estructura Turno
    // Se utiliza para representar un turno en la agenda
    // Es una estructura porque almacena datos simples relacionados
    public struct Turno
    {
        // Día del turno (fila de la matriz)
        public int Dia;

        // Número de turno dentro del día (columna de la matriz)
        public int NumeroTurno;

        // Paciente asignado al turno (puede ser null si está libre)
        public Paciente PacienteAsignado;
    }
}
