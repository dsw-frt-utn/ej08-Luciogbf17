namespace Dsw2026Ej8.Domain;

public class Product
{
    private String _description;

    public Product(String description)
    {
        _description = description;
    }

    public String getDescription()
    {
        return _description;
    }

    public void setDescription(String d)
    {
        _description = d; 
    }
}