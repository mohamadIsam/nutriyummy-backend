namespace nutriyummy.Controllers;

using Microsoft.AspNetCore.Mvc;

using nutriyummy.Model;
using nutriyummy.Services;


[ApiController]
[Route("[controller]")]
public class AuthController {

    IUserService userService;
    public AuthController(IUserService userService) {
        this.userService = userService;
    }

    [HttpPost]
    public void Regiser([FromBody] UsreModel user) {
        userService.register(user);
    }

    [HttpGet]
    public List<UsreModel> GetAllUsers() {
        return userService.getAllUsers();
    }
 }