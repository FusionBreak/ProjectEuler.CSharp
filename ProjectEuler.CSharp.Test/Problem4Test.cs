namespace ProjectEuler.CSharp.Test;

public class Problem4Test
{
    [Fact]
    public void TestCalc()
    {
        Assert.Equal(9009, Problem4.Calc(2));
        Assert.Equal(906609, Problem4.Calc(3));
    }
}
