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
    [Route("register")]
    public void regiser([FromBody] UsreModel user) {
        userService.register(user);
    }

    [HttpGet]
    [Route("getAllUsers")]
    public List<UsreModel> getAllUsers() {
        return userService.getAllUsers();
    }
 }