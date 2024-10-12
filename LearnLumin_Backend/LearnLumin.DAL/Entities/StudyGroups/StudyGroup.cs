using LearnLumin.DAL.Entities.UsersAndRoles;

namespace LearnLumin.DAL.Entities.StudyGroups;

public class StudyGroup
{
    public string Id { get; set; } = null!;
    
    public string Title { get; set; } = null!;
    
    public string Description { get; set; } = null!;
    
    public DateTime CreatedDate { get; set; }

    
    public User Creator { get; set; } = null!;
    
    public ICollection<GroupMembership> Memberships { get; set; } = new List<GroupMembership>();
}