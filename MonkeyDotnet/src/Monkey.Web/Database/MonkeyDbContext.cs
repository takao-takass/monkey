using Microsoft.EntityFrameworkCore;

namespace Monkey.Web.Database;

public class MonkeyDbContext : DbContext
{
    public MonkeyDbContext(DbContextOptions<MonkeyDbContext> options)
        : base(options)
    {
    }

    public DbSet<Database.User.User> Users { get; set; }

}
