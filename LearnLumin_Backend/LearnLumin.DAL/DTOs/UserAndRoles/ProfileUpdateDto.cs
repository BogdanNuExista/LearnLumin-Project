namespace LearnLumin.DAL.DTOs.UserAndRoles;

public class ProfileUpdateDto
{
    public string Bio { get; set; } = null!;
    
    public string ProfilePicture { get; set; } = null!;
    
    public string Location { get; set; } = null!;
    
    public string Preferences { get; set; } = null!;
}