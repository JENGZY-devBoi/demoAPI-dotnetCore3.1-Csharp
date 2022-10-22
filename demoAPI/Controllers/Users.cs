using Microsoft.AspNetCore.Mvc;
using demoAPI.Models;

namespace demoAPI.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class UsersController : ControllerBase
{
    [HttpGet]
    public IEnumerable<UserModel> Get()
    {
        List<UserModel> list = new List<UserModel>();
        list.Add(new UserModel
        {
            Id = "001",
            Name = "user1",
            Age = 20
        });
        list.Add(new UserModel
        {
            Id = "002",
            Name = "user2",
            Age = 25
        });
        list.Add(new UserModel
        {
            Id = "003",
            Name = "user3",
            Age = 30
        });

        return list;
    }

    [HttpGet("{id}")]
    public UserModel Get(String id)
    {
        return new UserModel
        {
            Id = id,
            Name = "user1",
            Age = 20
        };
    }

    [HttpDelete("{id}")]
    public UserModel Del(String id)
    {
        return new UserModel
        {
            Id = id,
            Name = "Deleted",
            Age = 20
        };
    }

    [HttpPost]
    public UserModel Create(UserModel data)
    {
        data.Name += " Created";
        return data;
    }

    [HttpPut]
    public UserModel Update(UserModel data)
    {
        data.Name += " Updated";
        return data;
    }
}