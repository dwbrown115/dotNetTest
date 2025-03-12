using Microsoft.AspNetCore.Mvc;
using SharedLibrary;

namespace GameServer.Controllers;

[ApiController]
[Route("[controller]")]
public class PlayerController : ControllerBase
{
    [HttpGet("{id}")]
    public Player Get([FromRoute] string id)
    {
        var player = new Player() { Id = id };

        return player;
    }

    [HttpPost]
    public Player Post(Player player)
    {
        return player;
    }
}
