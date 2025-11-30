namespace Checkout.PaymentGateway.Common.ExceptionHandler;

public abstract class DomainException(string message) : Exception(message)
{
}