using allForOneEndpoints.Services.ReverseIt2;
using Microsoft.AspNetCore.Mvc;

namespace allForOneEndpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class ReverseIt2Controller : ControllerBase
{
    private readonly IReverseIt2Service _reverseIt2Service;

    public ReverseIt2Controller(IReverseIt2Service reverseIt2Service)
    {
        _reverseIt2Service = reverseIt2Service;
    }

    [HttpGet]
    [Route("Numeric/{sequence}")]
    public string Numeric(string sequence)
    {
        return _reverseIt2Service.Numeric(sequence);
    }
}
