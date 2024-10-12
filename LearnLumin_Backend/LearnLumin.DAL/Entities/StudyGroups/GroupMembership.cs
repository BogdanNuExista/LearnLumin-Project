using LearnLumin.DAL.Entities.UsersAndRoles;

namespace LearnLumin.DAL.Entities.StudyGroups;

public class GroupMembership
{
    public string Id { get; set; } = null!;
    
    public DateTime JoinDate { get; set; }
 
    
    public StudyGroup StudyGroup { get; set; } = null!;
    
    public User User { get; set; } = null!;
}