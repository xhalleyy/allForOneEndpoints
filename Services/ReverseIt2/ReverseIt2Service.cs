namespace allForOneEndpoints.Services.ReverseIt2;

public class ReverseIt2Service : IReverseIt2Service
{
    public string Numeric(string sequence)
    {
        string reversedStr = "";
        bool isNumSeq = int.TryParse(sequence, out int number);
        if (isNumSeq){
            
            for( int i = number.ToString().Length - 1; i >= 0; i--)
            {
                reversedStr += number.ToString()[i];
            }

            return $"The reverse sequence of {number} is: {reversedStr}";

        }else{
            return $"Your sequence, {sequence},doesn't have all numerical values. Try again!";
        }
    }
}
