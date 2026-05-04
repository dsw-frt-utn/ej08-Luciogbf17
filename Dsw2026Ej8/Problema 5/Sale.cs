namespace Dsw2026Ej8.Domain;

public class Sale
{
    public double importe;
    public virtual decimal CalculateTotal()
    {
        return 0;
    }

    public Sale(double i)
    {
        importe = i;
    }
}