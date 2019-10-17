using System;
using Nancy.Hosting.Self;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var hostConfigs = new HostConfiguration
            {
                UrlReservations = new UrlReservations() {CreateAutomatically = true}
            };
            using (var host = new NancyHost(hostConfigs, new Uri("http://localhost:12554/")))
            {
                host.Start();
                Console.ReadKey();
            }
        }
    }
}