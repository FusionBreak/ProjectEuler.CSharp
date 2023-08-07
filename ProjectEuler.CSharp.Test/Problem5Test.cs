namespace ProjectEuler.CSharp.Test;

public class Problem5Test
{
    [Fact]
    public void TestCalc()
    {
        Assert.Equal(2520, Problem5.Calc(10));
        Assert.Equal(232792560, Problem5.Calc(20));
    }
}
