using BlazingShop.Shared;

namespace BlazingShop.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action OnChange;
        List<Product> Products { get; set; }
        Task LoadProducts(string categoryUrl = null);
        Task<Product> GetProduct(int id);
        Task LoadProductsByEditionAsync(int editionId);
    }
}
