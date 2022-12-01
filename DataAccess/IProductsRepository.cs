using ProductsApi.DataAccess.Entities;

namespace ProductsApi.DataAccess;

public interface IProductsRepository
{
    AllProducts Get();
}