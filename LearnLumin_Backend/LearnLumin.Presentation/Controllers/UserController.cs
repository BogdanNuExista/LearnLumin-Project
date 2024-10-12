using LearnLumin.BLL.Interfaces;
using LearnLumin.DAL.DTOs.UserAndRoles;
using Microsoft.AspNetCore.Mvc;

namespace LearnLumin.Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    
    public UserController(IUserService userService)
    {
        _userService = userService;
    }
    
    
    [HttpGet("GetAllUsers")]
    public async Task<IActionResult> GetAllUsersAsync()
    {
        var users = await _userService.GetAllUsersAsync();
        return Ok(users);
    }
    
    [HttpGet("GetUserById/{id}")]
    public async Task<IActionResult> GetUserByIdAsync(string id)
    {
        var user = await _userService.GetUserByIdAsync(id);
        return Ok(user);
    }
    
    [HttpPost("CreateUser")]
    public async Task<IActionResult> CreateUserAsync([FromBody] UserRequestDto userRequestDto)
    {
        var user = await _userService.CreateUserAsync(userRequestDto);
        return Ok(user);
    }
    
    [HttpPut("UpdateUser/{id}")]
    public async Task<IActionResult> UpdateUserAsync(string id, [FromBody] UserRequestDto userRequestDto)
    {
        var user = await _userService.UpdateUserAsync(id, userRequestDto);
        return Ok(user);
    }
    
    [HttpDelete("DeleteUser/{id}")]
    public async Task<IActionResult> DeleteUserAsync(string id)
    {
        var deletedUser = await _userService.DeleteUserAsync(id);
        return Ok(deletedUser);
    }
    
    
    [HttpPost("AddRoleToUser/{userId}/{roleId}")]
    public async Task<IActionResult> AddRoleToUserAsync(string userId, string roleId)
    {
        var user = await _userService.AddRoleToUserAsync(userId, roleId);
        return Ok(user);
    }
    
    [HttpDelete("RemoveRoleFromUser/{userId}/{roleId}")]
    public async Task<IActionResult> RemoveRoleFromUserAsync(string userId, string roleId)
    {
        var user = await _userService.RemoveRoleFromUserAsync(userId, roleId);
        return Ok(user);
    }
    
    
    
    [HttpPut("UpdateProfile/{userId}")]
    public async Task<IActionResult> UpdateProfileAsync(string userId, [FromBody] ProfileUpdateDto profileUpdateDto)
    {
        var profile = await _userService.UpdateProfileAsync(userId, profileUpdateDto);
        return Ok(profile);
    } 
    
    
}