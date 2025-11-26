using Checkout.PaymentGateway.Infrastructure.BankSimulator.Models;

namespace Checkout.PaymentGateway.Infrastructure.BankSimulator.Domain;

public interface IBankSimulatorService
{
    Task<BankResponseModel> ExecuteBankValidation(BankRequestModel bankRequestModel);
}
