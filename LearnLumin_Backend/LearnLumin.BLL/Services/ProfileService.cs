using AutoMapper;
using LearnLumin.BLL.Interfaces;
using LearnLumin.DAL.DTOs.UserAndRoles;
using LearnLumin.DAL.Repositories;
using Profile = LearnLumin.DAL.Entities.UsersAndRoles.Profile;

namespace LearnLumin.BLL.Services;

public class ProfileService : IProfileService
{
    private readonly ProfileRepository _profileRepository;
    private readonly IMapper _mapper;
    
    public ProfileService(ProfileRepository profileRepository, IMapper mapper)
    {
        _profileRepository = profileRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<ProfileResponseDto>> GetAllProfilesAsync()
    {
        var profiles = await _profileRepository.GetAllAsync();
        return _mapper.Map<IEnumerable<ProfileResponseDto>>(profiles);
    }

    public async Task<ProfileResponseDto?> GetProfileByIdAsync(string id)
    {
        var profile = await _profileRepository.GetByIdAsync(id);
        
        return _mapper.Map<ProfileResponseDto>(profile);
    }

    public async Task<ProfileResponseDto> CreateProfileAsync(ProfileRequestDto profileRequestDto)
    {
        var addedProfile = await _profileRepository.AddAsync(profileRequestDto);
        
        return _mapper.Map<ProfileResponseDto>(addedProfile);
    }

    public async Task<ProfileResponseDto?> UpdateProfileAsync(string id, ProfileRequestDto profileRequestDto)
    {
        var profile = _mapper.Map<Profile>(profileRequestDto);

        if (profile == null)
        {
            return null;
        }
        
        _mapper.Map(profileRequestDto, profile);
        
        var updatedProfile = await _profileRepository.UpdateAsync(profile);
        
        return _mapper.Map<ProfileResponseDto>(updatedProfile);
    }

    public async Task<ProfileResponseDto?> DeleteProfileAsync(string id)
    {
        var profile = await _profileRepository.GetByIdAsync(id);
        
        if (profile == null)
        {
            return null;
        }
        
        await _profileRepository.DeleteAsync(profile.Id);
        
        return _mapper.Map<ProfileResponseDto>(profile);
    }
}