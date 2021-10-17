using Microsoft.Extensions.DependencyInjection;
using Wildcards.Service.Contract;
using Wildcards.Service.Implementation;

namespace Wildcards.ConsoleApp
{
    public class ServiceRegistration
    {
        public static ServiceProvider GetServiceProvider()
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IRegexPatternService, RegexPatternService>()
                .AddTransient<IWildcardsService, WildcardsService>()
                .BuildServiceProvider();

            return serviceProvider;
        }
    }
}
