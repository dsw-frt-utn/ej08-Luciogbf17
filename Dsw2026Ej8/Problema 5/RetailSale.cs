namespace Dsw2026Ej8.Domain;

public class RetailSale : Sale
{
    public override decimal CalculateTotal()
    {
        
        return (decimal) importe;
    }

    public RetailSale(double i) : base(i)
    {
    }
}