namespace Calculib;

public class CalcLib
{
    public decimal Sum(params IEnumerable<decimal> numbers)
    {
        List<decimal> numbersList = numbers.ToList();
        
        decimal sum = numbersList.Sum();

        return sum;
    }

    public decimal QuadraticFunction(decimal x, decimal a, decimal b, decimal c)
        => (a * (x * x)) + (b * x) + c;
}