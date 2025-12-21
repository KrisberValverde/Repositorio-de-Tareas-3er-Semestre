using System;

namespace Agenda_de_turnos
{
    // Clase principal del programa
    class Program
    {
        // Método Main: punto de inicio de la aplicación
        static void Main(string[] args)
        {
            // Se crea la agenda con 3 días y 2 turnos por día
            AgendaClinica agenda = new AgendaClinica(3, 2);

            // Creación de pacientes
            Paciente p1 = new Paciente("Hayle Windsor", "2144563452", "Pediatría");
            Paciente p2 = new Paciente("Selena Gómez", "2200456634", "Medicina General");

            // Registro de pacientes en la agenda
            // Los días y turnos comienzan desde 1
            Console.WriteLine("Turnos de pacientes registrados");
            agenda.RegistrarTurno(1, 1, p1);
            agenda.RegistrarTurno(1, 2, p2);

            Console.WriteLine();
            // Consulta de turnos específicos
            Console.WriteLine("Consulta de Turnos");
            agenda.ConsultarTurno(1, 2);
            agenda.ConsultarTurno(1, 1);

            // Mostrar toda la agenda de la clínica
            agenda.ListarAgenda();

            // Pausa para evitar que la consola se cierre automáticamente
            Console.ReadKey();
        }
    }
}
