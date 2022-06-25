using BlazingShop.Shared;

namespace BlazingShop.Client.Services.CartService
{
    public interface ICartService
    {
        event Action OnChange;
        Task AddToCart(ProductVariant productVariant);
        Task<List<CartItem>> GetCartItems();
        Task DeleteItem(CartItem item);
        Task AddDTOItem(CartItem item);
    }
}
