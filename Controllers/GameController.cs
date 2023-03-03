using Microsoft.AspNetCore.Mvc;

namespace MyGameDB.Controllers;

[ApiController]
[Route("game")]
public class GameController : ControllerBase
{
    private readonly ILogger<GameController> _logger;

    public GameController(ILogger<GameController> logger)
    {
        _logger = logger;
    }

    [HttpGet("{id}")]
    public ActionResult<Game> GetGame(int id)
    {
        // Mock Data
        var games = new List<Game>
        {
            new Game { Id = 1, Title = "Super Mario Bros.", ReleaseDate = new DateTime(1985, 9, 13), Platform = "NES", Genre = "Platformer" },
            new Game { Id = 2, Title = "The Legend of Zelda", ReleaseDate = new DateTime(1986, 2, 21), Platform = "NES", Genre = "Action-adventure" },
            new Game { Id = 3, Title = "Final Fantasy VII", ReleaseDate = new DateTime(1997, 1, 31), Platform = "PlayStation", Genre = "Role-playing" },
            new Game { Id = 4, Title = "Half-Life 2", ReleaseDate = new DateTime(2004, 11, 16), Platform = "PC", Genre = "First-person shooter" },
        };

        var game = games.FirstOrDefault(g => g.Id == id);
        if (game == null)
        {
            return NotFound();
        }

        return game;
    }
}