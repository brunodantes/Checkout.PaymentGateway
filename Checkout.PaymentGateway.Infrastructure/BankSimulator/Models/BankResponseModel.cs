using System.Text.Json.Serialization;

namespace Checkout.PaymentGateway.Infrastructure.BankSimulator.Models;

public class BankResponseModel
{
    [JsonPropertyName("authorized")]
    public bool Authorized { get; set; }
    [JsonPropertyName("authorization_code")]
    public string AuthorizationCode { get; set; } = string.Empty;
}
