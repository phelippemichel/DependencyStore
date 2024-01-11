namespace DependencyStore.Services.Contracts;

public interface IDeliveryFeeService
{
    Task<decimal> GeTDeliveryFeeAsync(string zipCode);
}