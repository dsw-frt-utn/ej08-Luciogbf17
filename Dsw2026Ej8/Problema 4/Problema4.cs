namespace Dsw2026Ej8.Domain;

public class Problema4
{
    public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
    {
        int? suma = 0;
        var dividendo = 0;

        if (nota1.HasValue)
        {
            if (nota1.Value <= 10 && nota1 >= 0)
            {
                suma += nota1.Value;
                dividendo += 1;
            }
            
        }

        
        
        if (nota2.HasValue)
        {
            if (nota2.Value <= 10 && nota2 >= 0)
            {
                suma += nota2.Value;
                dividendo += 1;
            } 
        }

        if (nota3.HasValue)
        {
            if (nota3.Value <= 10 && nota3 >= 0)
            {
                suma += nota3.Value;
                dividendo += 1;
            }
        }

        if (dividendo == 0)
        {
            return 0;
        }
        else
        {
            return (double) suma.Value / dividendo;
        }

    }
}