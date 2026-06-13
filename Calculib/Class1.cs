namespace Calculib;

public class CalcLib
{
    public decimal Sum(params IEnumerable<decimal> numbers)
    {
        List<decimal> numbersList = numbers.ToList();
        
        decimal sum = numbersList.Sum();

        return sum;
    }
}