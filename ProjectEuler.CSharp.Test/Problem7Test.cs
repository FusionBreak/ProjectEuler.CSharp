namespace ProjectEuler.CSharp.Test;

public class Problem7Test
{
    [Fact]
    public void TestSolve()
    {
        Assert.Equal(13, Problem7.Solve(6));
        Assert.Equal(104743, Problem7.Solve(10_001));
    }
}
