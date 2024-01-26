namespace allForOneEndpoints.Services.ReverseIt1;

public class ReverseIt1Service : IReverseIt1Service
{
    public string Alphanumeric(string sequence)
    {
        string reversedStr = "";
        for(int i = sequence.Length - 1; i >= 0; i--)
        {
            reversedStr += sequence[i];
        }

        return $"The reverse sequence of {sequence} is : {reversedStr}";
    }
}
