// Clase base para figuras geométricas
// Esta clase sirve como plantilla para cualquier figura geométrica que requiera calcular su área y su perímetro. 
// Al ser abstracta, no puede instanciarse directamente; solo puede ser heredada.
public abstract class FiguraGeometrica
{
    // Método abstracto para calcular el área de la figura.
    // Las clases hijas deben sobrescribir este método y proporcionar
    // su propia fórmula según el tipo de figura (cuadrado, triángulo, etc.).
    public abstract double CalcularArea();

    // Método abstracto para calcular el perímetro de la figura.
    // Al igual que el método anterior, las clases derivadas deben
    // implementar su versión específica que calcule el perímetro.
    public abstract double CalcularPerimetro();
}
