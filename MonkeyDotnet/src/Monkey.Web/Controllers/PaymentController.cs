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
            return BadRequest("���z��0���傫���Ȃ���΂Ȃ�܂���B");
        }

        var id = await userService.CreatePayment(userId, yen);
        return Ok(id);
    }
}
