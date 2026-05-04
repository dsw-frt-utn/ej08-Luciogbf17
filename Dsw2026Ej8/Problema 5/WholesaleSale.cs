namespace Dsw2026Ej8.Domain;

public class WholesaleSale : Sale
{
    public override decimal CalculateTotal()
    {
        var dto = importe*0.10;
        return (decimal) (importe - dto ); 
    }

    public WholesaleSale(double i) : base(i)
    {
    }
}