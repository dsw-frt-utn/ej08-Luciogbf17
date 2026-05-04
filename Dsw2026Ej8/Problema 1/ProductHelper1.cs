namespace Dsw2026Ej8.Domain;

public partial class ProductHelper
{
  public String ObtenerEtiquetaProducto(long code,string d, decimal price)
  {
      var description= DescripcionAMayuscula(d);
      var etiqueta= $"{code} - {description}-${price}";

      return etiqueta;
  }    
}