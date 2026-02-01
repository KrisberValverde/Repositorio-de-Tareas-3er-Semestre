using System;
class Program
{
    static void Main(string[] args)
    {
        // Crear auditorio con 100 asientos
        Auditorio auditorio = new Auditorio(100);

        Console.WriteLine("Asistentes registrados:");
        Console.WriteLine();

        // Registro de personas, simulación de dos registradores
        auditorio.Registrar_Persona(new Persona("Keila"));
        auditorio.Registrar_Persona(new Persona("Sophia"));
        auditorio.Registrar_Persona(new Persona("Naidelin"));
        auditorio.Registrar_Persona(new Persona("Holly"));

        Console.WriteLine();
        Console.WriteLine("Asientos que fueron asignados");
        Console.WriteLine();

        // Asignación de asientos
        auditorio.Asignar_Asiento();
        auditorio.Asignar_Asiento();
        auditorio.Asignar_Asiento();
        auditorio.Asignar_Asiento();

        Console.ReadLine();
    }
}
