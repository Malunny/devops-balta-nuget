using Calculib;

namespace Calculib.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ShouldCalculateSum()
    {
        decimal[] a = [1, 2, 3, 4, 5, 6];
        decimal[] b = [2, 5, 8];

        var calc = new CalcLib();

        var responseA = calc.Sum(a);
        var responseB = calc.Sum(b);
        var responseAB = calc.Sum(a.Concat(b));
        
        bool aResult = responseA == 21;
        bool bResult = responseB == 15;
        bool abResult = responseAB == 36;
        
        bool passed =  aResult && bResult && abResult;
        
        Assert.That(passed, Is.True);
    }
}