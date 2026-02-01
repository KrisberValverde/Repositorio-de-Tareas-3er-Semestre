// Representa un asiento del auditorio
public class Asiento
{
    // Número del asiento
    public int Numero { get; set; }

    // Indica si el asiento está ocupado
    public bool Ocupado { get; set; }

    // Constructor del asiento
    public Asiento(int numero)
    {
        Numero = numero;
        Ocupado = false;
    }
}
