using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.CSharp;

public class Problem12
{
    [Fact]
    public void TestSolve()
    {
        Assert.Equal(28, Solve(5));
        Assert.Equal(76576500, Solve(500));
    }

    private static long Solve(int numberOfDivisors) =>
        Enumerable
            .Range(1, int.MaxValue)
            .Select(TriangleNumber)
            .Select(
                tNumber => (TriangleNumber: tNumber, NumberOfDivisors: NumberOfDivisors(tNumber))
            )
            .First(x => x.NumberOfDivisors >= numberOfDivisors)
            .TriangleNumber;

    static int TriangleNumber(int n) => n * (n + 1) / 2;

    static int NumberOfDivisors(int n)
    {
        List<int> factors = GetFactors(n).ToList();

        // Quelle: https://sl.bing.net/dgpy2JXwoMu
        int divisors = 1;
        int count = 1;
        for (int i = 1; i < factors.Count; i++)
        {
            if (factors[i] == factors[i - 1])
            {
                count++;
            }
            else
            {
                divisors *= (count + 1);
                count = 1;
            }
        }
        divisors *= (count + 1);

        return divisors;
    }

    static IEnumerable<int> GetFactors(int n)
    {
        int factor = 2;
        while (n > 1)
        {
            if (n % factor == 0)
            {
                yield return factor;
                n /= factor;
            }
            else
            {
                factor++;
            }
        }
    }
}
