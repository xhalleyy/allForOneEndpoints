namespace allForOneEndpoints.Services.OddOrEven;

public class OddOrEvenService : IOddOrEvenService
{
    public string DivisibleBy2(string num)
    {
        bool isNum = int.TryParse(num, out int realNum);

        if (isNum)
        {
            if (realNum % 2 == 0)
            {
                return $"The number {realNum} is even.";
            }
            else
            {
                return $"The number {realNum} is odd.";
            }

        }
        else
        {
            return $"{num} was not a number. Please input a valid number/input.";
        }
    }
}
