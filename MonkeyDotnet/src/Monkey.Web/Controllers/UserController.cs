using Microsoft.AspNetCore.Mvc;
using Monkey.Web.Service;

namespace Monkey.Web.Controllers;

public class UserController(
    UserService userService) : Controller
{
    [HttpGet, Route("/api/users")]
    public async Task<IActionResult> Index()
    {
        var users = await userService.GetUsersAsync();
        return Ok(users);
    }

    [HttpPut, Route("/api/users")]
    public async Task<IActionResult> Create([FromBody] string name)
    {
        var id = await userService.CreateUser(name);
        return Ok(id);
    }
}
