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

    [Test]
    public void ShouldCalculateQuadratic()
    {
        decimal[] numbersA = [2, 4, 2.5m];
        decimal[] numbersB = [4, 3, 1m];
        decimal[] numbersC = [2, 5, 8];

        decimal[] x = [3, 4, 5];
        
        var calc = new CalcLib();

        decimal[] results = new decimal[3];
        bool[] correctResults = new bool[3];
        
        for (int i = 0; i < 3; i++)
        {
            results[i] = calc.QuadraticFunction(x[i], numbersA[i], numbersB[i], numbersC[i]);
            correctResults[i] = (numbersA[i] * (x[i] * x[i]) + numbersB[i] * x[i] + numbersC[i]) == results[i];
        }
        
        for (int i = 0; i < correctResults.Length; i++)
            Assert.That(correctResults[i], Is.True);
    }
}