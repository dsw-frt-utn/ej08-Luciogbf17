namespace Dsw2026Ej8.Domain;

public class Problema3
{
    public String CompararCopias(int originalValue , Product product)
    {
        var copyValue = originalValue;
        copyValue +=1;

        var copyProduct = product;
        copyProduct.setDescription("Alfajor");

        var valorTxt = $"{originalValue} - {copyValue} - {copyProduct.getDescription()}";
        return valorTxt;
    }
}