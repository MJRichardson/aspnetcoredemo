using System;
using Microsoft.AspNetCore.Hosting;

namespace aspnetcoredemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
           var host = new WebHostBuilder()
                .UseKestrel()
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run(); 
        }
    }
}
