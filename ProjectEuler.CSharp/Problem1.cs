using System.Globalization;

namespace ProjectEuler.CSharp;

public class Problem1
{
    public static int Calc(int max) =>
        Enumerable.Range(0, max).Where(number => number % 3 == 0 || number % 5 == 0).Sum(x => x);
}
