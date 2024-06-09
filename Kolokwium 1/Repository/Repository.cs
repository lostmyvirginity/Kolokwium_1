using Kolokwium_1.MasterContext;
using Kolokwium_1.Model;

namespace Kolokwium_1.Repository;

public class Repository : IRepository
{
    private readonly Context _context;

    public Repository(Context context)
    {
        _context = context;
    }
    public async Task<CustomerDTORequest> req()
    {
        var result = _context.Clients.Select(c =>
            new CustomerDTORequest()
            {
                firstName = c.FirstName,
                lastName = c.LastName,
                email = c.Email,
                phone = c.Phone,
            }).ToList();
        return result.FirstOrDefault();
    }
}