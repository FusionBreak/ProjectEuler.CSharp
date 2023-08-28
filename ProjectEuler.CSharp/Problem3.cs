namespace ProjectEuler.CSharp;

public class Problem3
{
    [Fact]
    public void TestSolve() => Assert.Equal(6857, Solve(600851475143));

    private static long Solve(long number) => BiggestPrimeFactor(number);

    private static long BiggestPrimeFactor(long number)
    {
        var n = 1L;

        foreach (var prime in GetAllPrimesOf(number))
        {
            n *= prime;

            if (n == number)
                return prime;
        }

        throw new Exception();
    }

    private static IEnumerable<long> GetAllPrimesOf(long number)
    {
        for (long prime = 2; prime <= number; prime++)
            if (number % prime == 0)
                yield return prime;
    }
}