// Clase principal del programa
class Program
{
    // Método de entrada principal de la aplicación
    // Aquí inicia la ejecución del programa
    static void Main(string[] args)
    {
        //          CREACIÓN Y USO DE UN OBJETO ROMBO
        
        // Crear una instancia de la clase Rombo enviando como parámetros las dos diagonales: diagonal1 = 10 y diagonal2 = 12
        // Esto permite que el objeto rombo pueda calcular su área y perímetro
        Rombo rombo = new Rombo(10, 12);

        // Mostrar el área del rombo llamando al método CalcularArea()
        Console.WriteLine("Área del rombo: " + rombo.CalcularArea());

        // Mostrar el perímetro del rombo llamando al método CalcularPerimetro()
        Console.WriteLine("Perímetro del rombo: " + rombo.CalcularPerimetro());


        //        CREACIÓN Y USO DE UN OBJETO OCTÁGONO
   
        // Crear una instancia de la clase Octágono enviando como parámetro
        // la longitud del lado: lado = 5 cm
        // Con esto el objeto puede realizar los cálculos correspondientes
        Octágono octagono = new Octágono(5);

        // Mostrar el área del octágono utilizando su método sobrescrito
        Console.WriteLine("Área del octágono: " + octagono.CalcularArea());

        // Mostrar el perímetro del octágono utilizando su propio método
        Console.WriteLine("Perímetro del octágono: " + octagono.CalcularPerimetro());
    }
}
