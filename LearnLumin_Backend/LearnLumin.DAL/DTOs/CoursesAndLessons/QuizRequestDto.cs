namespace LearnLumin.DAL.DTOs.CoursesAndLessons;

public class QuizRequestDto
{
    public string Title { get; set; } = null!;
    
    public string Description { get; set; } = null!;
    
    public string LessonId { get; set; } = null!;
    
    public string CourseId { get; set; } = null!;
}