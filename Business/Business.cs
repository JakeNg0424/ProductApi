using ProductsApi.DataAccess;

namespace ProductsApi.Business;

public class Business : IBusiness
{
    private IProductsRepository ProductsRepository { get; set; }

    public Business(IProductsRepository repo)
    {
        ProductsRepository = repo;
    }

    List<string> IBusiness.GetTopThreeProductsWith(int top, int starsNeeded)
    {
        throw new NotImplementedException();
    }
}