namespace ProjectEuler.CSharp.Test;

public class Problem6Test
{
    [Fact]
    public void TestSolve()
    {
        Assert.Equal(2640, Problem6.Solve(10));
        Assert.Equal(25164150, Problem6.Solve(100));
    }
}
