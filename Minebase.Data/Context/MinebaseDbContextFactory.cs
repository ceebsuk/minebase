using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Minebase.Data.Context;

/// <summary>
/// A factory used at design time by the dotnet ef tool to create a MinebaseDbContext instance when running the database update command or creating migrations.
/// </summary>
public class MinebaseDbContextFactory : IDesignTimeDbContextFactory<MinebaseDbContext>
{
    public MinebaseDbContext CreateDbContext(string[] args)
    {
        // Create the options builder.
        var optionsBuilder = new DbContextOptionsBuilder<MinebaseDbContext>();

        // Obtain the project path in order to locate the appsettings.json file.
        var projectPath = Path.Join(Directory.GetParent(Directory.GetCurrentDirectory()).ToString(), "Minebase.Data");
        
        // Build the configuration.
        var configuration = new ConfigurationBuilder()
            .SetBasePath(projectPath)
            .AddJsonFile("appsettings.json")
            .Build();
        
        // Obtain the connection string from the configuration.
        var connectionString = configuration.GetConnectionString("SQLite");
        
        // Add the SQLite database provider passing the connection string.
        optionsBuilder.UseSqlite(connectionString);

        return new MinebaseDbContext(optionsBuilder.Options);
    }
}