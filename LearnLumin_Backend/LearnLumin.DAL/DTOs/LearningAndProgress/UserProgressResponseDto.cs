namespace LearnLumin.DAL.DTOs.LearningAndProgress;

public class UserProgressResponseDto
{
    public string Id { get; set; } = null!;

    public decimal ProgressPercentage { get; set; }
    
    public DateTime LastAccessedDate { get; set; }

    public string UserId { get; set; } = null!;
    
    public string CourseId { get; set; } = null!;
    
    public string LessonId { get; set; } = null!;
}