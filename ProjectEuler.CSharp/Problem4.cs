namespace ProjectEuler.CSharp;

public class Problem4
{
    public static int Calc(int digits) => AllPalindromes(digits).Max();

    public static IEnumerable<int> AllPalindromes(int digits)
    {
        var max = int.Parse(string.Concat(Enumerable.Repeat("9", digits)));
        var range = Enumerable.Range(0, max + 1);
        return range.SelectMany(x => range, (a, b) => a * b).Where(IsPalindrome);
    }

    static bool IsPalindrome(int number)
    {
        var numberAsText = number.ToString();
        var halveIndex = numberAsText.Length / 2;
        var left = numberAsText[..halveIndex];
        var rightReversed = string.Concat(numberAsText[halveIndex..].Reverse());
        return left == rightReversed;
    }
}
