using System;

// Clase que administra la lista enlazada de estudiantes
public class Lista_Estudiantes
{
    // Punteros al inicio y final de la lista
    public Nodo_Estudiante Inicio { get; set; }
    public Nodo_Estudiante Final { get; set; }

    // Contadores de aprobados y reprobados
    public int Aprobados { get; set; }
    public int Reprobados { get; set; }

    // Constructor: inicializa la lista vacía
    public Lista_Estudiantes()
    {
        Inicio = null;
        Final = null;
        Aprobados = 0;
        Reprobados = 0;
    }

    // Agrega un estudiante a la lista
    // Aprobados al inicio, reprobados al final
    public void Agregar_Estudiante(string cedula, string nombre, string apellido, string correo, double nota)
    {
        if (nota < 1 || nota > 10)
        {
            Console.WriteLine("La nota debe estar entre 1 y 10.");
            return;
        }

        Nodo_Estudiante nuevo = new Nodo_Estudiante(cedula, nombre, apellido, correo, nota);

        if (nota >= 7)
        {
            nuevo.Siguiente = Inicio;
            Inicio = nuevo;

            if (Final == null)
                Final = nuevo;

            Aprobados++;
        }
        else
        {
            if (Inicio == null)
            {
                Inicio = nuevo;
                Final = nuevo;
            }
            else
            {
                Final.Siguiente = nuevo;
                Final = nuevo;
            }

            Reprobados++;
        }
    }

    // Busca un estudiante por cédula
    public Nodo_Estudiante Buscar_Estudiante(string cedula)
    {
        Nodo_Estudiante actual = Inicio;

        while (actual != null)
        {
            if (actual.Cedula == cedula)
                return actual;

            actual = actual.Siguiente;
        }

        return null;
    }

    // Elimina un estudiante de la lista por cédula
    public void Eliminar_Estudiante(string cedula)
    {
        if (Inicio == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        if (Inicio.Cedula == cedula)
        {
            if (Inicio.Nota >= 7)
                Aprobados--;
            else
                Reprobados--;

            Inicio = Inicio.Siguiente;

            if (Inicio == null)
                Final = null;

            Console.WriteLine("Estudiante eliminado correctamente.");
            return;
        }

        Nodo_Estudiante anterior = Inicio;
        Nodo_Estudiante actual = Inicio.Siguiente;

        while (actual != null)
        {
            if (actual.Cedula == cedula)
            {
                if (actual.Nota >= 7)
                    Aprobados--;
                else
                    Reprobados--;

                anterior.Siguiente = actual.Siguiente;

                if (actual == Final)
                    Final = anterior;

                Console.WriteLine("Estudiante eliminado correctamente.");
                return;
            }

            anterior = actual;
            actual = actual.Siguiente;
        }

        Console.WriteLine("Estudiante no encontrado.");
    }

    // Retorna el total de aprobados
    public int Total_Aprobados()
    {
        return Aprobados;
    }

    // Retorna el total de reprobados
    public int Total_Reprobados()
    {
        return Reprobados;
    }

    // Muestra todos los estudiantes registrados
    public void Imprimir_Lista()
    {
        Nodo_Estudiante actual = Inicio;

        while (actual != null)
        {
            Console.WriteLine(
                $"Cédula: {actual.Cedula}, Nombre: {actual.Nombre}, Apellido: {actual.Apellido}, Correo: {actual.Correo}, Nota: {actual.Nota}"
            );
            actual = actual.Siguiente;
        }
    }
}
