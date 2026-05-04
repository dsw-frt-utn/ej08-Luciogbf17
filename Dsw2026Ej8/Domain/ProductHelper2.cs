namespace Dsw2026Ej8.Domain;

public partial class ProductHelper
{
    public static String DescripcionAMayuscula(string d)
    {
        
        var valor = d.ToUpperInvariant();
        return valor;
    }
}