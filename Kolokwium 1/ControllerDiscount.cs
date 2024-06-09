using Kolokwium_1.Model;
using Kolokwium_1.Service;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium_1;
[ApiController]
[Route("api/")]
public class ControllerDiscount : ControllerBase
{
    private IDiscountService _discountService;
    public ControllerDiscount(IDiscountService discountService)
    {
        _discountService = discountService;
    }
    [HttpGet("client")]
    public async Task<ActionResult<CustomerDTORequest>> getClient(int i)
    {
        Task<CustomerDTORequest> x = _discountService.getClient(i);
        return Ok(x);
    } 
}