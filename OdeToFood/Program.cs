using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;


namespace OdeToFood
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // web host builder
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
