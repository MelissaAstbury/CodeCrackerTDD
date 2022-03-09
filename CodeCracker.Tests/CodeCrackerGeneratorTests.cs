using Shouldly;
using Xunit;

namespace CodeCracker.Tests
{
    public class CodeCrackerGeneratorTests
    {
        [Fact]
        public void ShouldCreateNewCodeCrackerGenerator()
        {
            CodeCrackerGenerator generator = new();
            generator.ShouldNotBeNull();
            generator.ShouldBeOfType<CodeCrackerGenerator>();
        }

        [Theory]
        [InlineData("!", "a")]
        [InlineData(")", "b")]
        [InlineData("''", "c")]
        [InlineData("(", "d")]
        [InlineData("£", "e")]
        [InlineData("*", "f")]
        [InlineData("%", "g")]
        [InlineData("&", "h")]
        [InlineData(">", "i")]
        [InlineData("<", "j")]
        [InlineData("@", "k")]
        [InlineData("a", "l")]
        [InlineData("b", "m")]
        [InlineData("c", "n")]
        [InlineData("d", "o")]
        [InlineData("e", "p")]
        [InlineData("f", "q")]
        [InlineData("g", "r")]
        [InlineData("h", "s")]
        [InlineData("i", "t")]
        [InlineData("j", "u")]
        [InlineData("k", "v")]
        [InlineData("l", "w")]
        [InlineData("m", "x")]
        [InlineData("n", "y")]
        [InlineData("o", "z")]
        public void Test2(string character, string expectedResult)
        {
            CodeCrackerGenerator generator = new();
            var result = generator.DecryptMessage(character);
            result.ShouldBe(expectedResult);
        }
    }
}