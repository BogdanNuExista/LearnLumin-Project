namespace LearnLumin.DAL.DTOs.StudyGroups;

public class StudyGroupRequestDto
{
    public string Title { get; set; } = null!;
    
    public string Description { get; set; } = null!;
    
    public string CreatorId { get; set; } = null!;
}