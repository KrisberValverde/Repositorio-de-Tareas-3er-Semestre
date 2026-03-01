using System;
using System.Collections.Generic;

namespace TraductorBasico
{
    class Program
    {
        // Diccionario para traducir de Inglés a Español
        static Dictionary<string, string> ingAEsp =
            new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        // Diccionario para traducir de Español a Inglés
        static Dictionary<string, string> espAIng =
            new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        static void Main(string[] args)
        {
            // Se cargan las palabras iniciales al iniciar el programa
            InicializarDiccionarios();

            int opcion;

            // Menú principal que se repite hasta que el usuario elija salir
            do
            {
                Console.WriteLine("\n==================== MENÚ ====================");
                Console.WriteLine("1. Traducir una frase");
                Console.WriteLine("2. Agregar palabras al diccionario");
                Console.WriteLine("3. Salir");
                Console.Write("\nSeleccione una opción: ");

                // Validación para evitar errores si el usuario escribe letras
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Debe ingresar un número válido.");
                    continue;
                }

                // Estructura switch para ejecutar la opción seleccionada
                switch (opcion)
                {
                    case 1:
                        MenuTraduccion();
                        break;

                    case 2:
                        AgregarPalabra();
                        break;

                    case 3:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            } while (opcion != 3); // El ciclo termina cuando el usuario elige 3
        }

        // Método que carga las palabras necesarias en ambos diccionarios
        static void InicializarDiccionarios()
        {
            string[,] datos = {

                {"Días", "Days"},
                {"fríos", "cold"},
                {"y", "and"},
                {"café", "coffee"},
                {"caliente", "hot"},
                {"son", "are"},
                {"perfectos", "perfect"},
                {"para", "for"},
                {"empezar", "starting"},
                {"una", "a"},
                {"lectura", "read"},
                {"nueva", "new"},
                {"Amo", "Love"},
                {"el", "the"},
                {"violeta", "violet"},
                {"hermoso", "beautiful"},
                {"color", "color"},
                {"de", "of"},
                {"las", "the"},
                {"moras", "blackberries"}
            };

            // Se recorren los datos y se agregan a ambos diccionarios
            for (int i = 0; i < datos.GetLength(0); i++)
            {
                // Español a Inglés
                espAIng[datos[i, 0]] = datos[i, 1];

                // Inglés a Español
                ingAEsp[datos[i, 1]] = datos[i, 0];
            }
        }

        // Submenú para elegir el tipo de traducción
        static void MenuTraduccion()
        {
            Console.WriteLine("\n1. Traducir frase de Español a Inglés");
            Console.WriteLine("2. Traducir frase de Inglés a Español");
            Console.Write("Seleccione: ");

            string subOpcion = Console.ReadLine();

            // Dependiendo de la opción se envía el diccionario correcto
            if (subOpcion == "1")
                ProcesarTraduccion(espAIng, "Español a Inglés");
            else if (subOpcion == "2")
                ProcesarTraduccion(ingAEsp, "Inglés a Español");
            else
                Console.WriteLine("Opción cancelada.");
        }

        // Método que procesa la frase y realiza la traducción palabra por palabra
        static void ProcesarTraduccion(Dictionary<string, string> diccionario, string modo)
        {
            Console.WriteLine($"\nMODO: {modo}");
            Console.Write("Ingrese la frase: ");

            string frase = Console.ReadLine();

            // Validación por si el usuario no escribe nada
            if (string.IsNullOrWhiteSpace(frase))
            {
                Console.WriteLine("No se ingresó ninguna frase.");
                return;
            }

            // Se divide la frase en palabras usando el espacio como separador
            string[] palabras = frase.Split(' ');

            // Lista donde se guardará la frase traducida
            List<string> resultado = new List<string>();

            foreach (string palabra in palabras)
            {
                // Se eliminan signos de puntuación para buscar correctamente en el diccionario
                string limpia = palabra.Trim(',', '.', '!', '?', '¡', '¿');

                // Si la palabra existe en el diccionario, se traduce
                if (diccionario.ContainsKey(limpia))
                {
                    string traduccion = diccionario[limpia];

                    // Se reemplaza la palabra original manteniendo los signos
                    resultado.Add(palabra.Replace(limpia, traduccion));
                }
                else
                {
                    // Si no existe en el diccionario, se deja igual
                    resultado.Add(palabra);
                }
            }

            // Se muestra el resultado final uniendo las palabras traducidas
            Console.WriteLine("\nResultado: " + string.Join(" ", resultado));
        }

        // Método que permite al usuario agregar nuevas palabras al diccionario
        static void AgregarPalabra()
        {
            Console.Write("\nPalabra en INGLÉS: ");
            string ing = Console.ReadLine().Trim();

            Console.Write("Palabra en ESPAÑOL: ");
            string esp = Console.ReadLine().Trim();

            // Validación para evitar palabras vacías
            if (string.IsNullOrWhiteSpace(ing) || string.IsNullOrWhiteSpace(esp))
            {
                Console.WriteLine("No se permiten palabras vacías.");
                return;
            }

            // Se agregan las nuevas palabras a ambos diccionarios
            ingAEsp[ing] = esp;
            espAIng[esp] = ing;

            Console.WriteLine("¡Palabra guardada correctamente!");
        }
    }
}

