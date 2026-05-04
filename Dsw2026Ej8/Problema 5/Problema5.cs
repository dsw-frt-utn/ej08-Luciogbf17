namespace Dsw2026Ej8.Domain;

public class Problema5
{
    public decimal ObtenerImporteFinal(Sale sale)
    {
        var valor = sale.CalculateTotal();
        return valor;
    }
}