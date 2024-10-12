/*

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace LearnLumin.DAL.AppDbContext;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        // Get the directory of the DAL project
        string currentDir = Directory.GetCurrentDirectory();
        // Navigate up to the solution directory, then into the Presentation project
        DirectoryInfo solutionDir = Directory.GetParent(currentDir).Parent;
        string presentationDir = Path.Combine(solutionDir.FullName, "LearnLumin.Presentation");

        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(presentationDir)
            .AddJsonFile("appsettings.json")
            .Build();

        var builder = new DbContextOptionsBuilder<AppDbContext>();
        var connectionString = configuration.GetConnectionString("LearnLuminContext");

        builder.UseSqlServer(connectionString);

        return new AppDbContext(builder.Options);
    }
}
*/