namespace ProjectEuler.CSharp;

public class Problem5
{
    public static int Calc(int max) =>
        Enumerable.Range(1, int.MaxValue).First(x => IsEvenlyDivisibleByAllOfTheNumbers(x, max));

    static bool IsEvenlyDivisibleByAllOfTheNumbers(int value, int max) =>
        !Enumerable.Range(1, max).Select(i => value % i == 0).Contains(false);
}
