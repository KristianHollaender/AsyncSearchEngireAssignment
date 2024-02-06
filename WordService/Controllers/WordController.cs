using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace WordService.Controllers;

[ApiController]
[Route("[controller]")]
public class WordController : ControllerBase
{
    private readonly Database _database = Database.GetInstance();

    [HttpGet]
    public async Task<Dictionary<string, int>> GetAsync()
    {
        return await _database.GetAllWordsAsync();
    }

    [HttpPost]
    public async Task Post([FromBody]Dictionary<string, int> res)
    {
        await _database.InsertAllWordsAsync(res);
    }
}