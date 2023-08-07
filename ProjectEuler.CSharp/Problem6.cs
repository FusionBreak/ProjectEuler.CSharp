namespace ProjectEuler.CSharp;

public class Problem6
{
    public static int Solve(int max) => SquareOfSum(max) - SumOfSquares(max);

    static int SumOfSquares(int max) =>
        Enumerable.Range(0, max + 1).Select(i => (int)Math.Pow(i, 2)).Sum();

    static int SquareOfSum(int max) => (int)Math.Pow(Enumerable.Range(0, max + 1).Sum(), 2);
}
