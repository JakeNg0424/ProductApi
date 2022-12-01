namespace ProductsApi.DataAccess.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public List<Review> Reviews { get; set; } = null!;
}