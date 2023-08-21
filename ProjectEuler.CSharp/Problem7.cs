namespace ProjectEuler.CSharp;

public class Problem7
{
    [Fact]
    public void TestSolve()
    {
        Assert.Equal(13, Solve(6));
        Assert.Equal(104743, Solve(10_001));
    }

    private static long Solve(int index) =>
        Range(0, int.MaxValue).Where(IsPrime).Skip(index - 1).First();

    private static bool IsPrime(long number)
    {
        if (number <= 1)
            return false;
        if (number == 2)
            return true;
        if (number % 2 == 0)
            return false;

        var boundary = (int)Math.Floor(Math.Sqrt(number));

        for (var i = 3; i <= boundary; i += 2)
            if (number % i == 0)
                return false;

        return true;
    }

    private static IEnumerable<long> Range(int start, long count)
    {
        var end = start + count;
        for (var current = start; current < end; ++current)
            yield return current;
    }
}