namespace Calculib;

public class CalcLib
{
    public decimal Sum(IEnumerable<decimal> numbers)
    {
        List<decimal> numbersList = numbers.ToList();
        
        decimal sum = numbersList.Sum();

        return sum;
    }

    public decimal QuadraticFunction(decimal x, decimal a, decimal b, decimal c)
        => (a * (x * x)) + (b * x) + c;

    public decimal Lowest(IEnumerable<decimal> numbers)
    {
        decimal lowest = 0;
        bool first = true;
        foreach (var num in numbers)
        {
            if (first)
            {
                lowest = num;
                first = false;
                continue;
            }
            if (lowest > num)
                lowest = num;
        }
        
        return lowest;
    }
}