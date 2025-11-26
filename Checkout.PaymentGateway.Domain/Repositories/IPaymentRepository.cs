using Checkout.PaymentGateway.Entities.Models;

namespace Checkout.PaymentGateway.Domain.Repositories;

public interface IPaymentRepository
{
    Task AddPayment(PaymentModel paymentRequest);
    Task<PaymentModel?> GetPayment(Guid id);
}
