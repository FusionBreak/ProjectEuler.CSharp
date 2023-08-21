namespace ProjectEuler.CSharp;

public class Problem2
{
    private static IEnumerable<int> Fibonacci()
    {
        var a = 1;
        var b = 2;

        yield return a;
        yield return b;

        while (a <= int.MaxValue)
        {
            var c = a + b;
            a = b;
            b = c;

            yield return c;
        }
    }

    [Fact]
    public void TestCalc() => Assert.Equal(4613732, Calc());

    private static int Calc() =>
        Fibonacci().TakeWhile(number => number <= 4000000).Where(number => number % 2 == 0).Sum();
}