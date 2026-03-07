using System;
using System.Collections.Generic;
using System.Linq;

namespace PremiacionDeportistas
{
    // Clase que gestiona todo el sistema de premiación
    class SistemaPremiacion
    {
        // Diccionario para mostrar el menú de disciplinas
        private Dictionary<int, string> menuDisc;

        // Diccionario principal que guarda las disciplinas y sus ganadores
        private Dictionary<string, HashSet<Deportista>> podios;

        // Constructor
        public SistemaPremiacion()
        {
            // Inicialización del menú de disciplinas
            menuDisc = new Dictionary<int, string>()
            {
                {1,"Gimnasia"},
                {2,"Tiro con arco"},
            };

            // Inicialización de los podios
            podios = new Dictionary<string, HashSet<Deportista>>();

            // Se crea un conjunto vacío para cada disciplina
            foreach (var d in menuDisc.Values)
            {
                podios[d] = new HashSet<Deportista>();
            }
        }

        // Método que muestra el menú principal
        public void Ejecutar()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("--- Sistema de premiacion ---");
                Console.WriteLine("1. Registrar ganador");
                Console.WriteLine("2. Mostrar cuadro de honor");
                Console.WriteLine("3. Salir");

                Console.Write("\nSeleccione una opción: ");
                string op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        RegistrarGanador();
                        break;

                    case "2":
                        MostrarCuadro();
                        break;

                    case "3":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        // Método para registrar un ganador
        private void RegistrarGanador()
        {
            Console.WriteLine("--- Seleccione la disciplina ---");

            foreach (var item in menuDisc)
            {
                Console.WriteLine($"{item.Key}. {item.Value}");
            }

            Console.Write("\nOpción: ");

            // Validar selección
            if (int.TryParse(Console.ReadLine(), out int sel) && menuDisc.ContainsKey(sel))
            {
                string disc = menuDisc[sel];

                // Verificar si el podio ya está completo
                if (podios[disc].Count >= 3)
                {
                    Console.WriteLine("\nEl podio ya está completo.");
                    Console.ReadKey();
                    return;
                }

                Console.Write("Nombre del deportista: ");
                string nombre = Console.ReadLine();

                Console.Write("Tipo de medalla (Oro / Plata / Bronce): ");
                string medalla = Console.ReadLine().ToLower();

                // Validación de medalla
                if (medalla != "oro" && medalla != "plata" && medalla != "bronce")
                {
                    Console.WriteLine("Medalla inválida.");
                    Console.ReadKey();
                    return;
                }

                // Verificar que la medalla no esté repetida
                if (podios[disc].Any(d => d.Medalla.ToLower() == medalla))
                {
                    Console.WriteLine("Esta medalla ya fue asignada.");
                    Console.ReadKey();
                    return;
                }

                // Agregar deportista al conjunto
                if (podios[disc].Add(new Deportista(nombre, medalla)))
                {
                    Console.WriteLine($"\n{nombre} registrado con medalla de {medalla}.");
                }
                else
                {
                    Console.WriteLine("Este deportista ya está registrado.");
                }
            }
            else
            {
                Console.WriteLine("Disciplina inválida.");
            }

            Console.ReadKey();
        }

        // Método que muestra el cuadro de honor
        private void MostrarCuadro()
        {
            Console.WriteLine("--- Cuadro de Honor ---");

            // Orden en que deben aparecer las medallas
            List<string> orden = new List<string> { "oro", "plata", "bronce" };

            foreach (var item in podios)
            {
                Console.WriteLine($"\nDisciplina: {item.Key}");

                if (item.Value.Count == 0)
                {
                    Console.WriteLine("Sin premios asignados.");
                }
                else
                {
                    // Mostrar medallas ordenadas
                    foreach (var med in orden)
                    {
                        var ganador = item.Value.FirstOrDefault(d => d.Medalla.ToLower() == med);

                        if (ganador != null)
                        {
                            Console.WriteLine($"{med.ToUpper()}: {ganador.Nombre}");
                        }
                    }
                }
            }

            Console.WriteLine("\nPresione una tecla para volver");
            Console.ReadKey();
        }
    }
}
