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
        public void Test2(string character, string expectedResult)
        {
            CodeCrackerGenerator generator = new();
            var result = generator.DecryptMessage(character);
            result.ShouldBe(expectedResult);
        }
    }
}