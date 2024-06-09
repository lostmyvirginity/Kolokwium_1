using Kolokwium_1.Model;
using Kolokwium_1.Repository;

namespace Kolokwium_1.Service;

public class DiscountService : IDiscountService
{
    private IRepository _repository;

    public DiscountService(IRepository repository)
    {
        _repository = repository;
    }
    public Task<CustomerDTORequest> getClient(int id)
    {
        return _repository.req();
    }
}