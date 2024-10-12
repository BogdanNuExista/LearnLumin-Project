namespace LearnLumin.DAL.DTOs.StudyGroups;

public class GroupMembershipResponseDto
{
    public string Id { get; set; } = null!;

    public DateTime JoinDate { get; set; }

    public string StudyGroupId { get; set; } = null!;
    
    public string UserId { get; set; } = null!;
}