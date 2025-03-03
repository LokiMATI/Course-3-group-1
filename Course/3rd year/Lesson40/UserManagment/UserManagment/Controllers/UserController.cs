using Microsoft.AspNetCore.Mvc;
using UserManagment.Managers;
using UserManagment.Managers.Users.Interface;
using UserManagment.Models;
using UserManagment.Models.Managers.Implementation;
using UserManagment.Service.Interface;

namespace UserManagment.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserManager _userManager;
    private readonly ISendEmailService _sendEmailService;

    public UserController(IUserManager userManager, ISendEmailService sendEmailService)
    {
        _userManager = userManager;
        _sendEmailService = sendEmailService;
    }

    [HttpPost("CreateUser")]
    public IActionResult CreateUser(string username, string email)
    {
        _userManager.AddUser(username, email);
        _sendEmailService.SendWelcomeEmail(email);
        return Content($"User {username} created.");
    }

    [HttpDelete("RemoveUser")]
    public IActionResult RemoveUser(int userId)
    {
        _userManager.DeleteUser(userId);
        return Content($"User with ID {userId} removed.");
    }

    [HttpGet("ShowUser")]
    public IActionResult ShowUser(int userId)
    {
        var user = _userManager.GetUser(userId);
        if (user != null)
        {
            return Content($"User: {user.Username}, Email: {user.Email}");
        }
        return Content("User not found.");
    }

    [HttpGet("ListUsers")]
    public IActionResult ListUsers()
    {
        var users = _userManager.GetAllUser();
        var userList = string.Join("<br/>", users.Select(u => $"Id: {u.Id}, User: {u.Username}, Email: {u.Email}"));
        return Content(userList);
    }
}
