namespace LearnLumin.DAL.DTOs.CoursesAndLessons;

public class QuizResponseDto
{
    public string Id { get; set; } = null!;
    
    public string Title { get; set; } = null!;
    
    public string Description { get; set; } = null!;
    
    public DateTime CreatedDate { get; set; }
    
    public DateTime? UpdatedDate { get; set; }
    
    public string LessonId { get; set; } = null!;
    
    public string CourseId { get; set; } = null!;
}