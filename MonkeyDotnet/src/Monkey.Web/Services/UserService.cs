using Microsoft.EntityFrameworkCore;
using Monkey.Web.Database;
using Monkey.Web.infrastructures.BaseClasses;

namespace Monkey.Web.Service;

public class UserService(MonkeyDbContext dbContext) : ServiceBase
{

    public async Task<IEnumerable<Database.User.User>> GetUsersAsync()
    {
        return await dbContext.Users.Take(100).ToListAsync();
    }

    public async Task<int> CreateUser(string name)
    {
        var user = new Database.User.User
        {
            Name = name
        };

        await dbContext.Users.AddAsync(user);
        await dbContext.SaveChangesAsync();

        return user.Id;
    }


}
