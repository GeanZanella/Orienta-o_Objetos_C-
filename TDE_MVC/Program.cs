using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace TDE_MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new WebHostBuilder()
            .UseKestrel()
            .Configure(
                app =>{
                    app.Run(context => context.Response.WriteAsync("oi cara de boi"));
                }
            )
            .Build();
            host.Run();
        }
    }
}
