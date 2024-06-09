using Kolokwium_1.Model;

namespace Kolokwium_1.Service;

public interface IDiscountService
{
    public Task<CustomerDTORequest> getClient(int id);
}