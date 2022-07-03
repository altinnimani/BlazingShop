using BlazingShop.Shared;
using Stripe;
using Stripe.Checkout;

namespace BlazingShop.Server.Services.PaymentService
{
    public class PaymentService : IPaymentService
    {
        public PaymentService()
        {

            StripeConfiguration.ApiKey = "sk_test_51LHQFhGDYevQYC4LkPIy6YSV3NO00GGDaSUKRK2thsSwEn5zDVzVC3Gg9qG4Vb0rMNIvkxobMYc3yTdX0nP3k8eF00HjbnJ6dm";
        }

        public Session CreateCheckoutSession(List<CartItem> cartItems)
        {
            var lineItems = new List<SessionLineItemOptions>();
            cartItems.ForEach(ci => lineItems.Add(new SessionLineItemOptions
            {
                PriceData = new SessionLineItemPriceDataOptions {
                    UnitAmountDecimal = ci.Price * 100,
                    Currency = "usd",
                    ProductData = new SessionLineItemPriceDataProductDataOptions
                    {
                        Name = ci.ProductTitle,
                        Images = new List<string> { ci.Image },
                    }
                },
                Quantity = ci.Quantity
            }));

            var options = new SessionCreateOptions
            {
                PaymentMethodTypes = new List<string>
                {
                    "card",
                },
                LineItems = lineItems,
                Mode = "payment",
                SuccessUrl = "https://localhost:7294/order-success",
                CancelUrl = "https://localhost:7294/cart",
            };

            var service = new SessionService();
            Session session = service.Create(options);
            return session;
        }
    }
}
