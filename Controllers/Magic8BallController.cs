using allForOneEndpoints.Services.Magic8Ball;
using Microsoft.AspNetCore.Mvc;

namespace allForOneEndpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class Magic8BallController : ControllerBase
{
    private readonly IMagic8BallService _magic8BallService;

    public Magic8BallController(IMagic8BallService magic8BallService)
    {
        _magic8BallService = magic8BallService;
    }

    [HttpGet]
    [Route("TheAnswer")]
    public string TheAnswer()
    {
        return _magic8BallService.TheAnswer();
    }
}
