using Checkout.PaymentGateway.Infrastructure.BankSimulator.Domain;
using Checkout.PaymentGateway.Infrastructure.BankSimulator.Models;

namespace Checkout.PaymentGateway.Application.Tests;

public class BankSimulatorFake : IBankSimulatorService
{
    public async Task<BankResponseModel> ExecuteBankValidation(BankRequestModel bankRequestModel)
    {
        return await Task.FromResult(new BankResponseModel() { AuthorizationCode = Guid.NewGuid().ToString(), Authorized = true });
    }
}
