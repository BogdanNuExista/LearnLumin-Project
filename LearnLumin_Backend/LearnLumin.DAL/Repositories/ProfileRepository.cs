using LearnLumin.DAL.DTOs.UserAndRoles;
using LearnLumin.DAL.Entities.UsersAndRoles;
using Microsoft.EntityFrameworkCore;

namespace LearnLumin.DAL.Repositories;

public class ProfileRepository : BaseRepository<Profile>
{
    private readonly LearnLuminContext _context;
    
    public ProfileRepository(LearnLuminContext context) : base(context)
    {
        _context = context;
    }
    
    public override async Task<Profile?> GetByIdAsync(string id)
    {
        try
        {
            return await _context.Profiles
                .Include(p=>p.User)
                .FirstOrDefaultAsync(p => p.Id == id);
        }
        catch (Exception ex)
        {
            throw new Exception($"Couldn't retrieve profile: {ex.Message}");
        }
        
    }
    
    public override async Task<IEnumerable<Profile>> GetAllAsync()
    {
        try
        {
            return await _context.Profiles
                .Include(p=>p.User)
                .ToListAsync();
        }
        catch (Exception ex)
        {
            throw new Exception($"Couldn't retrieve profiles: {ex.Message}");
        }
    }
    
    public override async Task<Profile> UpdateAsync(Profile profile)
    {
        try
        {
            _context.Profiles.Update(profile);
            await _context.SaveChangesAsync();
            return profile;
        }
        catch (Exception ex)
        {
            throw new Exception($"Couldn't update profile: {ex.Message}");
        }
    }
    
    public override async Task<Profile> DeleteAsync(string id)
    {
        try
        {
            var profile = await _context.Profiles.FindAsync(id);
            if(profile == null)
            {
                throw new Exception("Profile not found");
            }
            
            _context.Profiles.Remove(profile);
            await _context.SaveChangesAsync();
            return profile;
        }
        catch (Exception ex)
        {
            throw new Exception($"Couldn't delete profile: {ex.Message}");
        }
    }
    
    
    
    public async Task<Profile> AddAsync(ProfileRequestDto profileRequestDto)
    {
        try
        {
            var user = await _context.Users.FindAsync(profileRequestDto.UserId);
            if(user == null)
            {
                throw new Exception("User not found");
            }
            
            var profile = new Profile
            {
                Bio = profileRequestDto.Bio,
                ProfilePicture = profileRequestDto.ProfilePicture,
                Location = profileRequestDto.Location,
                Preferences = profileRequestDto.Preferences,
                User = user
            };
            
            await _context.Profiles.AddAsync(profile);
            await _context.SaveChangesAsync();
            return profile;
        }
        catch (Exception ex)
        {
            throw new Exception($"Couldn't add profile: {ex.Message}");
        }
    }
}