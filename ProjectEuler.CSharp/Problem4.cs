namespace ProjectEuler.CSharp;

public class Problem4
{
    [Fact]
    public void TestCalc()
    {
        Assert.Equal(9009, Solve(2));
        Assert.Equal(906609, Solve(3));
    }

    private static int Solve(int digits) => AllPalindromes(digits).Max();

    private static IEnumerable<int> AllPalindromes(int digits)
    {
        var max = int.Parse(string.Concat(Enumerable.Repeat("9", digits)));
        var range = Enumerable.Range(0, max + 1);
        return range.SelectMany(x => range, (a, b) => a * b).Where(IsPalindrome);
    }

    private static bool IsPalindrome(int number)
    {
        var numberAsText = number.ToString();
        var halveIndex = numberAsText.Length / 2;
        var left = numberAsText[..halveIndex];
        var rightReversed = string.Concat(numberAsText[halveIndex..].Reverse());
        return left == rightReversed;
    }
}