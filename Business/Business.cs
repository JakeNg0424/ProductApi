using ProductsApi.DataAccess;

namespace ProductsApi.Business;

public class Business : IBusiness
{
    private IProductsRepository ProductsRepository { get; set; }

    public Business(IProductsRepository repo)
    {
        ProductsRepository = repo;
    }

    public List<string> GetTopThreeProductsWith(int top, int starsNeeded)
    {
        var allProducts = ProductsRepository.Get();

        Dictionary<(int, string), int> frequency = new Dictionary<(int, string), int>();
        foreach (var product in allProducts.Products)
        {
            var countReview = product.Reviews.Where(r => r.Star == starsNeeded).Count();
            frequency.Add((product.Id, product.Name), countReview);
        }

        PriorityQueue<(int, string), int> queue = new PriorityQueue<(int, string), int>();
        foreach (var item in frequency)
        {
            queue.Enqueue(item.Key, item.Value);
            if (queue.Count > top)
            {
                queue.Dequeue();
            }
        }

        List<string> productNames = new List<string>();
        while (queue.Count > 0)
        {
            var productTuple = queue.Dequeue();
            productNames.Add(productTuple.Item2);
        }

        return productNames;
    }
}