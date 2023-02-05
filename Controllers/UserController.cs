using Microsoft.AspNetCore.Mvc;

namespace webapitest.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class UserController : ControllerBase
{

    [HttpGet("users")]
    public IActionResult Users()
    {

       var users = new[]{
         new {Name = "user1"},
         new {Name = "user2"}
       };

       return Ok(users);
    }

}
