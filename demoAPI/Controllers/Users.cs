using Microsoft.AspNetCore.Mvc;

namespace demoAPI.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class UserController : ControllerBase
{
    [HttpGet]
    public String Get()
    {
        return "Hello";
    }

    [HttpGet("{id}")]
    public String Get(string id)
    {
        return "Hello" + id;
    }
}