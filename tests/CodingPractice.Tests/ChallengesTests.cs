using Challenges;

namespace CodingPractice.Tests;

public class ChallengesTests
{
    [Theory]
    [InlineData(2, true)]
    [InlineData(3, true)]
    [InlineData(67, true)]
    [InlineData(1, false)]
    [InlineData(0, false)]
    [InlineData(-6, false)]
    [InlineData(95, false)]
    public void PrimeNumber_IdentifiesPrimeAndCompositeNumbers(int number, bool expected)
    {
        Assert.Equal(expected, Program.PrimeNumber(number));
    }

    [Theory]
    [InlineData("arara", true)]
    [InlineData("A base do teto desaba", true)]
    [InlineData("algoritmo", false)]
    public void Palindrome_IgnoresSpacesAndCasing(string text, bool expected)
    {
        Assert.Equal(expected, Program.Palindrome(text));
    }

    [Fact]
    public void Sort_OrdersCharacters()
    {
        Assert.Equal(['a', 'b', 'c', 'd'], Program.Sort(['d', 'a', 'c', 'b']));
    }

    [Theory]
    [InlineData("aaabccddd", "abd")]
    [InlineData("aa", "Empty String")]
    [InlineData("baab", "Empty String")]
    public void SuperReduce_RemovesAdjacentPairs(string input, string expected)
    {
        Assert.Equal(expected, input.SuperReduce());
    }

    [Fact]
    public void ToLexicograficOrder_ProducesSmallestConcatenation()
    {
        string[] values = ["3", "30", "34", "5", "9"];

        Assert.Equal("3033459", values.ToLexicograficOrder());
    }
}
