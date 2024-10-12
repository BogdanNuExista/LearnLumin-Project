namespace LearnLumin.DAL.DTOs.CoursesAndLessons;

public class LessonResponseDto
{
    public string Id { get; set; } = null!;
    
    public string Title { get; set; } = null!;
    
    public string Content { get; set; } = null!;
    
    public int Order { get; set; }
    
    public DateTime CreatedDate { get; set; }
    
    public DateTime? UpdatedDate { get; set; }
    
    public string CourseId { get; set; } = null!;
}