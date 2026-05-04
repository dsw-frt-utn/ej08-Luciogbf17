using Dsw2026Ej8.Domain;

namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        { Console.WriteLine("Hello, World!");
            var problema1 = new ProductHelper().ObtenerEtiquetaProducto(123, "pastafrola", 1500);
            Console.WriteLine(problema1);

            var problema2 = new Problema2().CrearResumenVenta(124, "Papas lays", 3, 2000);
            Console.WriteLine(problema2);

            var p1 = new Product("bonobon");
            var problema3 = new Problema3().CompararCopias(10, p1);
            Console.WriteLine(problema3);
            
            
            var problema4 = new Problema4().CalcularPromedio(null, null, null);
            Console.WriteLine(problema4);
            
            
            
            
            
            
            
            
        }
    }
}
