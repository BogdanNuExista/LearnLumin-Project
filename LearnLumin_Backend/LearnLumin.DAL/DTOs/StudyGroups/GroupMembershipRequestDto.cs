namespace LearnLumin.DAL.DTOs.StudyGroups;

public class GroupMembershipRequestDto
{
    public DateTime JoinDate { get; set; }
    
    public string StudyGroupId { get; set; } = null!;
    
    public string UserId { get; set; } = null!;
}