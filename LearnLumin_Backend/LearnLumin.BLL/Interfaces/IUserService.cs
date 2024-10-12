using LearnLumin.DAL.DTOs.UserAndRoles;

namespace LearnLumin.BLL.Interfaces;

public interface IUserService
{
    Task<IEnumerable<UserResponseDto>> GetAllUsersAsync();
    
    Task<UserResponseDto?> GetUserByIdAsync(string id);
    
    Task<UserResponseDto> CreateUserAsync(UserRequestDto userRequestDto);
    
    Task<UserResponseDto?> UpdateUserAsync(string id, UserRequestDto userRequestDto);
    
    Task<UserResponseDto?> DeleteUserAsync(string id);
    
    Task<UserResponseDto?> AddRoleToUserAsync(string userId, string roleId);
    
    Task<UserResponseDto?> RemoveRoleFromUserAsync(string userId, string roleId);
    
    Task<UserResponseDto?> UpdateProfileAsync(string userId, ProfileUpdateDto profileRequestDto);
    
}