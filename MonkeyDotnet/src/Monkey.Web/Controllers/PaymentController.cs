using Microsoft.AspNetCore.Mvc;
using Monkey.Web.Service;

namespace Monkey.Web.Controllers;

public class PaymentController(
    PaymentService userService) : Controller
{
    [HttpGet, Route("/api/payments")]
    public async Task<IActionResult> Index(int userId)
    {
        var payments = await userService.GetPaymentsThinWeekAsync(userId);
        return Ok(payments);
    }

    [HttpPut, Route("/api/payments")]
    public async Task<IActionResult> Create([FromQuery] int userId, [FromBody] int yen)
    {
        if (yen <= 0)
        {
            return BadRequest("金額は0より大きくなければなりません。");
        }

        var id = await userService.CreatePayment(userId, yen);
        return Ok(id);
    }
}
