using System.Text.RegularExpressions;
using Wildcards.Service.Contract;

namespace Wildcards.Service.Implementation
{
    public class WildcardsService : IWildcardsService
    {
        private readonly IRegexPatternService regexPatternService;

        public WildcardsService(IRegexPatternService regexPatternService)
        {
            this.regexPatternService = regexPatternService;
        }

        public bool Wildcards(string input)
        {
            if (input.Contains(' '))
            {
                var inputComponents = input.Split(' ');

                if (inputComponents.Length == 2)
                {
                    var symbols = inputComponents[0];

                    var textToMatch = inputComponents[1];

                    var regexPattern = regexPatternService.GetRegexPattern(symbols);

                    return new Regex(regexPattern).IsMatch(textToMatch);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
