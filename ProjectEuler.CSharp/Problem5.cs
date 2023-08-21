namespace ProjectEuler.CSharp;

public class Problem5
{
    [Fact]
    public void TestCalc()
    {
        Assert.Equal(2520, Solve(10));
        Assert.Equal(232792560, Solve(20));
    }

    private static int Solve(int max) =>
        Enumerable.Range(1, int.MaxValue).First(x => IsEvenlyDivisibleByAllOfTheNumbers(x, max));

    private static bool IsEvenlyDivisibleByAllOfTheNumbers(int value, int max) =>
        !Enumerable.Range(1, max).Select(i => value % i == 0).Contains(false);
}