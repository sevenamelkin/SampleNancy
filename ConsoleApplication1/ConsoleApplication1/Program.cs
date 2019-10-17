using System;
using Nancy.Hosting.Self;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            using (var host = new NancyHost(new Uri("http://localhost:12554/")))
            {
                Console.ReadKey();
            }
        }
    }
}