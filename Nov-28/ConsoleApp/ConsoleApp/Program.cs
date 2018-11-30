using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Owin;


namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string uri = "http://localhost:8000";
            using (WebApp.Start<StartUp>(uri))
            {
                Console.WriteLine("Hello World!");
                Console.ReadKey();
            }
        }
    }
    public class StartUp
    {
        public void Configuration(IAppBuilder app)
        {
            app.Run(ctx =>
            {
                return ctx.Response.WriteAsync("Hello World");
            });
        }
    }
}
