using Microsoft.EntityFrameworkCore;

namespace Monkey.Web.Database;

public class MonkeyDbContext : DbContext
{
    public MonkeyDbContext(DbContextOptions<MonkeyDbContext> options)
        : base(options)
    {
    }

    public DbSet<User.User> Users { get; set; }

    public DbSet<Payment.Payment> Payments { get; set; }
}
