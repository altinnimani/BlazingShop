using BlazingShop.Client.Services.ProductService;
using BlazingShop.Shared;
using Blazored.LocalStorage;
using Blazored.Toast.Services;
using System.Net.Http.Json;

namespace BlazingShop.Client.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly ILocalStorageService _localStorage;
        private readonly IProductService _productService;
        private readonly HttpClient _http;
        private readonly IToastService _toastService;

        public event Action OnChange;

        public CartService(
            ILocalStorageService localStorage, 
            IToastService toastService,
            IProductService productService,
            HttpClient http)
        {
            _localStorage = localStorage;
            _toastService = toastService;
            _productService = productService;
            _http = http;
        }

        public async Task AddToCart(CartItem item)
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if (cart == null)
            {
                cart = new List<CartItem>();
            }

            if (cart.Find(x => x.ProductId == item.ProductId && x.EditionId == item.EditionId) == null)
            {
                cart.Add(item);
            }
            else
            {
                cart.FirstOrDefault(x => x.ProductId == item.ProductId && x.EditionId == item.EditionId).Quantity += item.Quantity;
            }

            await _localStorage.SetItemAsync("cart", cart);

            var product = await _productService.GetProduct(item.ProductId);
            _toastService.ShowSuccess(item.Quantity + "x " + product.Title, "Added to cart:");

            OnChange.Invoke();
        }

        public async Task<List<CartItem>> GetCartItems()
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if (cart == null)
            {
                return new List<CartItem>();
            }
            return cart.OrderByDescending(r => (r.Price /* * r.Quantity*/)).ToList();
        }

        public async Task DeleteItem(CartItem item)
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if (cart == null)
            {
                return;
            }
            var cartItem = cart.Find(x => x.ProductId == item.ProductId && x.EditionId == item.EditionId);

            if (cartItem == null)
            {
                return;
            }
            cart.Remove(cartItem);
            await _localStorage.SetItemAsync("cart", cart);
            OnChange.Invoke();
        }

        public async Task EmptyCart()
        {
            await _localStorage.RemoveItemAsync("cart");
            OnChange.Invoke();
        }

        public async Task<string> Checkout()
        {
            var result = await _http.PostAsJsonAsync("api/payment/checkout", await GetCartItems());
            var url = await result.Content.ReadAsStringAsync();
            return url;
        }
    }
}
