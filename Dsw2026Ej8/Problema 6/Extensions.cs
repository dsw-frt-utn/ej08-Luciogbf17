namespace Dsw2026Ej8.Problema_6;

public static class Extensions
{
    public static string ToProductCode(this String p)
    {
        String valor;
        if (p == null)
        {
            valor = "SIN CODIGO";
        }

        valor = p.Trim();
        valor = valor.ToUpper();
        valor = valor.Replace(' ', '-');
        
        return valor;
    }
}