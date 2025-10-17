using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SweDemoBackend.Application.Interfaces.Repositories;
using SweDemoBackend.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweDemoBackend.Infrastructure
{
  public static class DependencyInjection
  {
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
      var connectionString = configuration.GetConnectionString("BricksForKidsDBConnectionString");
      if (string.IsNullOrWhiteSpace(connectionString))
      {
        throw new InvalidOperationException("Connection string 'BricksForKidsDBConnectionString' was not found.");
      }


      services.AddDbContext<BricksForKidsDbContext>(options =>
      {
        options.UseSqlServer(connectionString, sql =>
        {
          sql.MigrationsAssembly(typeof(BricksForKidsDbContext).Assembly.FullName);
        });
      });

      services.AddScoped<ILegoSetRepository, LegoSetRepository>();

      return services;
    }
  }
}
