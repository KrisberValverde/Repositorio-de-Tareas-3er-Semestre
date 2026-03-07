using System;

namespace PremiacionDeportistas
{
    // Clase que representa a un deportista ganador
    class Deportista
    {
        // Nombre del deportista
        public string Nombre { get; set; }

        // Tipo de medalla obtenida (Oro, Plata o Bronce)
        public string Medalla { get; set; }

        // Constructor que inicializa los datos del deportista
        public Deportista(string nombre, string medalla)
        {
            Nombre = nombre;
            Medalla = medalla;
        }

        // Este método permite comparar deportistas para evitar duplicados
        public override bool Equals(object obj)
        {
            // Verifica si el objeto comparado es un deportista
            if (obj is Deportista d)
            {
                // Se compara el nombre ignorando mayúsculas o minúsculas
                return d.Nombre.ToLower() == Nombre.ToLower();
            }

            return false;
        }

        // Genera un código hash basado en el nombre
        // Esto es necesario cuando se utiliza HashSet
        public override int GetHashCode()
        {
            return Nombre.ToLower().GetHashCode();
        }
    }
}
