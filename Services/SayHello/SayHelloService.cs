namespace allForOneEndpoints.Services.SayHello;

public class SayHelloService : ISayHelloService
{
    public string AddName(string name)
    {
        return $"Hello! It is very lovely to meet you {name}! Have a great day!";
    }
}
