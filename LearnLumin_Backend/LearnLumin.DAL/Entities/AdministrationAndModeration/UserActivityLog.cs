using LearnLumin.DAL.Entities.UsersAndRoles;

namespace LearnLumin.DAL.Entities.AdministrationAndModeration;

public class UserActivityLog
{
    public string Id { get; set; } = null!;
    
    public string ActivityType { get; set; } = null!;
    
    public DateTime ActivityDate { get; set; } 
    
    public string Details { get; set; } = null!;

    
    public User User { get; set; } = null!;
}