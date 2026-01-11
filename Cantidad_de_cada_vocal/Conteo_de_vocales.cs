using System;
using System.Collections.Generic;

// Clase que se encarga de almacenar una palabra y calcular cuántas veces aparece cada vocal
public class Conteo_de_vocales
{
    // Atributo que almacena la palabra ingresada por el usuario
    public string Palabra { get; set; }

    // Diccionario que guarda cada vocal y la cantidad de veces que aparece
    public Dictionary<char, int> Vocales { get; set; }

    // Constructor de la clase
    // Recibe la palabra ingresada e inicializa el diccionario de vocales
    public Conteo_de_vocales(string palabra)
    {
        Palabra = palabra;

        Vocales = new Dictionary<char, int>
        {
            { 'a', 0 },
            { 'e', 0 },
            { 'i', 0 },
            { 'o', 0 },
            { 'u', 0 }
        };
    }

    // Método que realiza el cálculo del número de vocales
    // Recorre la palabra y aumenta el contador correspondiente a cada vocal
    public void Calculo_de_vocales()
    {
        // Se convierte la palabra a minúsculas para evitar diferencias
        foreach (char c in Palabra.ToLower())
        {
            // Si el carácter es una vocal, se incrementa su contador
            if (Vocales.ContainsKey(c))
            {
                Vocales[c]++;
            }
        }
    }

    // Método que muestra el resultado del conteo
    public void MostrarResultado()
    {
        Console.WriteLine("Número de veces que contiene cada vocal:");

        foreach (var vocal in Vocales)
        {
            Console.WriteLine($"{vocal.Key}: {vocal.Value}");
        }
    }
}
