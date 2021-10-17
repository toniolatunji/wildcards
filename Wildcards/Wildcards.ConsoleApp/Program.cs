using Microsoft.Extensions.DependencyInjection;
using System;
using Wildcards.Service.Contract;

namespace Wildcards.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = ServiceRegistration.GetServiceProvider();

            var wildcardsService = serviceProvider.GetService<IWildcardsService>();


            var input1 = "+++++* abcdehhhhhh";

            var output1 = wildcardsService.Wildcards(input1);

            Console.WriteLine($"Example 1:\nInput: {input1}\nOutput: {output1}\n\n");


            var input2 = "$**+*{2} 9mmmrrrkbb";

            var output2 = wildcardsService.Wildcards(input2);

            Console.WriteLine($"Example 2:\nInput: {input2}\nOutput: {output2}\n\n");


            var input3 = "++*{5} jtggggg";

            var output3 = wildcardsService.Wildcards(input3);

            Console.WriteLine($"Example 2:\nInput: {input3}\nOutput: {output3}\n\n");


            Console.ReadLine();
        }
    }
}
