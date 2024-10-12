using LearnLumin.DAL.DTOs.UserAndRoles;

namespace LearnLumin.BLL.Interfaces;

public interface IProfileService
{
    Task<IEnumerable<ProfileResponseDto>> GetAllProfilesAsync();
    
    Task<ProfileResponseDto?> GetProfileByIdAsync(string id);
    
    Task<ProfileResponseDto> CreateProfileAsync(ProfileRequestDto profileRequestDto);
    
    Task<ProfileResponseDto?> UpdateProfileAsync(string id, ProfileRequestDto profileRequestDto);
    
    Task<ProfileResponseDto?> DeleteProfileAsync(string id);
}