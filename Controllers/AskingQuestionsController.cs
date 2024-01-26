using allForOneEndpoints.Services.AskingQuestions;
using Microsoft.AspNetCore.Mvc;

namespace allForOneEndpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class AskingQuestionsController : ControllerBase
{
    private readonly IAskingQuestionsService _askingQuestionsService;

    public AskingQuestionsController(IAskingQuestionsService askingQuestionsService)
    {
        _askingQuestionsService = askingQuestionsService;
    }

    [HttpGet]
    [Route("NameAndTime/{name}/{wakeUpTime}")]
    public string NameAndTime(string name, string wakeUpTime)
    {
        return _askingQuestionsService.NameAndTime(name, wakeUpTime);
    }
}
