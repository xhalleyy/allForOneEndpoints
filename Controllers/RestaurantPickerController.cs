using allForOneEndpoints.Services.RestaurantPicker;
using Microsoft.AspNetCore.Mvc;

namespace allForOneEndpoints.Controllers;

[Route("[controller]")]
public class RestaurantPickerController : ControllerBase
{
    private readonly IRestaurantPickerService _restaurantPickerService;

    public RestaurantPickerController(IRestaurantPickerService restaurantPickerService)
    {
        _restaurantPickerService = restaurantPickerService;
    }

    [HttpGet]
    [Route("FoodCategory/{input}")]
    public string FoodCategory(string input)
    {
        return _restaurantPickerService.FoodCategory(input);
    }
}
