namespace LearnLumin.DAL.Entities.UsersAndRoles;

public class Profile
{
    public string Id { get; set; } = null!;

    public string Bio { get; set; } = null!;
    
    public string ProfilePicture { get; set; } = null!;
    
    public string Location { get; set; } = null!;
    
    public string Preferences { get; set; } = null!;

    
    public User User { get; set; } = null!;
}