namespace ProjectEuler.CSharp;

public class Problem3
{
    public static long Calc(long number) => BiggestPrimeFactor(number);

    static long BiggestPrimeFactor(long number)
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

    static IEnumerable<long> GetAllPrimesOf(long number)
    {
        for (long prime = 2; prime <= number; prime++)
            if (number % prime == 0)
                yield return prime;
    }
}
