using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    [HttpPost("create")]
    [ValidateModel] // Apply the custom validation filter
    public IActionResult CreateUser([FromBody] UserModel user)
    {
        return Ok(new { message = "User created successfully!", user });
    }
}
