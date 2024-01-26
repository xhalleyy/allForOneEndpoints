using allForOneEndpoints.Services.ReverseIt1;
using Microsoft.AspNetCore.Mvc;

namespace allForOneEndpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class ReverseIt1Controller : ControllerBase
{
    private readonly IReverseIt1Service _reverseIt1Service;

    public ReverseIt1Controller(IReverseIt1Service reverseIt1Service)
   {
        _reverseIt1Service = reverseIt1Service;
    }

   [HttpGet]
   [Route("Alphanumeric/{sequence}")]
   public string Alphanumeric(string sequence)
   {
    return _reverseIt1Service.Alphanumeric(sequence);
   }
}
