namespace WebApplication1.Models;

public class CreateProductModel
{
    public string Category { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public int Quantity { get; set; }
}