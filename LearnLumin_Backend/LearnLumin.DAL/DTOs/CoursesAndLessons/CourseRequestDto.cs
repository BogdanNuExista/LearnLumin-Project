namespace LearnLumin.DAL.DTOs.CoursesAndLessons;

public class CourseRequestDto
{
    public string Title { get; set; } = null!;
    
    public string Description { get; set; } = null!;
    
    public string Category { get; set; } = null!;
    
    public decimal Price { get; set; }
    
    public string CreatorId { get; set; } = null!;
    
    public string LearningPathId { get; set; } = null!;
}