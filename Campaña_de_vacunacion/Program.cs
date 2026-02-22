using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Se crea el conjunto ficticio de 500 ciudadanos utilizando Enumerable.Range y se almacena en una lista de objetos tipo Ciudadano
        var todos = Enumerable.Range(1, 500)
            .Select(i => new Ciudadano { Nombre = $"Ciudadano {i}" })
            .ToList();

        // Se crea un único objeto Random
        Random rnd = new Random();

        // Se crea el conjunto Pfizer de 75 personas
        
        var pfizer = todos.Take(75)
            .Select(c =>
            {
                c.Vacuna = "Pfizer";
                c.Dosis1 = true;
                c.Dosis2 = rnd.NextDouble() < 0.8; // 80% probabilidad segunda dosis
                return c;
            })
            .ToList();

        // Se crea el conjunto AstraZeneca de 75 personas
        
        var astraZeneca = todos.Skip(75).Take(75)
            .Select(c =>
            {
                c.Vacuna = "AstraZeneca";
                c.Dosis1 = true;
                c.Dosis2 = rnd.NextDouble() < 0.8;
                return c;
            })
            .ToList();

        // Operaciones de los conjuntos

        // Unión (Pfizer ∪ AstraZeneca)
        var vacunados = pfizer
            .Union(astraZeneca, new CompararCiudadano())
            .ToList();

        // Diferencia (Todos - Vacunados)
        var noVacunados = todos
            .Except(vacunados, new CompararCiudadano())
            .ToList();

        // Ciudadanos con ambas dosis
        var ambasDosis = vacunados
            .Where(c => c.Dosis1 && c.Dosis2)
            .ToList();

        // Diferencia (Pfizer - AstraZeneca)
        var soloPfizer = pfizer
            .Except(astraZeneca, new CompararCiudadano())
            .ToList();

        // Diferencia (AstraZeneca - Pfizer)
        var soloAstraZeneca = astraZeneca
            .Except(pfizer, new CompararCiudadano())
            .ToList();

        // Se muestran los resultados

        Console.WriteLine("----RESULTADOS----\n");

        Console.WriteLine($"Total de ciudadanos: {todos.Count}");
        Console.WriteLine($"Vacunados: {vacunados.Count}");
        Console.WriteLine($"No vacunados: {noVacunados.Count}");
        Console.WriteLine($"Con ambas dosis: {ambasDosis.Count}");
        Console.WriteLine($"Solo Pfizer: {soloPfizer.Count}");
        Console.WriteLine($"Solo AstraZeneca: {soloAstraZeneca.Count}");
    }
}
