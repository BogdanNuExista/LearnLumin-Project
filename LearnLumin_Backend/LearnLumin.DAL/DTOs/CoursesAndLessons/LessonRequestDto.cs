namespace LearnLumin.DAL.DTOs.CoursesAndLessons;

public class LessonRequestDto
{
    public string Title { get; set; } = null!;
    
    public string Content { get; set; } = null!;
    
    public int Order { get; set; }
    
    public string CourseId { get; set; } = null!;
}