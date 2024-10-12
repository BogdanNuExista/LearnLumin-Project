namespace LearnLumin.DAL.DTOs.LearningAndProgress;

public class LearningPathResponseDto
{
    public string Id { get; set; } = null!;
    
    public string Title { get; set; } = null!;
    
    public string Description { get; set; } = null!;
    
    public DateTime CreatedDate { get; set; }
    
    public string UserId { get; set; } = null!;
    
    public ICollection<string> CourseTitles { get; set; } = new List<string>();
}