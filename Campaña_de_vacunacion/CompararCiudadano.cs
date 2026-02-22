using System.Collections.Generic;

// Clase que permite comparar ciudadanos por su nombre
// Se usa en las operaciones de teoría de conjuntos
public class CompararCiudadano : IEqualityComparer<Ciudadano>
{
    // Define cuando dos ciudadanos son iguales, en este caso, si tienen el mismo Nombre
    public bool Equals(Ciudadano x, Ciudadano y)
    {
        return x.Nombre == y.Nombre;
    }

    // Genera un código hash basado en el Nombre
    public int GetHashCode(Ciudadano obj)
    {
        return obj.Nombre.GetHashCode();
    }
}
