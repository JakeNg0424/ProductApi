namespace ProductsApi.Business;

public interface IBusiness
{
    List<string> GetTopThreeProductsWith(int top, int starsNeeded);
}