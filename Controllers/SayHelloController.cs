using allForOneEndpoints.Services.SayHello;
using Microsoft.AspNetCore.Mvc;

namespace allForOneEndpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class SayHelloController : ControllerBase
{
    private readonly ISayHelloService _sayHelloService;

    public SayHelloController(ISayHelloService sayHelloService)
    {
        _sayHelloService = sayHelloService;
    }

    [HttpGet]
    [Route("AddName/{name}")]
    public string AddName(string name){
        return _sayHelloService.AddName(name);
    }
}
