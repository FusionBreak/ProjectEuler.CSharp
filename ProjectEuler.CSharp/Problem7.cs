namespace ProjectEuler.CSharp;

public class Problem7
{
    public static long Solve(int index) =>
        Range(0, int.MaxValue).Where(IsPrime).Skip(index - 1).First();

    public static bool IsPrime(long number)
    {
        if (number <= 1)
            return false;
        if (number == 2)
            return true;
        if (number % 2 == 0)
            return false;

        var boundary = (int)Math.Floor(Math.Sqrt(number));

        for (int i = 3; i <= boundary; i += 2)
            if (number % i == 0)
                return false;

        return true;
    }

    static IEnumerable<long> Range(int start, long count)
    {
        var end = start + count;
        for (var current = start; current < end; ++current)
            yield return current;
    }
}
