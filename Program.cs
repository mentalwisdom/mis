using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace MIS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //need to be this need , very import other wise ,
            //you will get Unable to create an object of type 'FpDbContext'
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
               WebHost.CreateDefaultBuilder(args)
             .UseUrls("http://0.0.0.0:5100/")
                .UseStartup<Startup>();
        
    }
}
