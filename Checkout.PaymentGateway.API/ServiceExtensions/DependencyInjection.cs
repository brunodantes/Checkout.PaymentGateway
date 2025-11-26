using Checkout.PaymentGateway.Application.Services;
using Checkout.PaymentGateway.Application.Validators;
using Checkout.PaymentGateway.Data.Respositories;
using Checkout.PaymentGateway.Domain.Repositories;
using Checkout.PaymentGateway.Domain.Services;
using Checkout.PaymentGateway.Infrastructure.BankSimulator.Domain;
using Checkout.PaymentGateway.Infrastructure.BankSimulator.Rest;
using Checkout.PaymentGateway.Infrastructure.BankSimulator.Services;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Refit;

namespace Checkout.PaymentGateway.API.ServiceExtensions;

public static class DependencyInjection
{
    internal static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<IPaymentGatewayService, PaymentGatewayService>();
        services.AddValidatorsFromAssemblyContaining<PaymentRequestValidator>();
    }

    internal static void AddRepositories(this IServiceCollection services)
    {
        services.AddSingleton<IPaymentRepository, PaymentRepository>();

    }

    internal static void AddInfraestructure(this IServiceCollection services)
    {
        services.AddSingleton<IBankSimulatorService, BankSimulatorService>();
        services.AddRefitClient<IBankSimulatorApi>().ConfigureHttpClient(c => c.BaseAddress = new Uri("http://localhost:8080"));
    }
}
