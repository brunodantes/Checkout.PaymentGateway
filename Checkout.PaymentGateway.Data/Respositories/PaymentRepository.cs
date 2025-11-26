using Checkout.PaymentGateway.Domain.Repositories;
using Checkout.PaymentGateway.Entities.Models;

namespace Checkout.PaymentGateway.Data.Respositories;
public class PaymentRepository : IPaymentRepository
{
    private readonly List<PaymentModel> _paymentRequest = [];

    public async Task AddPayment(PaymentModel paymentRequest)
    {
        _paymentRequest.Add(paymentRequest);
    }

    public async Task<PaymentModel?> GetPayment(Guid id)
    {
        return _paymentRequest.FirstOrDefault(x => x.Id == id);
    }
}
