namespace allForOneEndpoints.Services.RestaurantPicker;

public class RestaurantPickerService : IRestaurantPickerService
{
    public string FoodCategory(string input)
    {
        string[] mexican = new string[] { "Tu Pueblito Taqueria", "Tequileros Taqueria", "Tacos Chapala", "El Forastero Mexican Food", "Tacos La Palmita", "El Pazcifico Mexican Grill and Cantina", "Tonantzin", "El Puerto Tacos", "Fuego Taqueria", "Tepa Taqueria" };
        string[] asian = new string[] { "Pho Island", "M Sushi Bistro", "Spice it Up!", "Seoul Soon Dubu - Korean BBQ", "Gogi Korean BBQ & Hot Pot", "Yen Du Restaurant", "Tsing Tao", "Lotus Thai & Khmer Cuisines", "Pho Saigon Bay", "Mac Pho" };
        string[] american = new string[] { "Market Tavern", "The Kitchen at StoneBrier", "FED", "Cast Iron Trading", "Midgley's Public House", "BJ's Reastaurant & Brewhouse", "Popeyes Louisiana Kitchen", "IHOP", "Brick House Restaurant & Lounge", "In-n-Out Burger" };
        int randomIndex = new Random().Next(0, 10);

        string category = input.ToLower();

        if (category == "mexican")
        {
            return $"The restaurant you should eat at is {mexican[randomIndex]}";
        }
        else if (category == "asian")
        {
            return $"The restaurant you should eat at is {asian[randomIndex]}";
        }
        else if (category == "american")
        {
            return $"The restaurant you should eat at is {american[randomIndex]}";
        }
        else
        {
            return $"{input} is not a valid input. Choose between Mexican, Asian, or American Food.";
        }
    }
}
