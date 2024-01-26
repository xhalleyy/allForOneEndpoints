using allForOneEndpoints.Services.MadLib;
using Microsoft.AspNetCore.Mvc;


namespace allForOneEndpoints.Controllers;

[Route("[controller]")]
public class MadLibController : ControllerBase
{
    private readonly IMadLibService _madLibService;

    public MadLibController(IMadLibService madLibService)
   {
        _madLibService = madLibService;
    }

   [HttpGet]
   [Route("Story/{creature}/{name1}/{name2}/{place}/{item}/{noun}/{adjective}/{adverb}/{ingVerb1}/{ingVerb2}/{pastVerb1}")]
   public string Story(string creature, string name1, string name2, string place, string item, string noun, string adjective, string adverb, string ingVerb1, string ingVerb2, string pastVerb1)
   {
    return _madLibService.Story(creature, name1, name2, place, item, noun, adjective, adverb, ingVerb1, ingVerb2, pastVerb1);
   }
}
