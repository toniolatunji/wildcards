using NUnit.Framework;
using Wildcards.Service.Contract;
using Wildcards.Service.Implementation;

namespace Wildcards.Tests
{
    public class RegexPatternServiceTest
    {
        [TestCase("+", ExpectedResult = "^[a-z]$")]
        [TestCase("++", ExpectedResult = "^[a-z][a-z]$")]
        [TestCase("$", ExpectedResult = "^[0-9]$")]
        [TestCase("$++", ExpectedResult = "^[0-9][a-z][a-z]$")]
        [TestCase("*", ExpectedResult = "^(.){3}$")]
        [TestCase("$++**", ExpectedResult = "^[0-9][a-z][a-z](.){3}(.){3}$")]
        [TestCase("*{1}", ExpectedResult = "^(.){1}$")]
        [TestCase("++*{5}", ExpectedResult = "^[a-z][a-z](.){5}$")]
        [TestCase("+++++*", ExpectedResult = "^[a-z][a-z][a-z][a-z][a-z](.){3}$")]
        [TestCase("$**+*{2}", ExpectedResult = "^[0-9](.){3}(.){3}[a-z](.){2}$")]
        public string GetRegexPattern_Returns_CorrectRegexPattern(string symbols)
        {
            IRegexPatternService regexPatternService = new RegexPatternService();

            return regexPatternService.GetRegexPattern(symbols);
        }
    }
}
