using BlazingShop.Shared;
using Stripe.Checkout;

namespace BlazingShop.Server.Services.PaymentService
{
    public interface IPaymentService
    {
        Session CreateCheckoutSession(List<CartItem> cartItems);
    }
}
