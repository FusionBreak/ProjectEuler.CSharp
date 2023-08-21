namespace ProjectEuler.CSharp;

public class Problem1
{
    [Fact]
    public void TestCalc()
    {
        Assert.Equal(23, Solve(10));
        Assert.Equal(233168, Solve(1000));
    }

    private static int Solve(int max) =>
        Enumerable.Range(0, max).Where(number => number % 3 == 0 || number % 5 == 0).Sum(x => x);
}