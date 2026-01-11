using System;

// Clase Detectar_palindromo
// Se encarga de almacenar la palabra ingresada y verificar si es o no un palíndromo
public class Detectar_palindromo
{
    // Atributo que almacena la palabra ingresada por el usuario
    public string Palabra { get; set; }

    // Constructor de la clase que recibe la palabra y la asigna al atributo
    public Detectar_palindromo(string palabra)
    {
        Palabra = palabra;
    }

    // Método que determina si la palabra es un palíndromo
    // Se usa un boolean que retorna true si la palabra se lee igual de izquierda a derecha o viceversa
    public bool Es_un_Palindromo()
    {
        string palabraInvertida = "";

        // Recorre la palabra desde el último carácter hasta el primero
        for (int i = Palabra.Length - 1; i >= 0; i--)
        {
            palabraInvertida += Palabra[i];
        }

        // Compara la palabra original con la invertida
        return Palabra.ToLower() == palabraInvertida.ToLower();
    }
}
