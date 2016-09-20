using HelloWorldBusiness;
using System;

namespace HelloWorldWithTests
{
    public static class Program
    {
        static void Main(string[] args)
        {
            IGreeting greeting = new Greeting();

            Console.WriteLine(greeting.GetGreeting);
        }
    }
}
