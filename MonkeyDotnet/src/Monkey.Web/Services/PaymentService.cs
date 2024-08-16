using Microsoft.EntityFrameworkCore;
using Monkey.Web.Database;
using Monkey.Web.infrastructures.BaseClasses;

namespace Monkey.Web.Service;

public class PaymentService(MonkeyDbContext dbContext): ServiceBase
{

    public async Task<IEnumerable<Database.Payment.Payment>> GetPaymentsThinWeekAsync(int userId)
    {
        var date = DateTime.Now.Date;

        var monday = DateOnly.Parse(date.AddDays(DayOfWeek.Monday - date.DayOfWeek).ToString("yyyy-MM-dd"));
        var sunday = monday.AddDays(6);

        return await dbContext.Payments
            .Where(p => p.UserId == userId)
            .Where(p => p.PaymentDate >= monday && p.PaymentDate <= sunday)
            .ToListAsync();
    }

    public async Task<long> CreatePayment(int userId, int yen)
    {
        var payment = new Database.Payment.Payment
        {
            UserId = userId,
            PaymentDate = DateOnly.Parse(DateTime.Now.ToString("yyyy-MM-dd")),
            Yen = yen,
            PaidAt = DateTime.UtcNow
        };

        await dbContext.Payments.AddAsync(payment);
        await dbContext.SaveChangesAsync();

        return payment.Id;
    }


}
