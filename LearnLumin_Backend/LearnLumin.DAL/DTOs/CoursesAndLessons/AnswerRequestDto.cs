namespace LearnLumin.DAL.DTOs.CoursesAndLessons;

public class AnswerRequestDto
{
    public string Content { get; set; } = null!;
    
    public bool IsCorrect { get; set; }
    
    public string QuestionId { get; set; } = null!;
}