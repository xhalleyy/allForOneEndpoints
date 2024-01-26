namespace allForOneEndpoints.Services.GreaterOrLess;

public class GreaterOrLessService : IGreaterOrLessService
{
    public string CompareNumbers(string firstNum, string secondNum)
    {
        bool isRealNum1 = double.TryParse(firstNum, out double realNum1);
        bool isRealNum2 = double.TryParse(secondNum, out double realNum2);
        if (isRealNum1 && isRealNum2)
        {
            if (realNum1 > realNum2)
            {
                return $"{realNum1} is greater than {realNum2}. And {realNum2} is less than {realNum1}.";
            }
            else if (realNum1 < realNum2)
            {
                return $"{realNum1} is less than {realNum2}. And {realNum2} is greater than {realNum1}.";
            }
            else
            {
                return $"{realNum1} and {realNum2} are equal to each other.";
            }

        }else{
            return $"Either your first input, {firstNum} , or your second input, {secondNum} , wasn't a valid number. Or Both! Please try again. ";
        }
    }
}
