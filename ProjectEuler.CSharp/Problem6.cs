namespace ProjectEuler.CSharp;

public class Problem6
{
    [Fact]
    public void TestSolve()
    {
        Assert.Equal(2640, Solve(10));
        Assert.Equal(25164150, Solve(100));
    }

    private static int Solve(int max) => SquareOfSum(max) - SumOfSquares(max);

    private static int SumOfSquares(int max) =>
        Enumerable.Range(0, max + 1).Select(i => (int)Math.Pow(i, 2)).Sum();

    private static int SquareOfSum(int max) => (int)Math.Pow(Enumerable.Range(0, max + 1).Sum(), 2);
}