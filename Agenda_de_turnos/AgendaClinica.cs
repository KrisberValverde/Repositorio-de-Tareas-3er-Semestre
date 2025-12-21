using System;

namespace Agenda_de_turnos
{
    // Clase AgendaClinica:
    // Se encarga de administrar la agenda de turnos de la clínica
    public class AgendaClinica
    {
        // Matriz bidimensional de turnos
        // Filas = días / Columnas = turnos por día
        private Turno[,] agenda;

        // Cantidad total de días en la agenda
        private int dias;

        // Cantidad de turnos disponibles por cada día
        private int turnosPorDia;

        // Constructor: inicializa la agenda
        public AgendaClinica(int dias, int turnosPorDia)
        {
            this.dias = dias;
            this.turnosPorDia = turnosPorDia;

            // Se crea la matriz con el tamaño indicado
            agenda = new Turno[dias, turnosPorDia];

            // Inicializar todos los turnos como libres
            // El usuario verá los días y turnos iniciando desde 1
            for (int d = 0; d < dias; d++)
            {
                for (int t = 0; t < turnosPorDia; t++)
                {
                    agenda[d, t].Dia = d + 1;            // Día visible
                    agenda[d, t].NumeroTurno = t + 1;    // Turno visible
                    agenda[d, t].PacienteAsignado = null;
                }
            }
        }

        // Registra un paciente en un día y turno específicos
        public void RegistrarTurno(int dia, int turno, Paciente paciente)
        {
        // Ajuste porque el usuario usa días y turnos desde 1
        int d = dia - 1;
        int t = turno - 1;

        // Verificación de rangos
        if (d < 0 || d >= dias || t < 0 || t >= turnosPorDia)
        {
            Console.WriteLine("Día o turno fuera de rango.");
            return;
        }

        // Verificar si el turno está libre
        if (agenda[d, t].PacienteAsignado == null)
        {
            agenda[d, t].PacienteAsignado = paciente;

            Console.WriteLine("Turno registrado correctamente.");
            Console.WriteLine(
                $"Día {dia}, Turno {turno}: {paciente.GetInfo()}");
        }
    else
    {
        Console.WriteLine("El turno ya está ocupado.");
    }
}

        // Método para consultar un turno específico
        // Muestra el día y turno iniciando desde 1
        public void ConsultarTurno(int dia, int turno)
        {
            int diaIndex = dia - 1;
            int turnoIndex = turno - 1;

            if (diaIndex >= 0 && diaIndex < dias &&
                turnoIndex >= 0 && turnoIndex < turnosPorDia)
            {
                if (agenda[diaIndex, turnoIndex].PacienteAsignado != null)
                {
                    Console.WriteLine(
                        $"Día {dia}, Turno {turno}: {agenda[diaIndex, turnoIndex].PacienteAsignado.GetInfo()}");
                }
                else
                {
                    Console.WriteLine($"Día {dia}, Turno {turno}: Libre");
                }
            }
            else
            {
                Console.WriteLine("Día o turno fuera de rango.");
            }
        }

        // Método que muestra toda la agenda de la clínica
        public void ListarAgenda()
        {
            for (int d = 0; d < dias; d++)
            {
                //Muestra el día una sola vez
                Console.WriteLine($"\nDía {d + 1}:");

                for (int t = 0; t < turnosPorDia; t++)
                {
                    if (agenda[d, t].PacienteAsignado != null)
                    {
                         Console.WriteLine(
                            $"  Turno {t + 1}: {agenda[d, t].PacienteAsignado.GetInfo()}");
                    }
                    else
                    {
                        Console.WriteLine($"  Turno {t + 1}: Libre");
                    }
                }
            }
        }
    }
}
