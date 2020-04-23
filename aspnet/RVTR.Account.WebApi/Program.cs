using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RVTR.Account.DataContext;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace RVTR.Account.WebApi
{
  public class Program
  {
    public static void Main(string[] args)
    {
      CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
              webBuilder.UseStartup<Startup>();
            });
    public static IHost LoadDatabase(IHost host)
    {
      using( var dbContext = host.Services.GetRequiredService<AccountDbContext>())
      {
          dbContext.Database.EnsureCreated();
          // dbContext.Database.Migrate();
      }
      return host;
    }
        
  }
  
}
