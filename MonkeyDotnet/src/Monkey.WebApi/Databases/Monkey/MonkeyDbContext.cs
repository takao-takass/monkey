using Microsoft.EntityFrameworkCore;
using Monkey.WebApi.Databases.Monkey.Sample;

namespace Monkey.WebApi.Databases.Monkey;

public class MonkeyDbContext(DbContextOptions<MonkeyDbContext> options) : DbContext(options)
{
    public DbSet<TSample> TSamples { get; set; }

    public async Task MigrationDatabaseAsync()
    {
        await this.Database.MigrateAsync();
    }
}
