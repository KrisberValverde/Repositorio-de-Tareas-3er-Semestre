using System;
using System.Collections.Generic;

public class Program
{
    // Método que verifica si una expresión matemática tiene los paréntesis, llaves y corchetes balanceados.
    static bool VerificarBalance(string expresion)
    {
        // Pila que almacenará los símbolos de apertura
        Stack<char> pila = new Stack<char>();

        // Diccionario que relaciona apertura con su respectivo cierre
        Dictionary<char, char> pares = new Dictionary<char, char>()
        {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' }
        };

        // Se recorre la expresión carácter por carácter
        foreach (char caracter in expresion)
        {
            // Si el carácter es un símbolo de apertura, se apila
            if (pares.ContainsKey(caracter))
            {
                pila.Push(caracter);
            }
            // Si el carácter es un símbolo de cierre, se valida
            else if (pares.ContainsValue(caracter))
            {
                // Si la pila está vacía, no hay símbolo que cerrar
                if (pila.Count == 0)
                    return false;

                // Se obtiene el último símbolo de apertura
                char ultimo = pila.Pop();

                // Se verifica que el símbolo de cierre sea el correcto
                if (pares[ultimo] != caracter)
                    return false;
            }
            // Si hay otros caracteres como números y operadores se ignoran
        }

        // Si la pila queda vacía, la expresión está correctamente balanceada
        return pila.Count == 0;
    }

    // Método principal del programa
    public static void Main(string[] args)
    {
        // Expresión de prueba
        string expresion = "{7 + (8 * 5) - [(9 - 7) + (4 + 1)]}";

        // Se muestra el resultado de la verificación, si la fórmula estaba o no balanceada
        if (VerificarBalance(expresion))
            Console.WriteLine("Fórmula balanceada.");
        else
            Console.WriteLine("Fórmula no balanceada.");
    }
}

