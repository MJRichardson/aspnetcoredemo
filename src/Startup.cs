using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.PlatformAbstractions;

namespace aspnetcoredemo

{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
           var builder = new ConfigurationBuilder(); 
           builder.SetBasePath(PlatformServices.Default.Application.ApplicationBasePath);
           builder.AddJsonFile("appsettings.json"); 

           var config = builder.Build();
           var greeting = config["HomePage:Greeting"]; 
           var platform = config["HomePage:Platform"]; 

            app.Run(context =>
            {
                return context.Response.WriteAsync($"{greeting} from {platform}!");
            });
        }
    }
}