namespace ProjectEuler.CSharp.Test;

public class Problem3Test
{
    [Fact]
    public void TestCalc()
    {
        Assert.Equal(6857, Problem3.Calc(600851475143));
    }
}
