namespace allForOneEndpoints.Services.Magic8Ball;

public class Magic8BallService : IMagic8BallService
{
    public string TheAnswer()
    {
        string[] answers = new string[]{"100% YES", "Do you even need to ask!?", "Try Again", "Future Looks Grim!", "Sorry, What? I wasn't listening", "I say go for it but idk tho lol", "Yeah, No. Forsure!", "Highly Unlikely!"};
        int randomIndex = new Random().Next(0, answers.Length);
        return answers[randomIndex];
    }
}
