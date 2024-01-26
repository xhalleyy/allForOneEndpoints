using allForOneEndpoints.Services.AddNumbers;
using Microsoft.AspNetCore.Mvc;

namespace allForOneEndpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class AddNumbersController : ControllerBase
{
    private readonly IAddNumbersService _addNumbersService;

    public AddNumbersController(IAddNumbersService addNumbersService)
    {
        _addNumbersService = addNumbersService;
    }

    [HttpGet]
    [Route("Summation/{firstNum}/{secondNum}")]
    public string Summation(string firstNum, string secondNum)
    {
        return _addNumbersService.Summation(firstNum, secondNum);
    }
}
