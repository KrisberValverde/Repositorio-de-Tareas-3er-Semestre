// Clase que representa un Rombo, esta clase hereda de la clase base FiguraGeometrica
public class Rombo : FiguraGeometrica
{
    // Campos privados que almacenan las longitudes de las dos diagonales del rombo
    private double diagonal1;
    private double diagonal2;

    // Constructor que recibe las diagonales y las asigna a los campos internos
    // Esto permite crear un objeto Rombo con los valores necesarios para sus cálculos
    public Rombo(double diagonal1, double diagonal2)
    {
        this.diagonal1 = diagonal1;
        this.diagonal2 = diagonal2;
    }

    // Método sobrescrito que calcula el área del rombo
    // La fórmula matemática para el área de un rombo es:
    // Área = (Diagonal mayor * Diagonal menor) / 2
    // Por eso multiplicamos ambas diagonales y dividimos entre 2
    public override double CalcularArea()
    {
        return (diagonal1 * diagonal2) / 2;
    }

    // Método sobrescrito que calcula el perímetro del rombo
    // En un rombo, los cuatro lados son iguales. Para obtener el lado,
    // se usa el teorema de Pitágoras porque cada mitad de las diagonales forma un triángulo rectángulo:
    // lado = √( (diagonal1/2)^2 + (diagonal2/2)^2 )
    // Luego el perímetro es simplemente 4 * lado
    public override double CalcularPerimetro()
    {
        // Cálculo del valor de un lado del rombo usando Pitágoras
        double lado = Math.Sqrt(Math.Pow(diagonal1 / 2, 2) + Math.Pow(diagonal2 / 2, 2));

        // El perímetro es cuatro veces el lado
        return 4 * lado;
    }
}
