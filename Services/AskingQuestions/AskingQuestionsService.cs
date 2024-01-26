namespace allForOneEndpoints.Services.AskingQuestions;

public class AskingQuestionsService : IAskingQuestionsService
{
    public string NameAndTime(string userName, string wakeUpTime)
    {
        return $"Nice to meet you {userName}! Wow, you woke up at {wakeUpTime}!";
    }
}
