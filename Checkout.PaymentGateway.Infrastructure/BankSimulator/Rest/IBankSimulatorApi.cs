using Checkout.PaymentGateway.Infrastructure.BankSimulator.Models;
using Refit;

namespace Checkout.PaymentGateway.Infrastructure.BankSimulator.Rest;

public interface IBankSimulatorApi
{
    [Post("/payments")]
    Task<ApiResponse<BankResponseModel>> Publish(BankRequestModel bankRequestModel);
}
