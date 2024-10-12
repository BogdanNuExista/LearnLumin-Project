namespace LearnLumin.DAL.DTOs.LearningAndProgress;

public class LearningPathRequestDto
{
    public string Title { get; set; } = null!;
    
    public string Description { get; set; } = null!;
    
    public string UserId { get; set; } = null!;
    
    public ICollection<string> CourseIds { get; set; } = new List<string>();
}