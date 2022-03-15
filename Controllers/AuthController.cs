using Microsoft.AspNetCore.Mvc;

using nutriyummy.Model;
using nutriyummy.Services;

namespace nutriyummy.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthController {

    IMongoDbService mongoDbService;
    public AuthController(IMongoDbService mongoDbService) {
        this.mongoDbService = mongoDbService;
    }

    [HttpPost]
    public void Regiser([FromBody] RegiserModel user) {
        mongoDbService.Register(user);
    }

    [HttpGet]
    public List<UsreModel> GetAllUsers() {
        return mongoDbService.GetAllUsers();
    }
 }