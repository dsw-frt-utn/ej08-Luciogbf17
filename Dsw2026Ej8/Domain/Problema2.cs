using System.Numerics;

namespace Dsw2026Ej8.Domain;

public class Problema2
{
    public String CrearResumenVenta(long productCode, string productDescription,int quantity, decimal unitPrice)
    {
        var total = quantity * unitPrice;
        if (quantity < 0)
        {
            total = 0;
        }
        
        var resumenVta = new
            { Code = productCode, Description = productDescription, Quantity = quantity, Total = total };

        var resumenTxt = $"Code:{resumenVta.Code} - Description:{resumenVta.Description} - Total:{resumenVta.Total}";
        
        return resumenTxt;
        
    }
}