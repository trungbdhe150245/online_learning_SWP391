using Braintree;

namespace SWP391.Utility.BraintreeService
{
    public interface IBraintreeService
    {
        IBraintreeGateway CreateGateway();
        IBraintreeGateway GetGateway();
    }
}
