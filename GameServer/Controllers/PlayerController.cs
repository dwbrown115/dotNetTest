using GameServer.Services;
using Microsoft.AspNetCore.Mvc;
using SharedLibrary;

namespace GameServer.Controllers;

[ApiController]
[Route("[controller]")]
public class PlayerController : ControllerBase
{
    private readonly IPlayerService _playerService;

    public PlayerController(IPlayerService playerService)
    {
        _playerService = playerService;
    }

    [HttpGet("{id}")]
    public Player Get([FromRoute] string id)
    {
        var player = new Player() { Id = id };

        _playerService.DoSomething();

        return player;
    }

    [HttpPost]
    public Player Post(Player player)
    {
        return player;
    }
}
