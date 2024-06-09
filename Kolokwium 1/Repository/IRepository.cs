using Kolokwium_1.Model;

namespace Kolokwium_1.Repository;

public interface IRepository
{
    public Task<CustomerDTORequest> req();
}