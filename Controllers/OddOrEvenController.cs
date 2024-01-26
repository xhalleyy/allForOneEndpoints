using allForOneEndpoints.Services.OddOrEven;
using Microsoft.AspNetCore.Mvc;

namespace allForOneEndpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class OddOrEvenController : ControllerBase
{
    private readonly IOddOrEvenService _oddOrEvenService;

    public OddOrEvenController(IOddOrEvenService oddOrEvenService)
    {
        _oddOrEvenService = oddOrEvenService;
    }

    [HttpGet]
    [Route("DivisibleBy2/{num}")]
    public string DivisibleBy2(string num)
    {
        return _oddOrEvenService.DivisibleBy2(num);
    }
}
