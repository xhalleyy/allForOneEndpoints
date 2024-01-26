using allForOneEndpoints.Services.GreaterOrLess;
using Microsoft.AspNetCore.Mvc;

namespace allForOneEndpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class GreaterOrLessController : ControllerBase
{
    private readonly IGreaterOrLessService _greaterOrLessService;

    public GreaterOrLessController(IGreaterOrLessService greaterOrLessService)
   {
        _greaterOrLessService = greaterOrLessService;
    }

   [HttpGet]
   [Route("CompareNumbers/{firstNum}/{secondNum}")]
   public string CompareNumbers(string firstNum, string secondNum)
   {
        return _greaterOrLessService.CompareNumbers(firstNum, secondNum);
   }
}
