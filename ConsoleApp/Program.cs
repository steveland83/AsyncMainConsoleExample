using System;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var someClass = new SomeClass();
            await someClass.OutputSomethingAsync();

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }


        public class SomeClass
        {
            public async Task OutputSomethingAsync()
            {
                await Task.Delay(500);
                Console.WriteLine("\nThis is from an async method...");
            }
        }
    }
}
