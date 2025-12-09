
// Clase para Octágono
// Esta clase representa un octágono regular y permite calcular su área y perímetro.
// Hereda de la clase base FiguraGeometrica, por lo que debe implementar los métodos
// CalcularArea() y CalcularPerimetro().
public class Octágono : FiguraGeometrica
{
    // Se usa propiedad privada para almacenar la longitud de uno de los lados del octágono.
    // Ya que en un octágono regular, todos los lados son iguales, basta con guardar uno.
    private double lado;

    // Constructor que recibe como parámetro la longitud del lado del octágono.
    // Este valor será usado luego para calcular el área y el perímetro.
    public Octágono(double lado)
    {
        // Asignamos el valor recibido al campo privado "lado".
        this.lado = lado;
    }

    // Implementación del método para calcular el área de un octágono regular.
    // La fórmula utilizada es:
    // Área = (2 + 4 / tan(π / 8)) * lado²

    // Un octágono regular puede dividirse en 8 triángulos isósceles.
    // A partir de esa división, se deduce la fórmula general que involucra la tangente del ángulo central (π/8).
    // Math.Tan(Math.PI / 8) obtiene la tangente del ángulo en radianes.
    // Math.Pow(lado, 2) eleva el lado al cuadrado.
    public override double CalcularArea()
    {
        return (2 + 4 / Math.Tan(Math.PI / 8)) * Math.Pow(lado, 2);
    }

    // Implementación del método para calcular el perímetro del octágono regular.
    // Como el octágono tiene 8 lados iguales, su perímetro es:
    // Perímetro = 8 * lado
    public override double CalcularPerimetro()
    {
        return 8 * lado;
    }
}
