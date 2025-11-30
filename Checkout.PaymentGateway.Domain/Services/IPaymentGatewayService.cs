using Checkout.PaymentGateway.Contract.Requests;
using Checkout.PaymentGateway.Entities.Models;

namespace Checkout.PaymentGateway.Domain.Services;
public interface IPaymentGatewayService
{
    Task<PaymentModel> AddPayment(PaymentRequest paymentRequest);
    Task<PaymentModel> GetPaymentDetails(Guid paymentDetail);
}
