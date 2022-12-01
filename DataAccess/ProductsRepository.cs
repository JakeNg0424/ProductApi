using ProductsApi.DataAccess.Entities;

namespace ProductsApi.DataAccess;

public class ProductsRepository : IProductsRepository
{
    public AllProducts Get()
    {
        var jsonContent = File.ReadAllText("products.json");
        var allProducts = Newtonsoft.Json.JsonConvert.DeserializeObject<AllProducts>(jsonContent);

        return allProducts ?? new AllProducts();
    }
}