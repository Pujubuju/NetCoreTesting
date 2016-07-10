using System;
using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseKestrel()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }

    public class Startup
    {
        // public void Configure(IApplicationBuilder app)
        // {
        //     app.Use(async (context, next) =>
        //     {
        //         await context.Response.WriteAsync("Pre Processing request from: ");
        //         await context.Response.WriteAsync(context.Connection.LocalIpAddress.ToString());
        //         await next();
        //         await context.Response.WriteAsync(" Post Processing. Done.");
        //     });

        //     app.Run(async (context) =>
        //     {
        //         await context.Response.WriteAsync(
        //             "Hello World. The Time is: " +
        //             DateTime.Now.ToString("hh:mm:ss tt"));

        //     });
        // }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();

            app.Use(async (context, next) =>
            {
                Console.WriteLine(context.Request.Path);
                await next();
            });

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync(
                    "Hello World. The Time is: " +
                    DateTime.Now.ToString("hh:mm:ss tt"));

            });
        }
    }

    public class HelloWorldController : Controller
    {
        [HttpGet("api/helloworld")]
        public object HelloWorld()
        {
            return new
            {
                message = "Hello World",
                time = DateTime.Now
            };
        }

        [HttpGet("helloworld")]
        public ActionResult Helloworld()
        {
            ViewBag.Message = "Hello world!";
            ViewBag.Time = DateTime.Now;
            return View("helloworld");
        }
    }
}