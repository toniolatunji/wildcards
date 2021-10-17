using Moq;
using NUnit.Framework;
using Wildcards.Service.Contract;
using Wildcards.Service.Implementation;

namespace Wildcards.Tests
{
    public class WildcardsServiceTest
    {
        [Test]
        public void Wildcards_Returns_False_IfInputDoesNotContainSpaceCharacter()
        {
            var input = "+++++*abcdehhhhhh";

            Mock<IRegexPatternService> mockRegexPatternService = new();

            IWildcardsService wildcardsService = new WildcardsService(mockRegexPatternService.Object);

            var isMatch = wildcardsService.Wildcards(input);

            Assert.That(isMatch, Is.False);
        }

        [Test]
        public void Wildcards_Returns_False_IfInputContainsMoreThanOneSpaceCharacters()
        {
            var input = "+++++* abcdehhhhhh abcdehhhhhh";

            Mock<IRegexPatternService> mockRegexPatternService = new();

            IWildcardsService wildcardsService = new WildcardsService(mockRegexPatternService.Object);

            var isMatch = wildcardsService.Wildcards(input);

            Assert.That(isMatch, Is.False);
        }

        [Test]
        public void Wildcards_Returns_False_IfStringInInputDoesNotMatchPattern()
        {
            var input = "+++++* abcdehhhhhh";

            Mock<IRegexPatternService> mockRegexPatternService = new();

            mockRegexPatternService.Setup(x => x.GetRegexPattern("+++++*")).Returns("^[a-z][a-z][a-z][a-z][a-z](.){3}$");

            IWildcardsService wildcardsService = new WildcardsService(mockRegexPatternService.Object);

            var isMatch = wildcardsService.Wildcards(input);

            Assert.That(isMatch, Is.False);
        }

        [Test]
        public void Wildcards_Returns_True_IfStringInInputMatchesPattern()
        {
            var input = "$**+*{2} 9mmmrrrkbbh";

            Mock<IRegexPatternService> mockRegexPatternService = new();

            mockRegexPatternService.Setup(x => x.GetRegexPattern("$**+*{2}")).Returns("^[0-9](.){3}(.){3}[a-z](.){2}$");

            IWildcardsService wildcardsService = new WildcardsService(mockRegexPatternService.Object);

            var isMatch = wildcardsService.Wildcards(input);

            Assert.That(isMatch, Is.False);
        }
    }
}
