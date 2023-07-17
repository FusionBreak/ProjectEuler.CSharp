namespace ProjectEuler.CSharp;

public class Problem2
{
    public static int Calc() =>
        Fibonacci.TakeWhile(number => number <= 4000000).Where(number => number % 2 == 0).Sum();

    public static IEnumerable<int> Fibonacci
    {
        get
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
    }
}
