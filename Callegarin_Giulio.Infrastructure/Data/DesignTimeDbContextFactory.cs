using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Callegarin_Giulio.Infrastructure.Data;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile(@Directory.GetCurrentDirectory() + "/../Callegarin_Giulio.API/appsettings.json").Build();
        var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
        builder.UseLazyLoadingProxies().UseNpgsql(configuration.GetConnectionString("database"));
        return new ApplicationDbContext(builder.Options);
    }
}
