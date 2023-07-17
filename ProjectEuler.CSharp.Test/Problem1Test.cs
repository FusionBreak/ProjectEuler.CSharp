namespace ProjectEuler.CSharp.Test;

public class Problem1Test
{
    [Fact]
    public void TestCalc()
    {
        Assert.Equal(23, Problem1.Calc(10));
        Assert.Equal(233168, Problem1.Calc(1000));
    }
}
