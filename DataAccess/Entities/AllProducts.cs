namespace ProductsApi.DataAccess.Entities;

public class AllProducts
{
    public IList<Product> Products { get; set; } = null!;
}