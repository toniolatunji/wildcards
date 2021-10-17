using Wildcards.Service.Contract;

namespace Wildcards.Service.Implementation
{
    public class RegexPatternService : IRegexPatternService
    {
        public string GetRegexPattern(string symbols)
        {
            var regexPattern = "^";

            for (int i = 0; i < symbols.Length; i++)
            {
                var symbol = symbols[i];

                switch (symbol)
                {
                    case '+':
                        regexPattern += "[a-z]";
                        break;

                    case '$':
                        regexPattern += "[0-9]";
                        break;

                    case '*':

                        var characterRepetition = "";

                        if (i + 1 >= symbols.Length)
                        {
                            characterRepetition = "3";
                        }
                        else
                        {
                            if (symbols[i + 1] != '{')
                            {
                                characterRepetition = "3";
                            }
                            else
                            {
                                for (int j = i + 1; j < symbols.Length; j++)
                                {
                                    if (symbols[j] == '}')
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        if (char.IsDigit(symbols[j]))
                                        {
                                            characterRepetition += symbols[j];
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                    }
                                }
                            }
                        }

                        regexPattern += $"(.){{{characterRepetition}}}";

                        break;

                    default:
                        break;
                }
            }

            regexPattern += "$";

            return regexPattern;
        }
    }
}
