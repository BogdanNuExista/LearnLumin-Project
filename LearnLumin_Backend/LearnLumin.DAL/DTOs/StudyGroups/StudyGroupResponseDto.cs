namespace LearnLumin.DAL.DTOs.StudyGroups;

public class StudyGroupResponseDto
{
    public string Id { get; set; } = null!;
    public string Title { get; set; } = null!;
    
    public string Description { get; set; } = null!;
    
    public DateTime CreatedDate { get; set; }
    
    public string CreatorUsername { get; set; } = null!;
    
    public ICollection<GroupMembershipResponseDto> Memberships { get; set; } = new List<GroupMembershipResponseDto>();
}